namespace MyLife
{
    partial class BodyMeasurements
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.UpdateMeasurementsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Measurements_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.MeasurementLabel = new System.Windows.Forms.Label();
            this.BodyPartLabel = new System.Windows.Forms.Label();
            this.measurement_ID_label = new System.Windows.Forms.Label();
            this.ImageDescriptionLabel = new System.Windows.Forms.Label();
            this.ImageDescriptionTB = new System.Windows.Forms.TextBox();
            this.SavedImagesCB = new System.Windows.Forms.ComboBox();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.DateImageTakenDTP = new System.Windows.Forms.DateTimePicker();
            this.Date_Taken_label = new System.Windows.Forms.Label();
            this.Date_measure_label = new System.Windows.Forms.Label();
            this.DateOfMeasuermentDTP = new System.Windows.Forms.DateTimePicker();
            this.AddBodyPartButton = new System.Windows.Forms.Button();
            this.FlipbookButton = new System.Windows.Forms.Button();
            this.BodyPart_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Measurements_TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(44, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(455, 355);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(218, 434);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(85, 23);
            this.SelectImageButton.TabIndex = 6;
            this.SelectImageButton.Text = "Upload Image";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // UpdateMeasurementsButton
            // 
            this.UpdateMeasurementsButton.Location = new System.Drawing.Point(523, 439);
            this.UpdateMeasurementsButton.Name = "UpdateMeasurementsButton";
            this.UpdateMeasurementsButton.Size = new System.Drawing.Size(122, 23);
            this.UpdateMeasurementsButton.TabIndex = 7;
            this.UpdateMeasurementsButton.Text = "Update Measurements";
            this.UpdateMeasurementsButton.UseVisualStyleBackColor = true;
            this.UpdateMeasurementsButton.Click += new System.EventHandler(this.UpdateMeasurementsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Measurements_TLP);
            this.groupBox1.Location = new System.Drawing.Point(523, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 403);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body Measurements";
            // 
            // Measurements_TLP
            // 
            this.Measurements_TLP.AutoScroll = true;
            this.Measurements_TLP.ColumnCount = 4;
            this.Measurements_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Measurements_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Measurements_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Measurements_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Measurements_TLP.Controls.Add(this.LastUpdatedLabel, 3, 0);
            this.Measurements_TLP.Controls.Add(this.MeasurementLabel, 2, 0);
            this.Measurements_TLP.Controls.Add(this.BodyPartLabel, 1, 0);
            this.Measurements_TLP.Controls.Add(this.measurement_ID_label, 0, 0);
            this.Measurements_TLP.Location = new System.Drawing.Point(7, 20);
            this.Measurements_TLP.Name = "Measurements_TLP";
            this.Measurements_TLP.RowCount = 1;
            this.Measurements_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Measurements_TLP.Size = new System.Drawing.Size(415, 378);
            this.Measurements_TLP.TabIndex = 0;
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Location = new System.Drawing.Point(334, 182);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(77, 13);
            this.LastUpdatedLabel.TabIndex = 2;
            this.LastUpdatedLabel.Text = "Last Measured";
            // 
            // MeasurementLabel
            // 
            this.MeasurementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MeasurementLabel.AutoSize = true;
            this.MeasurementLabel.Location = new System.Drawing.Point(254, 182);
            this.MeasurementLabel.Name = "MeasurementLabel";
            this.MeasurementLabel.Size = new System.Drawing.Size(71, 13);
            this.MeasurementLabel.TabIndex = 1;
            this.MeasurementLabel.Text = "Measurement";
            // 
            // BodyPartLabel
            // 
            this.BodyPartLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BodyPartLabel.AutoSize = true;
            this.BodyPartLabel.Location = new System.Drawing.Point(118, 182);
            this.BodyPartLabel.Name = "BodyPartLabel";
            this.BodyPartLabel.Size = new System.Drawing.Size(53, 13);
            this.BodyPartLabel.TabIndex = 0;
            this.BodyPartLabel.Text = "Body Part";
            // 
            // measurement_ID_label
            // 
            this.measurement_ID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.measurement_ID_label.AutoSize = true;
            this.measurement_ID_label.Location = new System.Drawing.Point(11, 182);
            this.measurement_ID_label.Name = "measurement_ID_label";
            this.measurement_ID_label.Size = new System.Drawing.Size(18, 13);
            this.measurement_ID_label.TabIndex = 3;
            this.measurement_ID_label.Text = "ID";
            // 
            // ImageDescriptionLabel
            // 
            this.ImageDescriptionLabel.AutoSize = true;
            this.ImageDescriptionLabel.Location = new System.Drawing.Point(41, 505);
            this.ImageDescriptionLabel.Name = "ImageDescriptionLabel";
            this.ImageDescriptionLabel.Size = new System.Drawing.Size(92, 13);
            this.ImageDescriptionLabel.TabIndex = 9;
            this.ImageDescriptionLabel.Text = "Image Description";
            // 
            // ImageDescriptionTB
            // 
            this.ImageDescriptionTB.Location = new System.Drawing.Point(139, 502);
            this.ImageDescriptionTB.Name = "ImageDescriptionTB";
            this.ImageDescriptionTB.Size = new System.Drawing.Size(266, 20);
            this.ImageDescriptionTB.TabIndex = 10;
            // 
            // SavedImagesCB
            // 
            this.SavedImagesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SavedImagesCB.FormattingEnabled = true;
            this.SavedImagesCB.Location = new System.Drawing.Point(44, 46);
            this.SavedImagesCB.Name = "SavedImagesCB";
            this.SavedImagesCB.Size = new System.Drawing.Size(162, 21);
            this.SavedImagesCB.TabIndex = 11;
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Enabled = false;
            this.SaveImageButton.Location = new System.Drawing.Point(414, 434);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(85, 23);
            this.SaveImageButton.TabIndex = 12;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // DateImageTakenDTP
            // 
            this.DateImageTakenDTP.Location = new System.Drawing.Point(139, 523);
            this.DateImageTakenDTP.Name = "DateImageTakenDTP";
            this.DateImageTakenDTP.Size = new System.Drawing.Size(266, 20);
            this.DateImageTakenDTP.TabIndex = 13;
            // 
            // Date_Taken_label
            // 
            this.Date_Taken_label.AutoSize = true;
            this.Date_Taken_label.Location = new System.Drawing.Point(41, 529);
            this.Date_Taken_label.Name = "Date_Taken_label";
            this.Date_Taken_label.Size = new System.Drawing.Size(100, 13);
            this.Date_Taken_label.TabIndex = 14;
            this.Date_Taken_label.Text = "Date Picture Taken";
            // 
            // Date_measure_label
            // 
            this.Date_measure_label.AutoSize = true;
            this.Date_measure_label.Location = new System.Drawing.Point(520, 480);
            this.Date_measure_label.Name = "Date_measure_label";
            this.Date_measure_label.Size = new System.Drawing.Size(109, 13);
            this.Date_measure_label.TabIndex = 16;
            this.Date_measure_label.Text = "Date of Measurement";
            // 
            // DateOfMeasuermentDTP
            // 
            this.DateOfMeasuermentDTP.Location = new System.Drawing.Point(635, 473);
            this.DateOfMeasuermentDTP.Name = "DateOfMeasuermentDTP";
            this.DateOfMeasuermentDTP.Size = new System.Drawing.Size(191, 20);
            this.DateOfMeasuermentDTP.TabIndex = 15;
            // 
            // AddBodyPartButton
            // 
            this.AddBodyPartButton.Location = new System.Drawing.Point(651, 439);
            this.AddBodyPartButton.Name = "AddBodyPartButton";
            this.AddBodyPartButton.Size = new System.Drawing.Size(106, 23);
            this.AddBodyPartButton.TabIndex = 17;
            this.AddBodyPartButton.Text = "Add new Body Part";
            this.AddBodyPartButton.UseVisualStyleBackColor = true;
            this.AddBodyPartButton.Click += new System.EventHandler(this.AddBodyPartButton_Click);
            // 
            // FlipbookButton
            // 
            this.FlipbookButton.Location = new System.Drawing.Point(44, 556);
            this.FlipbookButton.Name = "FlipbookButton";
            this.FlipbookButton.Size = new System.Drawing.Size(75, 23);
            this.FlipbookButton.TabIndex = 18;
            this.FlipbookButton.Text = "Flipbook!";
            this.FlipbookButton.UseVisualStyleBackColor = true;
            this.FlipbookButton.Click += new System.EventHandler(this.FlipbookButton_Click);
            // 
            // BodyPart_CB
            // 
            this.BodyPart_CB.FormattingEnabled = true;
            this.BodyPart_CB.Location = new System.Drawing.Point(139, 480);
            this.BodyPart_CB.Name = "BodyPart_CB";
            this.BodyPart_CB.Size = new System.Drawing.Size(266, 21);
            this.BodyPart_CB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Body Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "View Saved image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Take Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BodyMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BodyPart_CB);
            this.Controls.Add(this.FlipbookButton);
            this.Controls.Add(this.AddBodyPartButton);
            this.Controls.Add(this.Date_measure_label);
            this.Controls.Add(this.DateOfMeasuermentDTP);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Date_Taken_label);
            this.Controls.Add(this.DateImageTakenDTP);
            this.Controls.Add(this.SaveImageButton);
            this.Controls.Add(this.SavedImagesCB);
            this.Controls.Add(this.ImageDescriptionTB);
            this.Controls.Add(this.ImageDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateMeasurementsButton);
            this.Controls.Add(this.SelectImageButton);
            this.Name = "BodyMeasurements";
            this.Text = "BodyMeasurements";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Measurements_TLP.ResumeLayout(false);
            this.Measurements_TLP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button UpdateMeasurementsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ImageDescriptionLabel;
        private System.Windows.Forms.TextBox ImageDescriptionTB;
        private System.Windows.Forms.ComboBox SavedImagesCB;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.TableLayoutPanel Measurements_TLP;
        private System.Windows.Forms.Label LastUpdatedLabel;
        private System.Windows.Forms.Label MeasurementLabel;
        private System.Windows.Forms.Label BodyPartLabel;
        private System.Windows.Forms.DateTimePicker DateImageTakenDTP;
        private System.Windows.Forms.Label Date_Taken_label;
        private System.Windows.Forms.Label Date_measure_label;
        private System.Windows.Forms.DateTimePicker DateOfMeasuermentDTP;
        private System.Windows.Forms.Label measurement_ID_label;
        private System.Windows.Forms.Button AddBodyPartButton;
        private System.Windows.Forms.Button FlipbookButton;
        private System.Windows.Forms.ComboBox BodyPart_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}