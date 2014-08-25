namespace MyLife
{
    partial class WebcamImageTaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TakePictureBtn = new System.Windows.Forms.Button();
            this.SavePictureBtn = new System.Windows.Forms.Button();
            this.TemplateOutlinesCB = new System.Windows.Forms.ComboBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.lstAudioDevices = new System.Windows.Forms.ListBox();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // TakePictureBtn
            // 
            this.TakePictureBtn.Enabled = false;
            this.TakePictureBtn.Location = new System.Drawing.Point(112, 350);
            this.TakePictureBtn.Name = "TakePictureBtn";
            this.TakePictureBtn.Size = new System.Drawing.Size(90, 32);
            this.TakePictureBtn.TabIndex = 0;
            this.TakePictureBtn.Text = "Take Picture";
            this.TakePictureBtn.UseVisualStyleBackColor = true;
            this.TakePictureBtn.Click += new System.EventHandler(this.TakePictureBtn_Click);
            // 
            // SavePictureBtn
            // 
            this.SavePictureBtn.Location = new System.Drawing.Point(208, 350);
            this.SavePictureBtn.Name = "SavePictureBtn";
            this.SavePictureBtn.Size = new System.Drawing.Size(82, 32);
            this.SavePictureBtn.TabIndex = 1;
            this.SavePictureBtn.Text = "Save Picture";
            this.SavePictureBtn.UseVisualStyleBackColor = true;
            this.SavePictureBtn.Click += new System.EventHandler(this.SavePictureBtn_Click);
            // 
            // TemplateOutlinesCB
            // 
            this.TemplateOutlinesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemplateOutlinesCB.FormattingEnabled = true;
            this.TemplateOutlinesCB.Location = new System.Drawing.Point(61, 38);
            this.TemplateOutlinesCB.Name = "TemplateOutlinesCB";
            this.TemplateOutlinesCB.Size = new System.Drawing.Size(121, 21);
            this.TemplateOutlinesCB.TabIndex = 2;
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(43, 22);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(172, 13);
            this.TemplateLabel.TabIndex = 3;
            this.TemplateLabel.Text = "Select template for image (optional)";
            // 
            // ImagePB
            // 
            this.ImagePB.BackColor = System.Drawing.Color.White;
            this.ImagePB.Location = new System.Drawing.Point(321, 22);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(465, 335);
            this.ImagePB.TabIndex = 0;
            this.ImagePB.TabStop = false;
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(12, 82);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(303, 108);
            this.lstVideoDevices.TabIndex = 4;
            // 
            // lstAudioDevices
            // 
            this.lstAudioDevices.FormattingEnabled = true;
            this.lstAudioDevices.Location = new System.Drawing.Point(12, 196);
            this.lstAudioDevices.Name = "lstAudioDevices";
            this.lstAudioDevices.Size = new System.Drawing.Size(303, 108);
            this.lstAudioDevices.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(12, 350);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 32);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // WebcamImageTaker
            // 
            this.AcceptButton = this.SavePictureBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 537);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lstAudioDevices);
            this.Controls.Add(this.lstVideoDevices);
            this.Controls.Add(this.ImagePB);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.TemplateOutlinesCB);
            this.Controls.Add(this.SavePictureBtn);
            this.Controls.Add(this.TakePictureBtn);
            this.Name = "WebcamImageTaker";
            this.Text = "WebcamImageTaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebcamImageTaker_FormClosing);
            this.Load += new System.EventHandler(this.WebcamImageTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakePictureBtn;
        private System.Windows.Forms.Button SavePictureBtn;
        private System.Windows.Forms.ComboBox TemplateOutlinesCB;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.PictureBox ImagePB;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.ListBox lstAudioDevices;
        private System.Windows.Forms.Button btnPreview;
    }
}