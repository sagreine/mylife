

namespace MyLife
{
    partial class Day_to_schedule
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
            this.Save_day_button = new System.Windows.Forms.Button();
            this.Clear_day_button = new System.Windows.Forms.Button();
            this.Copy_day_button = new System.Windows.Forms.Button();
            this.Saved_days_label = new System.Windows.Forms.Label();
            this.Day_number_label = new System.Windows.Forms.Label();
            this.Days_LB = new System.Windows.Forms.ListBox();
            this.Saved_days_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save_day_button
            // 
            this.Save_day_button.Location = new System.Drawing.Point(29, 224);
            this.Save_day_button.Name = "Save_day_button";
            this.Save_day_button.Size = new System.Drawing.Size(76, 23);
            this.Save_day_button.TabIndex = 6;
            this.Save_day_button.Text = "Save Day";
            this.Save_day_button.UseVisualStyleBackColor = true;
            this.Save_day_button.Click += new System.EventHandler(this.Save_day_button_Click);
            // 
            // Clear_day_button
            // 
            this.Clear_day_button.Location = new System.Drawing.Point(29, 196);
            this.Clear_day_button.Name = "Clear_day_button";
            this.Clear_day_button.Size = new System.Drawing.Size(76, 23);
            this.Clear_day_button.TabIndex = 5;
            this.Clear_day_button.Text = "Clear Day";
            this.Clear_day_button.UseVisualStyleBackColor = true;
            this.Clear_day_button.Click += new System.EventHandler(this.Clear_day_button_Click);
            // 
            // Copy_day_button
            // 
            this.Copy_day_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_day_button.Location = new System.Drawing.Point(29, 167);
            this.Copy_day_button.Name = "Copy_day_button";
            this.Copy_day_button.Size = new System.Drawing.Size(76, 23);
            this.Copy_day_button.TabIndex = 4;
            this.Copy_day_button.Text = "Copy Day";
            this.Copy_day_button.UseVisualStyleBackColor = true;
            // 
            // Saved_days_label
            // 
            this.Saved_days_label.AutoSize = true;
            this.Saved_days_label.Location = new System.Drawing.Point(34, 8);
            this.Saved_days_label.Name = "Saved_days_label";
            this.Saved_days_label.Size = new System.Drawing.Size(65, 13);
            this.Saved_days_label.TabIndex = 3;
            this.Saved_days_label.Text = "Saved Days";
            // 
            // Day_number_label
            // 
            this.Day_number_label.AutoSize = true;
            this.Day_number_label.Location = new System.Drawing.Point(49, 50);
            this.Day_number_label.Name = "Day_number_label";
            this.Day_number_label.Size = new System.Drawing.Size(29, 13);
            this.Day_number_label.TabIndex = 2;
            this.Day_number_label.Text = "Day ";
            // 
            // Days_LB
            // 
            this.Days_LB.AllowDrop = true;
            this.Days_LB.FormattingEnabled = true;
            this.Days_LB.Location = new System.Drawing.Point(12, 66);
            this.Days_LB.Name = "Days_LB";
            this.Days_LB.Size = new System.Drawing.Size(110, 95);
            this.Days_LB.TabIndex = 1;
            this.Days_LB.DragDrop += new System.Windows.Forms.DragEventHandler(this.Days_LB_DragDrop);
            this.Days_LB.DragOver += new System.Windows.Forms.DragEventHandler(this.Days_LB_DragOver);
            // 
            // Saved_days_CB
            // 
            this.Saved_days_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Saved_days_CB.FormattingEnabled = true;
            this.Saved_days_CB.Location = new System.Drawing.Point(12, 24);
            this.Saved_days_CB.Name = "Saved_days_CB";
            this.Saved_days_CB.Size = new System.Drawing.Size(110, 21);
            this.Saved_days_CB.TabIndex = 0;
            // 
            // Day_to_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Save_day_button);
            this.Controls.Add(this.Clear_day_button);
            this.Controls.Add(this.Saved_days_CB);
            this.Controls.Add(this.Copy_day_button);
            this.Controls.Add(this.Days_LB);
            this.Controls.Add(this.Saved_days_label);
            this.Controls.Add(this.Day_number_label);
            this.Name = "Day_to_schedule";
            this.Size = new System.Drawing.Size(134, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear_day_button;
        private System.Windows.Forms.Button Copy_day_button;
        private System.Windows.Forms.Label Saved_days_label;
        private System.Windows.Forms.Label Day_number_label;
        private System.Windows.Forms.ListBox Days_LB;
        private System.Windows.Forms.ComboBox Saved_days_CB;
        private System.Windows.Forms.Button Save_day_button;
    }
}
