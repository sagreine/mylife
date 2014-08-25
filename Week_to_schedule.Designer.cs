using Constants;

namespace MyLife
{
    partial class Week_to_schedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Week_number_label = new System.Windows.Forms.Label();
            this.Copy_week_button = new System.Windows.Forms.Button();
            this.Saved_weeks_label = new System.Windows.Forms.Label();
            this.Saved_weeks_CB = new System.Windows.Forms.ComboBox();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.Save_week_button = new System.Windows.Forms.Button();
            this.Header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Week_number_label
            // 
            this.Week_number_label.AutoSize = true;
            this.Week_number_label.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Week_number_label.Location = new System.Drawing.Point(3, 3);
            this.Week_number_label.Name = "Week_number_label";
            this.Week_number_label.Size = new System.Drawing.Size(39, 13);
            this.Week_number_label.TabIndex = 46;
            this.Week_number_label.Text = "Week ";
            // 
            // Copy_week_button
            // 
            this.Copy_week_button.Location = new System.Drawing.Point(258, 23);
            this.Copy_week_button.Name = "Copy_week_button";
            this.Copy_week_button.Size = new System.Drawing.Size(75, 21);
            this.Copy_week_button.TabIndex = 45;
            this.Copy_week_button.Text = "Copy Week";
            this.Copy_week_button.UseVisualStyleBackColor = true;
            // 
            // Saved_weeks_label
            // 
            this.Saved_weeks_label.AutoSize = true;
            this.Saved_weeks_label.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Saved_weeks_label.Location = new System.Drawing.Point(50, 26);
            this.Saved_weeks_label.Name = "Saved_weeks_label";
            this.Saved_weeks_label.Size = new System.Drawing.Size(75, 13);
            this.Saved_weeks_label.TabIndex = 43;
            this.Saved_weeks_label.Text = "Saved Weeks";
            // 
            // Saved_weeks_CB
            // 
            this.Saved_weeks_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Saved_weeks_CB.FormattingEnabled = true;
            this.Saved_weeks_CB.Location = new System.Drawing.Point(131, 23);
            this.Saved_weeks_CB.Name = "Saved_weeks_CB";
            this.Saved_weeks_CB.Size = new System.Drawing.Size(121, 21);
            this.Saved_weeks_CB.TabIndex = 44;
            this.Saved_weeks_CB.SelectedIndexChanged += new System.EventHandler(this.Saved_weeks_CB_SelectedIndexChanged);
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = Constants.Constants_class.week_header_background_color;
            this.Header_panel.Controls.Add(this.Save_week_button);
            this.Header_panel.Controls.Add(this.Copy_week_button);
            this.Header_panel.Controls.Add(this.Week_number_label);
            this.Header_panel.Controls.Add(this.Saved_weeks_CB);
            this.Header_panel.Controls.Add(this.Saved_weeks_label);
            this.Header_panel.Location = new System.Drawing.Point(0, 0);
            this.Header_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(945, 47);
            this.Header_panel.TabIndex = 47;
            // 
            // Save_week_button
            // 
            this.Save_week_button.Location = new System.Drawing.Point(339, 23);
            this.Save_week_button.Name = "Save_week_button";
            this.Save_week_button.Size = new System.Drawing.Size(75, 21);
            this.Save_week_button.TabIndex = 47;
            this.Save_week_button.Text = "Save Week";
            this.Save_week_button.UseVisualStyleBackColor = true;
            // 
            // Week_to_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Constants.Constants_class.week_days_background_color;
            this.Controls.Add(this.Header_panel);
            this.Name = "Week_to_schedule";
            this.Size = new System.Drawing.Size(945, 299);
            this.Header_panel.ResumeLayout(false);
            this.Header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Week_number_label;
        private System.Windows.Forms.Button Copy_week_button;
        private System.Windows.Forms.Label Saved_weeks_label;
        private System.Windows.Forms.ComboBox Saved_weeks_CB;
        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Button Save_week_button;
    }
}
