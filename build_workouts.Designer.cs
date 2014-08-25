namespace MyLife
{
    partial class build_workouts
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
            this.weeks_panel = new System.Windows.Forms.Panel();
            this.Exercises_listbox = new System.Windows.Forms.ListBox();
            this.Workout_Scheduler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weeks_panel
            // 
            this.weeks_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weeks_panel.AutoScroll = true;
            this.weeks_panel.Location = new System.Drawing.Point(168, 76);
            this.weeks_panel.Margin = new System.Windows.Forms.Padding(0);
            this.weeks_panel.Name = "weeks_panel";
            this.weeks_panel.Size = new System.Drawing.Size(958, 725);
            this.weeks_panel.TabIndex = 7;
            // 
            // Exercises_listbox
            // 
            this.Exercises_listbox.FormattingEnabled = true;
            this.Exercises_listbox.Location = new System.Drawing.Point(9, 76);
            this.Exercises_listbox.Name = "Exercises_listbox";
            this.Exercises_listbox.Size = new System.Drawing.Size(118, 472);
            this.Exercises_listbox.TabIndex = 6;
            this.Exercises_listbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exercises_listbox_MouseDown);
            // 
            // Workout_Scheduler
            // 
            this.Workout_Scheduler.Location = new System.Drawing.Point(347, 31);
            this.Workout_Scheduler.Name = "Workout_Scheduler";
            this.Workout_Scheduler.Size = new System.Drawing.Size(181, 42);
            this.Workout_Scheduler.TabIndex = 8;
            this.Workout_Scheduler.Text = "Schedule This Workout";
            this.Workout_Scheduler.UseVisualStyleBackColor = true;
            this.Workout_Scheduler.Click += new System.EventHandler(this.Workout_Scheduler_Click);
            // 
            // build_workouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 734);
            this.Controls.Add(this.Workout_Scheduler);
            this.Controls.Add(this.Exercises_listbox);
            this.Controls.Add(this.weeks_panel);
            this.Name = "build_workouts";
            this.Text = "Build Workouts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weeks_panel;
        private System.Windows.Forms.ListBox Exercises_listbox;
        private System.Windows.Forms.Button Workout_Scheduler;
    }
}