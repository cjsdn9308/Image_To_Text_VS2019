
namespace OCR_Test
{
    partial class Image_To_Text
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImageBox = new System.Windows.Forms.PictureBox();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImageBox
            // 
            this.pbxImageBox.Location = new System.Drawing.Point(27, 17);
            this.pbxImageBox.Name = "pbxImageBox";
            this.pbxImageBox.Size = new System.Drawing.Size(350, 350);
            this.pbxImageBox.TabIndex = 0;
            this.pbxImageBox.TabStop = false;
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(437, 17);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(350, 350);
            this.txtTextBox.TabIndex = 1;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(288, 373);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(89, 26);
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "파일열기";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(698, 373);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(89, 26);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "출력";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // Image_To_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.pbxImageBox);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.txtTextBox);
            this.Name = "Image_To_Text";
            this.Text = "Image_To_Text";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImageBox;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnResult;
    }
}

