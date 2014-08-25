using ConsoleApplication1.WindowsFormsApplication3;

namespace MyLife
{
    partial class Add_Food
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
            this.AddFoodHeaderLabel = new System.Windows.Forms.Label();
            this.AddFoodNameLabel = new System.Windows.Forms.Label();
            this.AddFoodServingSizeLabel = new System.Windows.Forms.Label();
            this.AddFoodCaloriesLabel = new System.Windows.Forms.Label();
            this.AddFoodCarbohydratesLabel = new System.Windows.Forms.Label();
            this.AddFoodFatLabel = new System.Windows.Forms.Label();
            this.AddFoodProteinLabel = new System.Windows.Forms.Label();
            this.AddFoodCommentsLabel = new System.Windows.Forms.Label();
            this.AddFoodNameTextBox = new System.Windows.Forms.TextBox();
            this.AddFoodSaveButton = new System.Windows.Forms.Button();
            this.AddFoodRecommendLabel = new System.Windows.Forms.Label();
            this.AddFoodRecommendRBYes = new System.Windows.Forms.RadioButton();
            this.AddFoodRecommendRBNo = new System.Windows.Forms.RadioButton();
            this.AddFoodSaveAndContinueButton = new System.Windows.Forms.Button();
            this.AddFoodCaloriesUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddFoodCarbohydratesUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddFoodFatUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddFoodProteinUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddFoodCommentsTextBox = new System.Windows.Forms.TextBox();
            this.AddFoodServingSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.AFGoogleIt = new System.Windows.Forms.Button();
            this.AFCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodCaloriesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodCarbohydratesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodFatUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodProteinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodServingSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFoodHeaderLabel
            // 
            this.AddFoodHeaderLabel.AutoSize = true;
            this.AddFoodHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodHeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddFoodHeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.AddFoodHeaderLabel.Name = "AddFoodHeaderLabel";
            this.AddFoodHeaderLabel.Size = new System.Drawing.Size(133, 25);
            this.AddFoodHeaderLabel.TabIndex = 0;
            this.AddFoodHeaderLabel.Text = "Add a Food";
            // 
            // AddFoodNameLabel
            // 
            this.AddFoodNameLabel.AutoSize = true;
            this.AddFoodNameLabel.Location = new System.Drawing.Point(316, 52);
            this.AddFoodNameLabel.Name = "AddFoodNameLabel";
            this.AddFoodNameLabel.Size = new System.Drawing.Size(65, 13);
            this.AddFoodNameLabel.TabIndex = 1;
            this.AddFoodNameLabel.Text = "Food Name:";
            // 
            // AddFoodServingSizeLabel
            // 
            this.AddFoodServingSizeLabel.AutoSize = true;
            this.AddFoodServingSizeLabel.Location = new System.Drawing.Point(316, 80);
            this.AddFoodServingSizeLabel.Name = "AddFoodServingSizeLabel";
            this.AddFoodServingSizeLabel.Size = new System.Drawing.Size(84, 13);
            this.AddFoodServingSizeLabel.TabIndex = 2;
            this.AddFoodServingSizeLabel.Text = "Serving Size (g):";
            // 
            // AddFoodCaloriesLabel
            // 
            this.AddFoodCaloriesLabel.AutoSize = true;
            this.AddFoodCaloriesLabel.Location = new System.Drawing.Point(316, 112);
            this.AddFoodCaloriesLabel.Name = "AddFoodCaloriesLabel";
            this.AddFoodCaloriesLabel.Size = new System.Drawing.Size(47, 13);
            this.AddFoodCaloriesLabel.TabIndex = 3;
            this.AddFoodCaloriesLabel.Text = "Calories:";
            // 
            // AddFoodCarbohydratesLabel
            // 
            this.AddFoodCarbohydratesLabel.AutoSize = true;
            this.AddFoodCarbohydratesLabel.Location = new System.Drawing.Point(316, 140);
            this.AddFoodCarbohydratesLabel.Name = "AddFoodCarbohydratesLabel";
            this.AddFoodCarbohydratesLabel.Size = new System.Drawing.Size(78, 13);
            this.AddFoodCarbohydratesLabel.TabIndex = 4;
            this.AddFoodCarbohydratesLabel.Text = "Carbohydrates:";
            // 
            // AddFoodFatLabel
            // 
            this.AddFoodFatLabel.AutoSize = true;
            this.AddFoodFatLabel.Location = new System.Drawing.Point(316, 170);
            this.AddFoodFatLabel.Name = "AddFoodFatLabel";
            this.AddFoodFatLabel.Size = new System.Drawing.Size(25, 13);
            this.AddFoodFatLabel.TabIndex = 5;
            this.AddFoodFatLabel.Text = "Fat:";
            // 
            // AddFoodProteinLabel
            // 
            this.AddFoodProteinLabel.AutoSize = true;
            this.AddFoodProteinLabel.Location = new System.Drawing.Point(316, 198);
            this.AddFoodProteinLabel.Name = "AddFoodProteinLabel";
            this.AddFoodProteinLabel.Size = new System.Drawing.Size(43, 13);
            this.AddFoodProteinLabel.TabIndex = 6;
            this.AddFoodProteinLabel.Text = "Protein:";
            // 
            // AddFoodCommentsLabel
            // 
            this.AddFoodCommentsLabel.AutoSize = true;
            this.AddFoodCommentsLabel.Location = new System.Drawing.Point(316, 228);
            this.AddFoodCommentsLabel.Name = "AddFoodCommentsLabel";
            this.AddFoodCommentsLabel.Size = new System.Drawing.Size(56, 13);
            this.AddFoodCommentsLabel.TabIndex = 7;
            this.AddFoodCommentsLabel.Text = "Comments";
            // 
            // AddFoodNameTextBox
            // 
            this.AddFoodNameTextBox.Location = new System.Drawing.Point(429, 52);
            this.AddFoodNameTextBox.Name = "AddFoodNameTextBox";
            this.AddFoodNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddFoodNameTextBox.TabIndex = 8;
            // 
            // AddFoodSaveButton
            // 
            this.AddFoodSaveButton.Location = new System.Drawing.Point(319, 323);
            this.AddFoodSaveButton.Name = "AddFoodSaveButton";
            this.AddFoodSaveButton.Size = new System.Drawing.Size(97, 47);
            this.AddFoodSaveButton.TabIndex = 17;
            this.AddFoodSaveButton.Text = "Save Food";
            this.AddFoodSaveButton.UseVisualStyleBackColor = true;
            this.AddFoodSaveButton.Click += new System.EventHandler(this.AddFoodSaveButton_Click);
            // 
            // AddFoodRecommendLabel
            // 
            this.AddFoodRecommendLabel.AutoSize = true;
            this.AddFoodRecommendLabel.Location = new System.Drawing.Point(319, 276);
            this.AddFoodRecommendLabel.Name = "AddFoodRecommendLabel";
            this.AddFoodRecommendLabel.Size = new System.Drawing.Size(67, 13);
            this.AddFoodRecommendLabel.TabIndex = 16;
            this.AddFoodRecommendLabel.Text = "Recommend";
            // 
            // AddFoodRecommendRBYes
            // 
            this.AddFoodRecommendRBYes.AutoSize = true;
            this.AddFoodRecommendRBYes.Location = new System.Drawing.Point(429, 276);
            this.AddFoodRecommendRBYes.Name = "AddFoodRecommendRBYes";
            this.AddFoodRecommendRBYes.Size = new System.Drawing.Size(43, 17);
            this.AddFoodRecommendRBYes.TabIndex = 15;
            this.AddFoodRecommendRBYes.TabStop = true;
            this.AddFoodRecommendRBYes.Text = "Yes";
            this.AddFoodRecommendRBYes.UseVisualStyleBackColor = true;
            // 
            // AddFoodRecommendRBNo
            // 
            this.AddFoodRecommendRBNo.AutoSize = true;
            this.AddFoodRecommendRBNo.Location = new System.Drawing.Point(486, 276);
            this.AddFoodRecommendRBNo.Name = "AddFoodRecommendRBNo";
            this.AddFoodRecommendRBNo.Size = new System.Drawing.Size(39, 17);
            this.AddFoodRecommendRBNo.TabIndex = 16;
            this.AddFoodRecommendRBNo.TabStop = true;
            this.AddFoodRecommendRBNo.Text = "No";
            this.AddFoodRecommendRBNo.UseVisualStyleBackColor = true;
            // 
            // AddFoodSaveAndContinueButton
            // 
            this.AddFoodSaveAndContinueButton.Location = new System.Drawing.Point(429, 323);
            this.AddFoodSaveAndContinueButton.Name = "AddFoodSaveAndContinueButton";
            this.AddFoodSaveAndContinueButton.Size = new System.Drawing.Size(97, 47);
            this.AddFoodSaveAndContinueButton.TabIndex = 18;
            this.AddFoodSaveAndContinueButton.Text = "Save Food and Add Another";
            this.AddFoodSaveAndContinueButton.UseVisualStyleBackColor = true;
            this.AddFoodSaveAndContinueButton.Click += new System.EventHandler(this.AddFoodSaveAndContinueButton_Click);
            // 
            // AddFoodCaloriesUpDown
            // 
            this.AddFoodCaloriesUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AddFoodCaloriesUpDown.Location = new System.Drawing.Point(429, 110);
            this.AddFoodCaloriesUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddFoodCaloriesUpDown.Name = "AddFoodCaloriesUpDown";
            this.AddFoodCaloriesUpDown.Size = new System.Drawing.Size(64, 20);
            this.AddFoodCaloriesUpDown.TabIndex = 10;
            // 
            // AddFoodCarbohydratesUpDown
            // 
            this.AddFoodCarbohydratesUpDown.Location = new System.Drawing.Point(429, 138);
            this.AddFoodCarbohydratesUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddFoodCarbohydratesUpDown.Name = "AddFoodCarbohydratesUpDown";
            this.AddFoodCarbohydratesUpDown.Size = new System.Drawing.Size(64, 20);
            this.AddFoodCarbohydratesUpDown.TabIndex = 11;
            // 
            // AddFoodFatUpDown
            // 
            this.AddFoodFatUpDown.Location = new System.Drawing.Point(429, 168);
            this.AddFoodFatUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddFoodFatUpDown.Name = "AddFoodFatUpDown";
            this.AddFoodFatUpDown.Size = new System.Drawing.Size(64, 20);
            this.AddFoodFatUpDown.TabIndex = 12;
            // 
            // AddFoodProteinUpDown
            // 
            this.AddFoodProteinUpDown.Location = new System.Drawing.Point(429, 196);
            this.AddFoodProteinUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddFoodProteinUpDown.Name = "AddFoodProteinUpDown";
            this.AddFoodProteinUpDown.Size = new System.Drawing.Size(64, 20);
            this.AddFoodProteinUpDown.TabIndex = 13;
            // 
            // AddFoodCommentsTextBox
            // 
            this.AddFoodCommentsTextBox.Location = new System.Drawing.Point(429, 225);
            this.AddFoodCommentsTextBox.Name = "AddFoodCommentsTextBox";
            this.AddFoodCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddFoodCommentsTextBox.TabIndex = 14;
            // 
            // AddFoodServingSizeUpDown
            // 
            this.AddFoodServingSizeUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AddFoodServingSizeUpDown.Location = new System.Drawing.Point(429, 78);
            this.AddFoodServingSizeUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.AddFoodServingSizeUpDown.Name = "AddFoodServingSizeUpDown";
            this.AddFoodServingSizeUpDown.Size = new System.Drawing.Size(64, 20);
            this.AddFoodServingSizeUpDown.TabIndex = 9;
            // 
            // AFGoogleIt
            // 
            this.AFGoogleIt.Location = new System.Drawing.Point(559, 52);
            this.AFGoogleIt.Name = "AFGoogleIt";
            this.AFGoogleIt.Size = new System.Drawing.Size(75, 23);
            this.AFGoogleIt.TabIndex = 41;
            this.AFGoogleIt.Text = "Google It";
            this.AFGoogleIt.UseVisualStyleBackColor = true;
            this.AFGoogleIt.Click += new System.EventHandler(this.AFGoogleIt_Click);
            // 
            // AFCancelButton
            // 
            this.AFCancelButton.Location = new System.Drawing.Point(537, 323);
            this.AFCancelButton.Name = "AFCancelButton";
            this.AFCancelButton.Size = new System.Drawing.Size(97, 47);
            this.AFCancelButton.TabIndex = 43;
            this.AFCancelButton.Text = "Cancel";
            this.AFCancelButton.UseVisualStyleBackColor = true;
            this.AFCancelButton.Click += new System.EventHandler(this.AFCancelButton_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 483);
            this.Controls.Add(this.AFCancelButton);
            this.Controls.Add(this.AFGoogleIt);
            this.Controls.Add(this.AddFoodServingSizeUpDown);
            this.Controls.Add(this.AddFoodCommentsTextBox);
            this.Controls.Add(this.AddFoodProteinUpDown);
            this.Controls.Add(this.AddFoodFatUpDown);
            this.Controls.Add(this.AddFoodCarbohydratesUpDown);
            this.Controls.Add(this.AddFoodCaloriesUpDown);
            this.Controls.Add(this.AddFoodSaveAndContinueButton);
            this.Controls.Add(this.AddFoodRecommendRBNo);
            this.Controls.Add(this.AddFoodRecommendRBYes);
            this.Controls.Add(this.AddFoodRecommendLabel);
            this.Controls.Add(this.AddFoodSaveButton);
            this.Controls.Add(this.AddFoodNameTextBox);
            this.Controls.Add(this.AddFoodCommentsLabel);
            this.Controls.Add(this.AddFoodProteinLabel);
            this.Controls.Add(this.AddFoodFatLabel);
            this.Controls.Add(this.AddFoodCarbohydratesLabel);
            this.Controls.Add(this.AddFoodCaloriesLabel);
            this.Controls.Add(this.AddFoodServingSizeLabel);
            this.Controls.Add(this.AddFoodNameLabel);
            this.Controls.Add(this.AddFoodHeaderLabel);
            this.Name = "AddFood";
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodCaloriesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodCarbohydratesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodFatUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodProteinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodServingSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddFoodHeaderLabel;
        private System.Windows.Forms.Label AddFoodNameLabel;
        private System.Windows.Forms.Label AddFoodServingSizeLabel;
        private System.Windows.Forms.Label AddFoodCaloriesLabel;
        private System.Windows.Forms.Label AddFoodCarbohydratesLabel;
        private System.Windows.Forms.Label AddFoodFatLabel;
        private System.Windows.Forms.Label AddFoodProteinLabel;
        private System.Windows.Forms.Label AddFoodCommentsLabel;
        private System.Windows.Forms.TextBox AddFoodNameTextBox;
        private System.Windows.Forms.Button AddFoodSaveButton;
        private System.Windows.Forms.Label AddFoodRecommendLabel;
        private System.Windows.Forms.RadioButton AddFoodRecommendRBYes;
        private System.Windows.Forms.RadioButton AddFoodRecommendRBNo;
        private System.Windows.Forms.Button AddFoodSaveAndContinueButton;
        private System.Windows.Forms.NumericUpDown AddFoodCaloriesUpDown;
        private System.Windows.Forms.NumericUpDown AddFoodCarbohydratesUpDown;
        private System.Windows.Forms.NumericUpDown AddFoodFatUpDown;
        private System.Windows.Forms.NumericUpDown AddFoodProteinUpDown;
        private System.Windows.Forms.TextBox AddFoodCommentsTextBox;
        private System.Windows.Forms.NumericUpDown AddFoodServingSizeUpDown;
        private System.Windows.Forms.Button AFGoogleIt;
        private System.Windows.Forms.Button AFCancelButton;
    }
}