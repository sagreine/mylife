namespace MyLife
{
    partial class Flipbook
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
            this.DelayTime_UD = new System.Windows.Forms.DomainUpDown();
            this.FlipPlayButton = new System.Windows.Forms.Button();
            this.main_picture_box = new System.Windows.Forms.PictureBox();
            this.images_CLB = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BodyPartList_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // DelayTime_UD
            // 
            this.DelayTime_UD.Location = new System.Drawing.Point(215, 27);
            this.DelayTime_UD.Name = "DelayTime_UD";
            this.DelayTime_UD.Size = new System.Drawing.Size(102, 20);
            this.DelayTime_UD.TabIndex = 0;
            this.DelayTime_UD.Text = "domainUpDown1";
            // 
            // FlipPlayButton
            // 
            this.FlipPlayButton.Location = new System.Drawing.Point(323, 24);
            this.FlipPlayButton.Name = "FlipPlayButton";
            this.FlipPlayButton.Size = new System.Drawing.Size(75, 23);
            this.FlipPlayButton.TabIndex = 1;
            this.FlipPlayButton.Text = "Play";
            this.FlipPlayButton.UseVisualStyleBackColor = true;
            this.FlipPlayButton.Click += new System.EventHandler(this.FlipPlayButton_Click);
            // 
            // main_picture_box
            // 
            this.main_picture_box.Location = new System.Drawing.Point(197, 65);
            this.main_picture_box.Name = "main_picture_box";
            this.main_picture_box.Size = new System.Drawing.Size(658, 500);
            this.main_picture_box.TabIndex = 2;
            this.main_picture_box.TabStop = false;
            // 
            // images_CLB
            // 
            this.images_CLB.FormattingEnabled = true;
            this.images_CLB.Location = new System.Drawing.Point(12, 66);
            this.images_CLB.Name = "images_CLB";
            this.images_CLB.Size = new System.Drawing.Size(120, 499);
            this.images_CLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pictures to Flip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay time (seconds)";
            // 
            // BodyPartList_CB
            // 
            this.BodyPartList_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyPartList_CB.FormattingEnabled = true;
            this.BodyPartList_CB.Location = new System.Drawing.Point(12, 24);
            this.BodyPartList_CB.Name = "BodyPartList_CB";
            this.BodyPartList_CB.Size = new System.Drawing.Size(121, 21);
            this.BodyPartList_CB.TabIndex = 6;
            // 
            // Flipbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 577);
            this.Controls.Add(this.BodyPartList_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.images_CLB);
            this.Controls.Add(this.main_picture_box);
            this.Controls.Add(this.FlipPlayButton);
            this.Controls.Add(this.DelayTime_UD);
            this.Name = "Flipbook";
            this.Text = "Flipbook";
            ((System.ComponentModel.ISupportInitialize)(this.main_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown DelayTime_UD;
        private System.Windows.Forms.Button FlipPlayButton;
        private System.Windows.Forms.PictureBox main_picture_box;
        private System.Windows.Forms.CheckedListBox images_CLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BodyPartList_CB;
    }
}