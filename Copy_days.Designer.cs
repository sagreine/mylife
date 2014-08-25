namespace MyLife
{
    partial class Copy_days
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
            this.Copy_exercises_DG = new System.Windows.Forms.DataGridView();
            this.Copy_exercise_DG_YN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exercise_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_to_coy_label = new System.Windows.Forms.Label();
            this.days_copy_to_label = new System.Windows.Forms.Label();
            this.Copy_to_days_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_exercises_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // weeks_panel
            // 
            this.weeks_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weeks_panel.AutoScroll = true;
            this.weeks_panel.Location = new System.Drawing.Point(44, 220);
            this.weeks_panel.Margin = new System.Windows.Forms.Padding(0);
            this.weeks_panel.Name = "weeks_panel";
            this.weeks_panel.Size = new System.Drawing.Size(965, 565);
            this.weeks_panel.TabIndex = 8;
            // 
            // Copy_exercises_DG
            // 
            this.Copy_exercises_DG.AllowUserToAddRows = false;
            this.Copy_exercises_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Copy_exercises_DG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Copy_exercises_DG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Copy_exercises_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Copy_exercises_DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Copy_exercise_DG_YN,
            this.exercise_name});
            this.Copy_exercises_DG.Location = new System.Drawing.Point(44, 22);
            this.Copy_exercises_DG.MaximumSize = new System.Drawing.Size(400, 250);
            this.Copy_exercises_DG.Name = "Copy_exercises_DG";
            this.Copy_exercises_DG.RowHeadersVisible = false;
            this.Copy_exercises_DG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Copy_exercises_DG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Copy_exercises_DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Copy_exercises_DG.Size = new System.Drawing.Size(400, 150);
            this.Copy_exercises_DG.TabIndex = 10;
            // 
            // Copy_exercise_DG_YN
            // 
            this.Copy_exercise_DG_YN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Copy_exercise_DG_YN.HeaderText = "Copy";
            this.Copy_exercise_DG_YN.Name = "Copy_exercise_DG_YN";
            this.Copy_exercise_DG_YN.Width = 37;
            // 
            // exercise_name
            // 
            this.exercise_name.HeaderText = "Exercise";
            this.exercise_name.Name = "exercise_name";
            this.exercise_name.ReadOnly = true;
            this.exercise_name.Width = 72;
            // 
            // Day_to_coy_label
            // 
            this.Day_to_coy_label.AutoSize = true;
            this.Day_to_coy_label.Location = new System.Drawing.Point(41, 6);
            this.Day_to_coy_label.Name = "Day_to_coy_label";
            this.Day_to_coy_label.Size = new System.Drawing.Size(201, 13);
            this.Day_to_coy_label.TabIndex = 11;
            this.Day_to_coy_label.Text = "Choose what exercises you\'d like to copy";
            // 
            // days_copy_to_label
            // 
            this.days_copy_to_label.AutoSize = true;
            this.days_copy_to_label.Location = new System.Drawing.Point(41, 194);
            this.days_copy_to_label.Name = "days_copy_to_label";
            this.days_copy_to_label.Size = new System.Drawing.Size(184, 13);
            this.days_copy_to_label.TabIndex = 12;
            this.days_copy_to_label.Text = "Select what days you want to copy to";
            // 
            // Copy_to_days_button
            // 
            this.Copy_to_days_button.Location = new System.Drawing.Point(405, 189);
            this.Copy_to_days_button.Name = "Copy_to_days_button";
            this.Copy_to_days_button.Size = new System.Drawing.Size(75, 23);
            this.Copy_to_days_button.TabIndex = 13;
            this.Copy_to_days_button.Text = "Copy";
            this.Copy_to_days_button.UseVisualStyleBackColor = true;
            this.Copy_to_days_button.Click += new System.EventHandler(this.Copy_to_days_button_Click);
            // 
            // Copy_days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 818);
            this.Controls.Add(this.Copy_to_days_button);
            this.Controls.Add(this.days_copy_to_label);
            this.Controls.Add(this.Day_to_coy_label);
            this.Controls.Add(this.Copy_exercises_DG);
            this.Controls.Add(this.weeks_panel);
            this.Name = "Copy_days";
            this.Text = "Copy_days";
            ((System.ComponentModel.ISupportInitialize)(this.Copy_exercises_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel weeks_panel;
        private System.Windows.Forms.DataGridView Copy_exercises_DG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Copy_exercise_DG_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn exercise_name;
        private System.Windows.Forms.Label Day_to_coy_label;
        private System.Windows.Forms.Label days_copy_to_label;
        private System.Windows.Forms.Button Copy_to_days_button;
    }
}