namespace MyLife
{
    partial class Workout_Scheduler
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
            this.Schedule_button = new System.Windows.Forms.Button();
            this.Saved_Workouts_cb = new System.Windows.Forms.ComboBox();
            this.Workout_select_label = new System.Windows.Forms.Label();
            this.Starting_day_label = new System.Windows.Forms.Label();
            this.Number_days_in_workout_lbl = new System.Windows.Forms.Label();
            this.Workout_days_mc = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Schedule_button
            // 
            this.Schedule_button.Location = new System.Drawing.Point(199, 351);
            this.Schedule_button.Name = "Schedule_button";
            this.Schedule_button.Size = new System.Drawing.Size(134, 23);
            this.Schedule_button.TabIndex = 0;
            this.Schedule_button.Text = "Schedule";
            this.Schedule_button.UseVisualStyleBackColor = true;
            this.Schedule_button.Click += new System.EventHandler(this.Schedule_button_Click);
            // 
            // Saved_Workouts_cb
            // 
            this.Saved_Workouts_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Saved_Workouts_cb.FormattingEnabled = true;
            this.Saved_Workouts_cb.Location = new System.Drawing.Point(12, 28);
            this.Saved_Workouts_cb.Name = "Saved_Workouts_cb";
            this.Saved_Workouts_cb.Size = new System.Drawing.Size(121, 21);
            this.Saved_Workouts_cb.TabIndex = 6;
            // 
            // Workout_select_label
            // 
            this.Workout_select_label.AutoSize = true;
            this.Workout_select_label.Location = new System.Drawing.Point(12, 9);
            this.Workout_select_label.Name = "Workout_select_label";
            this.Workout_select_label.Size = new System.Drawing.Size(48, 13);
            this.Workout_select_label.TabIndex = 7;
            this.Workout_select_label.Text = "Workout";
            // 
            // Starting_day_label
            // 
            this.Starting_day_label.AutoSize = true;
            this.Starting_day_label.Location = new System.Drawing.Point(196, 9);
            this.Starting_day_label.Name = "Starting_day_label";
            this.Starting_day_label.Size = new System.Drawing.Size(129, 13);
            this.Starting_day_label.TabIndex = 9;
            this.Starting_day_label.Text = "Choose Days for Workout";
            // 
            // Number_days_in_workout_lbl
            // 
            this.Number_days_in_workout_lbl.AutoSize = true;
            this.Number_days_in_workout_lbl.Location = new System.Drawing.Point(9, 63);
            this.Number_days_in_workout_lbl.Name = "Number_days_in_workout_lbl";
            this.Number_days_in_workout_lbl.Size = new System.Drawing.Size(141, 13);
            this.Number_days_in_workout_lbl.TabIndex = 10;
            this.Number_days_in_workout_lbl.Text = "Number of Days in Workout;";
            // 
            // Workout_days_mc
            // 
            this.Workout_days_mc.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Workout_days_mc.Location = new System.Drawing.Point(199, 28);
            this.Workout_days_mc.MaxSelectionCount = 1;
            this.Workout_days_mc.Name = "Workout_days_mc";
            this.Workout_days_mc.TabIndex = 11;
            this.Workout_days_mc.TitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Workout_days_mc.TitleForeColor = System.Drawing.SystemColors.Control;
            this.Workout_days_mc.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Workout_days_mc_DateSelected);
            // 
            // Workout_Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(686, 400);
            this.Controls.Add(this.Workout_days_mc);
            this.Controls.Add(this.Number_days_in_workout_lbl);
            this.Controls.Add(this.Starting_day_label);
            this.Controls.Add(this.Workout_select_label);
            this.Controls.Add(this.Saved_Workouts_cb);
            this.Controls.Add(this.Schedule_button);
            this.Name = "Workout_Scheduler";
            this.Text = "Workout_Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Schedule_button;
        private System.Windows.Forms.ComboBox Saved_Workouts_cb;
        private System.Windows.Forms.Label Workout_select_label;
        private System.Windows.Forms.Label Starting_day_label;
        private System.Windows.Forms.Label Number_days_in_workout_lbl;
        private System.Windows.Forms.MonthCalendar Workout_days_mc;
    }
}