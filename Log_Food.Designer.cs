using ConsoleApplication1.WindowsFormsApplication3;

namespace MyLife
{
    partial class Log_Food
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
            this.LogFoodSaveAndContinueButton = new System.Windows.Forms.Button();
            this.LogFoodRecommendRBNo = new System.Windows.Forms.RadioButton();
            this.LogFoodRecommendRBYes = new System.Windows.Forms.RadioButton();
            this.AddFoodRecommendLabel = new System.Windows.Forms.Label();
            this.LogFoodSaveButton = new System.Windows.Forms.Button();
            this.LogFoodCommentsTextBox = new System.Windows.Forms.TextBox();
            this.LogFoodCookingStyleTextBox = new System.Windows.Forms.TextBox();
            this.LogFoodServingsTextBox = new System.Windows.Forms.TextBox();
            this.LogFoodCommentsLabel = new System.Windows.Forms.Label();
            this.LogFoodCookingStyleLabel = new System.Windows.Forms.Label();
            this.LogFoodTasteRatingLabel = new System.Windows.Forms.Label();
            this.LogFoodServingsLabel = new System.Windows.Forms.Label();
            this.LogFoodNameLabel = new System.Windows.Forms.Label();
            this.LogFoodHeaderLabel = new System.Windows.Forms.Label();
            this.LogFoodDateEatenLabel = new System.Windows.Forms.Label();
            this.LogFoodDateEatenCalendar = new System.Windows.Forms.MonthCalendar();
            this.LogFoodTasteRatingUD = new System.Windows.Forms.NumericUpDown();
            this.LogFoodNameComboBox = new System.Windows.Forms.ComboBox();
            this.LFCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogFoodTasteRatingUD)).BeginInit();
            this.SuspendLayout();
            // 
            // LogFoodSaveAndContinueButton
            // 
            this.LogFoodSaveAndContinueButton.Location = new System.Drawing.Point(397, 306);
            this.LogFoodSaveAndContinueButton.Name = "LogFoodSaveAndContinueButton";
            this.LogFoodSaveAndContinueButton.Size = new System.Drawing.Size(97, 47);
            this.LogFoodSaveAndContinueButton.TabIndex = 35;
            this.LogFoodSaveAndContinueButton.Text = "Save Food and Add Another";
            this.LogFoodSaveAndContinueButton.UseVisualStyleBackColor = true;
            this.LogFoodSaveAndContinueButton.Click += new System.EventHandler(this.LogFoodSaveAndContinueButton_Click);
            // 
            // LogFoodRecommendRBNo
            // 
            this.LogFoodRecommendRBNo.AutoSize = true;
            this.LogFoodRecommendRBNo.Location = new System.Drawing.Point(454, 188);
            this.LogFoodRecommendRBNo.Name = "LogFoodRecommendRBNo";
            this.LogFoodRecommendRBNo.Size = new System.Drawing.Size(39, 17);
            this.LogFoodRecommendRBNo.TabIndex = 33;
            this.LogFoodRecommendRBNo.TabStop = true;
            this.LogFoodRecommendRBNo.Text = "No";
            this.LogFoodRecommendRBNo.UseVisualStyleBackColor = true;
            // 
            // LogFoodRecommendRBYes
            // 
            this.LogFoodRecommendRBYes.AutoSize = true;
            this.LogFoodRecommendRBYes.Location = new System.Drawing.Point(397, 188);
            this.LogFoodRecommendRBYes.Name = "LogFoodRecommendRBYes";
            this.LogFoodRecommendRBYes.Size = new System.Drawing.Size(43, 17);
            this.LogFoodRecommendRBYes.TabIndex = 32;
            this.LogFoodRecommendRBYes.TabStop = true;
            this.LogFoodRecommendRBYes.Text = "Yes";
            this.LogFoodRecommendRBYes.UseVisualStyleBackColor = true;
            // 
            // AddFoodRecommendLabel
            // 
            this.AddFoodRecommendLabel.AutoSize = true;
            this.AddFoodRecommendLabel.Location = new System.Drawing.Point(287, 188);
            this.AddFoodRecommendLabel.Name = "AddFoodRecommendLabel";
            this.AddFoodRecommendLabel.Size = new System.Drawing.Size(67, 13);
            this.AddFoodRecommendLabel.TabIndex = 35;
            this.AddFoodRecommendLabel.Text = "Recommend";
            // 
            // LogFoodSaveButton
            // 
            this.LogFoodSaveButton.Location = new System.Drawing.Point(287, 306);
            this.LogFoodSaveButton.Name = "LogFoodSaveButton";
            this.LogFoodSaveButton.Size = new System.Drawing.Size(97, 47);
            this.LogFoodSaveButton.TabIndex = 34;
            this.LogFoodSaveButton.Text = "Save Food";
            this.LogFoodSaveButton.UseVisualStyleBackColor = true;
            this.LogFoodSaveButton.Click += new System.EventHandler(this.LogFoodSaveButton_Click);
            // 
            // LogFoodCommentsTextBox
            // 
            this.LogFoodCommentsTextBox.Location = new System.Drawing.Point(397, 140);
            this.LogFoodCommentsTextBox.Name = "LogFoodCommentsTextBox";
            this.LogFoodCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.LogFoodCommentsTextBox.TabIndex = 31;
            // 
            // LogFoodCookingStyleTextBox
            // 
            this.LogFoodCookingStyleTextBox.Location = new System.Drawing.Point(397, 108);
            this.LogFoodCookingStyleTextBox.Name = "LogFoodCookingStyleTextBox";
            this.LogFoodCookingStyleTextBox.Size = new System.Drawing.Size(100, 20);
            this.LogFoodCookingStyleTextBox.TabIndex = 30;
            // 
            // LogFoodServingsTextBox
            // 
            this.LogFoodServingsTextBox.Location = new System.Drawing.Point(397, 56);
            this.LogFoodServingsTextBox.Name = "LogFoodServingsTextBox";
            this.LogFoodServingsTextBox.Size = new System.Drawing.Size(100, 20);
            this.LogFoodServingsTextBox.TabIndex = 28;
            // 
            // LogFoodCommentsLabel
            // 
            this.LogFoodCommentsLabel.AutoSize = true;
            this.LogFoodCommentsLabel.Location = new System.Drawing.Point(284, 140);
            this.LogFoodCommentsLabel.Name = "LogFoodCommentsLabel";
            this.LogFoodCommentsLabel.Size = new System.Drawing.Size(56, 13);
            this.LogFoodCommentsLabel.TabIndex = 25;
            this.LogFoodCommentsLabel.Text = "Comments";
            // 
            // LogFoodCookingStyleLabel
            // 
            this.LogFoodCookingStyleLabel.AutoSize = true;
            this.LogFoodCookingStyleLabel.Location = new System.Drawing.Point(284, 110);
            this.LogFoodCookingStyleLabel.Name = "LogFoodCookingStyleLabel";
            this.LogFoodCookingStyleLabel.Size = new System.Drawing.Size(75, 13);
            this.LogFoodCookingStyleLabel.TabIndex = 24;
            this.LogFoodCookingStyleLabel.Text = "Cooking Style:";
            // 
            // LogFoodTasteRatingLabel
            // 
            this.LogFoodTasteRatingLabel.AutoSize = true;
            this.LogFoodTasteRatingLabel.Location = new System.Drawing.Point(284, 82);
            this.LogFoodTasteRatingLabel.Name = "LogFoodTasteRatingLabel";
            this.LogFoodTasteRatingLabel.Size = new System.Drawing.Size(71, 13);
            this.LogFoodTasteRatingLabel.TabIndex = 23;
            this.LogFoodTasteRatingLabel.Text = "Taste Rating:";
            // 
            // LogFoodServingsLabel
            // 
            this.LogFoodServingsLabel.AutoSize = true;
            this.LogFoodServingsLabel.Location = new System.Drawing.Point(284, 56);
            this.LogFoodServingsLabel.Name = "LogFoodServingsLabel";
            this.LogFoodServingsLabel.Size = new System.Drawing.Size(51, 13);
            this.LogFoodServingsLabel.TabIndex = 20;
            this.LogFoodServingsLabel.Text = "Servings:";
            // 
            // LogFoodNameLabel
            // 
            this.LogFoodNameLabel.AutoSize = true;
            this.LogFoodNameLabel.Location = new System.Drawing.Point(28, 60);
            this.LogFoodNameLabel.Name = "LogFoodNameLabel";
            this.LogFoodNameLabel.Size = new System.Drawing.Size(65, 13);
            this.LogFoodNameLabel.TabIndex = 0;
            this.LogFoodNameLabel.Text = "Food Name:";
            // 
            // LogFoodHeaderLabel
            // 
            this.LogFoodHeaderLabel.AutoSize = true;
            this.LogFoodHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogFoodHeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogFoodHeaderLabel.Location = new System.Drawing.Point(12, 20);
            this.LogFoodHeaderLabel.Name = "LogFoodHeaderLabel";
            this.LogFoodHeaderLabel.Size = new System.Drawing.Size(131, 25);
            this.LogFoodHeaderLabel.TabIndex = 38;
            this.LogFoodHeaderLabel.Text = "Log a Food";
            // 
            // LogFoodDateEatenLabel
            // 
            this.LogFoodDateEatenLabel.AutoSize = true;
            this.LogFoodDateEatenLabel.Location = new System.Drawing.Point(31, 92);
            this.LogFoodDateEatenLabel.Name = "LogFoodDateEatenLabel";
            this.LogFoodDateEatenLabel.Size = new System.Drawing.Size(61, 13);
            this.LogFoodDateEatenLabel.TabIndex = 39;
            this.LogFoodDateEatenLabel.Text = "Date Eaten";
            // 
            // LogFoodDateEatenCalendar
            // 
            this.LogFoodDateEatenCalendar.Location = new System.Drawing.Point(34, 112);
            this.LogFoodDateEatenCalendar.Name = "LogFoodDateEatenCalendar";
            this.LogFoodDateEatenCalendar.TabIndex = 27;
            // 
            // LogFoodTasteRatingUD
            // 
            this.LogFoodTasteRatingUD.Location = new System.Drawing.Point(397, 82);
            this.LogFoodTasteRatingUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LogFoodTasteRatingUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LogFoodTasteRatingUD.Name = "LogFoodTasteRatingUD";
            this.LogFoodTasteRatingUD.Size = new System.Drawing.Size(100, 20);
            this.LogFoodTasteRatingUD.TabIndex = 29;
            this.LogFoodTasteRatingUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LogFoodNameComboBox
            // 
            this.LogFoodNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.LogFoodNameComboBox.FormattingEnabled = true;
            this.LogFoodNameComboBox.Location = new System.Drawing.Point(129, 57);
            this.LogFoodNameComboBox.Name = "LogFoodNameComboBox";
            this.LogFoodNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.LogFoodNameComboBox.TabIndex = 26;
            this.LogFoodNameComboBox.SelectedValueChanged += new System.EventHandler(this.LogFoodNameComboBox_Leave);
            //this.LogFoodNameComboBox.TextChanged += new System.EventHandler(this.LogFoodNameComboBox_TextChanged);
            this.LogFoodNameComboBox.Enter += new System.EventHandler(this.LogFoodNameComboBox_Enter);
            this.LogFoodNameComboBox.Leave += new System.EventHandler(this.LogFoodNameComboBox_Leave);
            // 
            // LFCancelButton
            // 
            this.LFCancelButton.Location = new System.Drawing.Point(509, 306);
            this.LFCancelButton.Name = "LFCancelButton";
            this.LFCancelButton.Size = new System.Drawing.Size(97, 47);
            this.LFCancelButton.TabIndex = 43;
            this.LFCancelButton.Text = "Cancel";
            this.LFCancelButton.UseVisualStyleBackColor = true;
            this.LFCancelButton.Click += new System.EventHandler(this.LFCancelButton_Click);
            // 
            // Log_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 445);
            this.Controls.Add(this.LFCancelButton);
            this.Controls.Add(this.LogFoodNameComboBox);
            this.Controls.Add(this.LogFoodTasteRatingUD);
            this.Controls.Add(this.LogFoodDateEatenCalendar);
            this.Controls.Add(this.LogFoodDateEatenLabel);
            this.Controls.Add(this.LogFoodHeaderLabel);
            this.Controls.Add(this.LogFoodSaveAndContinueButton);
            this.Controls.Add(this.LogFoodRecommendRBNo);
            this.Controls.Add(this.LogFoodRecommendRBYes);
            this.Controls.Add(this.AddFoodRecommendLabel);
            this.Controls.Add(this.LogFoodSaveButton);
            this.Controls.Add(this.LogFoodCommentsTextBox);
            this.Controls.Add(this.LogFoodCookingStyleTextBox);
            this.Controls.Add(this.LogFoodServingsTextBox);
            this.Controls.Add(this.LogFoodCommentsLabel);
            this.Controls.Add(this.LogFoodCookingStyleLabel);
            this.Controls.Add(this.LogFoodTasteRatingLabel);
            this.Controls.Add(this.LogFoodServingsLabel);
            this.Controls.Add(this.LogFoodNameLabel);
            this.Name = "Log_Food";
            this.Text = "LogFood";
            ((System.ComponentModel.ISupportInitialize)(this.LogFoodTasteRatingUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogFoodSaveAndContinueButton;
        private System.Windows.Forms.RadioButton LogFoodRecommendRBNo;
        private System.Windows.Forms.RadioButton LogFoodRecommendRBYes;
        private System.Windows.Forms.Label AddFoodRecommendLabel;
        private System.Windows.Forms.Button LogFoodSaveButton;
        private System.Windows.Forms.TextBox LogFoodCommentsTextBox;
        private System.Windows.Forms.TextBox LogFoodCookingStyleTextBox;
        private System.Windows.Forms.TextBox LogFoodServingsTextBox;
        private System.Windows.Forms.Label LogFoodCommentsLabel;
        private System.Windows.Forms.Label LogFoodCookingStyleLabel;
        private System.Windows.Forms.Label LogFoodTasteRatingLabel;
        private System.Windows.Forms.Label LogFoodServingsLabel;
        private System.Windows.Forms.Label LogFoodNameLabel;
        private System.Windows.Forms.Label LogFoodHeaderLabel;
        private System.Windows.Forms.Label LogFoodDateEatenLabel;
        private System.Windows.Forms.MonthCalendar LogFoodDateEatenCalendar;
        private System.Windows.Forms.NumericUpDown LogFoodTasteRatingUD;
        private System.Windows.Forms.ComboBox LogFoodNameComboBox;
        private System.Windows.Forms.Button LFCancelButton;
    }
}