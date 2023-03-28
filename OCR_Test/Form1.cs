using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OCR_Test
{
    public partial class Image_To_Text : Form
    {
        Bitmap bmp;
        Bitmap ReSizeBitMap;
        public Image_To_Text()
        {
            InitializeComponent();

            this.btnFileOpen.Click += BtnFileOpen_Click;

            this.btnResult.Click += BtnResult_Click;
        }


        private void BtnFileOpen_Click(object sender, EventArgs e)
        {
            string imgfile = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgfile = dialog.FileName;
            }

            try
            {
                int width = 350;
                int height = 350;
                Size resize1 = new Size(width, height);
                bmp = new Bitmap(imgfile);

                ReSizeBitMap = new Bitmap(bmp, resize1);
                //bmp.Size(350, 350);

                this.pbxImageBox.Image = ReSizeBitMap;

                for (int i = 0; i < ReSizeBitMap.Width; i++)
                {
                        for (int j = 0; j < ReSizeBitMap.Height; j++)
                    {
                            Color c = ReSizeBitMap.GetPixel(i, j);
                            int binary = (c.R + c.G + c.B) / 3;

                            if (binary > 200)
                            ReSizeBitMap.SetPixel(i, j, Color.Black);
                        else
                            ReSizeBitMap.SetPixel(i, j, Color.White);
                        }
                    }

                pbxImageBox.Image = ReSizeBitMap;

            }
            catch { }
        }




        private void BtnResult_Click(object sender, EventArgs e)
        {
            Pix pix = PixConverter.ToPix(ReSizeBitMap);

            var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.TesseractAndCube);
            //string whitelist = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //화이트리스트 사용할시 화이트리스트 목록
            //engine.SetVariable("tessedit_char_whitelist", whitelist);
            //화이트리스트 적용

            var result = engine.Process(pix);

            this.txtTextBox.Text = result.GetText().Replace("\n", Environment.NewLine);
        }
    }
}
