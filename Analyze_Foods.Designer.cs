namespace MyLife
{
    partial class Analyze_Foods
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
            this.AnalysisListBox = new System.Windows.Forms.ListBox();
            this.ANFSelectFood = new System.Windows.Forms.Label();
            this.ANFLastUsedLabel = new System.Windows.Forms.Label();
            this.ANFLastUsedTextBox = new System.Windows.Forms.TextBox();
            this.ANFTimesEatenLabel = new System.Windows.Forms.Label();
            this.ANFTimesEatenUD = new System.Windows.Forms.NumericUpDown();
            this.ANFAvgTasteRating = new System.Windows.Forms.Label();
            this.ANFAvgTasteUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ANFTimesEatenUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANFAvgTasteUD)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalysisListBox
            // 
            this.AnalysisListBox.FormattingEnabled = true;
            this.AnalysisListBox.Location = new System.Drawing.Point(12, 50);
            this.AnalysisListBox.Name = "AnalysisListBox";
            this.AnalysisListBox.Size = new System.Drawing.Size(128, 264);
            this.AnalysisListBox.TabIndex = 1;
            this.AnalysisListBox.SelectedValueChanged += new System.EventHandler(this.AnalysisListBox_SelectedValueChanged);
            // 
            // ANFSelectFood
            // 
            this.ANFSelectFood.AutoSize = true;
            this.ANFSelectFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANFSelectFood.Location = new System.Drawing.Point(13, 31);
            this.ANFSelectFood.Name = "ANFSelectFood";
            this.ANFSelectFood.Size = new System.Drawing.Size(182, 18);
            this.ANFSelectFood.TabIndex = 2;
            this.ANFSelectFood.Text = "Select Food to Analyze";
            // 
            // ANFLastUsedLabel
            // 
            this.ANFLastUsedLabel.AutoSize = true;
            this.ANFLastUsedLabel.Location = new System.Drawing.Point(222, 50);
            this.ANFLastUsedLabel.Name = "ANFLastUsedLabel";
            this.ANFLastUsedLabel.Size = new System.Drawing.Size(58, 13);
            this.ANFLastUsedLabel.TabIndex = 3;
            this.ANFLastUsedLabel.Text = "Last Used:";
            // 
            // ANFLastUsedTextBox
            // 
            this.ANFLastUsedTextBox.Location = new System.Drawing.Point(298, 50);
            this.ANFLastUsedTextBox.Name = "ANFLastUsedTextBox";
            this.ANFLastUsedTextBox.ReadOnly = true;
            this.ANFLastUsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.ANFLastUsedTextBox.TabIndex = 4;
            // 
            // ANFTimesEatenLabel
            // 
            this.ANFTimesEatenLabel.AutoSize = true;
            this.ANFTimesEatenLabel.Location = new System.Drawing.Point(222, 80);
            this.ANFTimesEatenLabel.Name = "ANFTimesEatenLabel";
            this.ANFTimesEatenLabel.Size = new System.Drawing.Size(69, 13);
            this.ANFTimesEatenLabel.TabIndex = 5;
            this.ANFTimesEatenLabel.Text = "Times Eaten:";
            // 
            // ANFTimesEatenUD
            // 
            this.ANFTimesEatenUD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ANFTimesEatenUD.InterceptArrowKeys = false;
            this.ANFTimesEatenUD.Location = new System.Drawing.Point(298, 78);
            this.ANFTimesEatenUD.Name = "ANFTimesEatenUD";
            this.ANFTimesEatenUD.ReadOnly = true;
            this.ANFTimesEatenUD.Size = new System.Drawing.Size(77, 20);
            this.ANFTimesEatenUD.TabIndex = 6;
            // 
            // ANFAvgTasteRating
            // 
            this.ANFAvgTasteRating.AutoSize = true;
            this.ANFAvgTasteRating.Location = new System.Drawing.Point(222, 111);
            this.ANFAvgTasteRating.Name = "ANFAvgTasteRating";
            this.ANFAvgTasteRating.Size = new System.Drawing.Size(71, 13);
            this.ANFAvgTasteRating.TabIndex = 7;
            this.ANFAvgTasteRating.Text = "Taste Rating:";
            // 
            // ANFAvgTasteUD
            // 
            this.ANFAvgTasteUD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ANFAvgTasteUD.InterceptArrowKeys = false;
            this.ANFAvgTasteUD.Location = new System.Drawing.Point(298, 109);
            this.ANFAvgTasteUD.Name = "ANFAvgTasteUD";
            this.ANFAvgTasteUD.ReadOnly = true;
            this.ANFAvgTasteUD.Size = new System.Drawing.Size(77, 20);
            this.ANFAvgTasteUD.TabIndex = 8;
            // 
            // AnalyzeFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 375);
            this.Controls.Add(this.ANFAvgTasteUD);
            this.Controls.Add(this.ANFAvgTasteRating);
            this.Controls.Add(this.ANFTimesEatenUD);
            this.Controls.Add(this.ANFTimesEatenLabel);
            this.Controls.Add(this.ANFLastUsedTextBox);
            this.Controls.Add(this.ANFLastUsedLabel);
            this.Controls.Add(this.ANFSelectFood);
            this.Controls.Add(this.AnalysisListBox);
            this.Name = "AnalyzeFoods";
            this.Text = "AnalyzeFoods";
            ((System.ComponentModel.ISupportInitialize)(this.ANFTimesEatenUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANFAvgTasteUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnalysisListBox;
        private System.Windows.Forms.Label ANFSelectFood;
        private System.Windows.Forms.Label ANFLastUsedLabel;
        private System.Windows.Forms.TextBox ANFLastUsedTextBox;
        private System.Windows.Forms.Label ANFTimesEatenLabel;
        private System.Windows.Forms.NumericUpDown ANFTimesEatenUD;
        private System.Windows.Forms.Label ANFAvgTasteRating;
        private System.Windows.Forms.NumericUpDown ANFAvgTasteUD;
    }
}