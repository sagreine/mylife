namespace MyLife
{
    partial class Workout_info
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
            this.WorkoutNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkoutNameLabel = new System.Windows.Forms.Label();
            this.Num_weeks_label = new System.Windows.Forms.Label();
            this.Number_weeks_NUD = new System.Windows.Forms.NumericUpDown();
            this.Workout_focus_label = new System.Windows.Forms.Label();
            this.Workout_focus_CB = new System.Windows.Forms.ComboBox();
            this.Build_workout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Number_weeks_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkoutNameTextBox
            // 
            this.WorkoutNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.WorkoutNameTextBox.Name = "WorkoutNameTextBox";
            this.WorkoutNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.WorkoutNameTextBox.TabIndex = 33;
            // 
            // WorkoutNameLabel
            // 
            this.WorkoutNameLabel.AutoSize = true;
            this.WorkoutNameLabel.Location = new System.Drawing.Point(12, 9);
            this.WorkoutNameLabel.Name = "WorkoutNameLabel";
            this.WorkoutNameLabel.Size = new System.Drawing.Size(76, 13);
            this.WorkoutNameLabel.TabIndex = 32;
            this.WorkoutNameLabel.Text = "WorkoutName";
            // 
            // Num_weeks_label
            // 
            this.Num_weeks_label.AutoSize = true;
            this.Num_weeks_label.Location = new System.Drawing.Point(9, 90);
            this.Num_weeks_label.Name = "Num_weeks_label";
            this.Num_weeks_label.Size = new System.Drawing.Size(93, 13);
            this.Num_weeks_label.TabIndex = 34;
            this.Num_weeks_label.Text = "Number of Weeks";
            // 
            // Number_weeks_NUD
            // 
            this.Number_weeks_NUD.Location = new System.Drawing.Point(12, 106);
            this.Number_weeks_NUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Number_weeks_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number_weeks_NUD.Name = "Number_weeks_NUD";
            this.Number_weeks_NUD.Size = new System.Drawing.Size(38, 20);
            this.Number_weeks_NUD.TabIndex = 35;
            this.Number_weeks_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Workout_focus_label
            // 
            this.Workout_focus_label.AutoSize = true;
            this.Workout_focus_label.Location = new System.Drawing.Point(9, 140);
            this.Workout_focus_label.Name = "Workout_focus_label";
            this.Workout_focus_label.Size = new System.Drawing.Size(80, 13);
            this.Workout_focus_label.TabIndex = 36;
            this.Workout_focus_label.Text = "Workout Focus";
            // 
            // Workout_focus_CB
            // 
            this.Workout_focus_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Workout_focus_CB.FormattingEnabled = true;
            this.Workout_focus_CB.Items.AddRange(new object[] {
            "Strength",
            "Endurance",
            "Fat Loss"});
            this.Workout_focus_CB.Location = new System.Drawing.Point(12, 156);
            this.Workout_focus_CB.Name = "Workout_focus_CB";
            this.Workout_focus_CB.Size = new System.Drawing.Size(121, 21);
            this.Workout_focus_CB.TabIndex = 37;
            // 
            // Build_workout_button
            // 
            this.Build_workout_button.Location = new System.Drawing.Point(12, 289);
            this.Build_workout_button.Name = "Build_workout_button";
            this.Build_workout_button.Size = new System.Drawing.Size(121, 23);
            this.Build_workout_button.TabIndex = 38;
            this.Build_workout_button.Text = "Schedule Exercises";
            this.Build_workout_button.UseVisualStyleBackColor = true;
            this.Build_workout_button.Click += new System.EventHandler(this.Build_workout_button_Click);
            // 
            // Workout_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 426);
            this.Controls.Add(this.Build_workout_button);
            this.Controls.Add(this.Workout_focus_CB);
            this.Controls.Add(this.Workout_focus_label);
            this.Controls.Add(this.Number_weeks_NUD);
            this.Controls.Add(this.Num_weeks_label);
            this.Controls.Add(this.WorkoutNameTextBox);
            this.Controls.Add(this.WorkoutNameLabel);
            this.Name = "Workout_info";
            this.Text = "Workout_info";
            ((System.ComponentModel.ISupportInitialize)(this.Number_weeks_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WorkoutNameTextBox;
        private System.Windows.Forms.Label WorkoutNameLabel;
        private System.Windows.Forms.Label Num_weeks_label;
        private System.Windows.Forms.NumericUpDown Number_weeks_NUD;
        private System.Windows.Forms.Label Workout_focus_label;
        private System.Windows.Forms.ComboBox Workout_focus_CB;
        private System.Windows.Forms.Button Build_workout_button;
    }
}