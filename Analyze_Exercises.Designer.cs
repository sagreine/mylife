namespace MyLife
{
    partial class Analyze_Exercises
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.ANEChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Difficulty_Label = new System.Windows.Forms.Label();
            this.ANFTimesEatenLabel = new System.Windows.Forms.Label();
            this.ANELastUsedTextBox = new System.Windows.Forms.TextBox();
            this.ANFLastUsedLabel = new System.Windows.Forms.Label();
            this.ANEAnalysisListBox = new System.Windows.Forms.ListBox();
            this.ANEMaxWeightLabel = new System.Windows.Forms.Label();
            this.ANESelectExerciseLabel = new System.Windows.Forms.Label();
            this.ANEAnalysisRange = new System.Windows.Forms.ComboBox();
            this.ANETimeframeLabel = new System.Windows.Forms.Label();
            this.ANELastXDaysUD = new System.Windows.Forms.NumericUpDown();
            this.ANELastXdaysLabel = new System.Windows.Forms.Label();
            this.ANEMinWeightLabel = new System.Windows.Forms.Label();
            this.Max_value_CB = new System.Windows.Forms.CheckBox();
            this.Eff1rm_CB = new System.Windows.Forms.CheckBox();
            this.Min_value_CB = new System.Windows.Forms.CheckBox();
            this.TimesUsedLabel = new System.Windows.Forms.Label();
            this.Difficulty_Value_Label = new System.Windows.Forms.Label();
            this.MaxWeightValueLabel = new System.Windows.Forms.Label();
            this.MinWeightValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ANEChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANELastXDaysUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ANEChart1
            // 
            this.ANEChart1.BackColor = System.Drawing.Color.LightBlue;
            this.ANEChart1.BackSecondaryColor = System.Drawing.Color.LightCoral;
            this.ANEChart1.BorderlineColor = System.Drawing.Color.LightCoral;
            this.ANEChart1.BorderlineWidth = 3;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Weight";
            chartArea1.Name = "ChartArea1";
            this.ANEChart1.ChartAreas.Add(chartArea1);
            this.ANEChart1.Location = new System.Drawing.Point(196, 164);
            this.ANEChart1.Name = "ANEChart1";
            this.ANEChart1.Size = new System.Drawing.Size(821, 414);
            this.ANEChart1.TabIndex = 0;
            this.ANEChart1.Text = "chart1";
            // 
            // Difficulty_Label
            // 
            this.Difficulty_Label.AutoSize = true;
            this.Difficulty_Label.Location = new System.Drawing.Point(193, 140);
            this.Difficulty_Label.Name = "Difficulty_Label";
            this.Difficulty_Label.Size = new System.Drawing.Size(90, 13);
            this.Difficulty_Label.TabIndex = 14;
            this.Difficulty_Label.Text = "Average Difficulty";
            // 
            // ANFTimesEatenLabel
            // 
            this.ANFTimesEatenLabel.AutoSize = true;
            this.ANFTimesEatenLabel.Location = new System.Drawing.Point(193, 109);
            this.ANFTimesEatenLabel.Name = "ANFTimesEatenLabel";
            this.ANFTimesEatenLabel.Size = new System.Drawing.Size(66, 13);
            this.ANFTimesEatenLabel.TabIndex = 12;
            this.ANFTimesEatenLabel.Text = "Times Used:";
            // 
            // ANELastUsedTextBox
            // 
            this.ANELastUsedTextBox.Location = new System.Drawing.Point(269, 79);
            this.ANELastUsedTextBox.Name = "ANELastUsedTextBox";
            this.ANELastUsedTextBox.ReadOnly = true;
            this.ANELastUsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.ANELastUsedTextBox.TabIndex = 11;
            // 
            // ANFLastUsedLabel
            // 
            this.ANFLastUsedLabel.AutoSize = true;
            this.ANFLastUsedLabel.Location = new System.Drawing.Point(193, 79);
            this.ANFLastUsedLabel.Name = "ANFLastUsedLabel";
            this.ANFLastUsedLabel.Size = new System.Drawing.Size(58, 13);
            this.ANFLastUsedLabel.TabIndex = 10;
            this.ANFLastUsedLabel.Text = "Last Used:";
            // 
            // ANEAnalysisListBox
            // 
            this.ANEAnalysisListBox.FormattingEnabled = true;
            this.ANEAnalysisListBox.Location = new System.Drawing.Point(21, 46);
            this.ANEAnalysisListBox.Name = "ANEAnalysisListBox";
            this.ANEAnalysisListBox.Size = new System.Drawing.Size(128, 316);
            this.ANEAnalysisListBox.TabIndex = 9;
            this.ANEAnalysisListBox.SelectedValueChanged += new System.EventHandler(this.ANEAnalysisListBox_SelectedValueChanged);
            // 
            // ANEMaxWeightLabel
            // 
            this.ANEMaxWeightLabel.AutoSize = true;
            this.ANEMaxWeightLabel.Location = new System.Drawing.Point(390, 109);
            this.ANEMaxWeightLabel.Name = "ANEMaxWeightLabel";
            this.ANEMaxWeightLabel.Size = new System.Drawing.Size(67, 13);
            this.ANEMaxWeightLabel.TabIndex = 16;
            this.ANEMaxWeightLabel.Text = "Max Weight:";
            // 
            // ANESelectExerciseLabel
            // 
            this.ANESelectExerciseLabel.AutoSize = true;
            this.ANESelectExerciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANESelectExerciseLabel.Location = new System.Drawing.Point(18, 25);
            this.ANESelectExerciseLabel.Name = "ANESelectExerciseLabel";
            this.ANESelectExerciseLabel.Size = new System.Drawing.Size(208, 18);
            this.ANESelectExerciseLabel.TabIndex = 18;
            this.ANESelectExerciseLabel.Text = "Select Exercise to Analyze";
            // 
            // ANEAnalysisRange
            // 
            this.ANEAnalysisRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ANEAnalysisRange.FormattingEnabled = true;
            this.ANEAnalysisRange.Items.AddRange(new object[] {
            "Week",
            "Month",
            "3 Months",
            "Year",
            "All-Time"});
            this.ANEAnalysisRange.Location = new System.Drawing.Point(269, 52);
            this.ANEAnalysisRange.Name = "ANEAnalysisRange";
            this.ANEAnalysisRange.Size = new System.Drawing.Size(100, 21);
            this.ANEAnalysisRange.TabIndex = 19;
            this.ANEAnalysisRange.SelectedValueChanged += new System.EventHandler(this.ANEAnalysisRange_SelectedValueChanged);
            // 
            // ANETimeframeLabel
            // 
            this.ANETimeframeLabel.AutoSize = true;
            this.ANETimeframeLabel.Location = new System.Drawing.Point(193, 55);
            this.ANETimeframeLabel.Name = "ANETimeframeLabel";
            this.ANETimeframeLabel.Size = new System.Drawing.Size(59, 13);
            this.ANETimeframeLabel.TabIndex = 20;
            this.ANETimeframeLabel.Text = "Timeframe:";
            // 
            // ANELastXDaysUD
            // 
            this.ANELastXDaysUD.Location = new System.Drawing.Point(393, 52);
            this.ANELastXDaysUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ANELastXDaysUD.Name = "ANELastXDaysUD";
            this.ANELastXDaysUD.Size = new System.Drawing.Size(43, 20);
            this.ANELastXDaysUD.TabIndex = 21;
            this.ANELastXDaysUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ANELastXDaysUD.ValueChanged += new System.EventHandler(this.update_chart_checkboxes);
            // 
            // ANELastXdaysLabel
            // 
            this.ANELastXdaysLabel.AutoSize = true;
            this.ANELastXdaysLabel.Location = new System.Drawing.Point(442, 55);
            this.ANELastXdaysLabel.Name = "ANELastXdaysLabel";
            this.ANELastXdaysLabel.Size = new System.Drawing.Size(31, 13);
            this.ANELastXdaysLabel.TabIndex = 22;
            this.ANELastXdaysLabel.Text = "Days";
            // 
            // ANEMinWeightLabel
            // 
            this.ANEMinWeightLabel.AutoSize = true;
            this.ANEMinWeightLabel.Location = new System.Drawing.Point(390, 141);
            this.ANEMinWeightLabel.Name = "ANEMinWeightLabel";
            this.ANEMinWeightLabel.Size = new System.Drawing.Size(64, 13);
            this.ANEMinWeightLabel.TabIndex = 23;
            this.ANEMinWeightLabel.Text = "Min Weight:";
            // 
            // Max_value_CB
            // 
            this.Max_value_CB.AutoSize = true;
            this.Max_value_CB.Location = new System.Drawing.Point(674, 136);
            this.Max_value_CB.Name = "Max_value_CB";
            this.Max_value_CB.Size = new System.Drawing.Size(83, 17);
            this.Max_value_CB.TabIndex = 25;
            this.Max_value_CB.Text = "Max Weight";
            this.Max_value_CB.UseVisualStyleBackColor = true;
            this.Max_value_CB.CheckedChanged += new System.EventHandler(this.update_chart_checkboxes);
            // 
            // Eff1rm_CB
            // 
            this.Eff1rm_CB.AutoSize = true;
            this.Eff1rm_CB.Checked = true;
            this.Eff1rm_CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Eff1rm_CB.Location = new System.Drawing.Point(574, 136);
            this.Eff1rm_CB.Name = "Eff1rm_CB";
            this.Eff1rm_CB.Size = new System.Drawing.Size(94, 17);
            this.Eff1rm_CB.TabIndex = 26;
            this.Eff1rm_CB.Text = "Effective 1RM";
            this.Eff1rm_CB.UseVisualStyleBackColor = true;
            this.Eff1rm_CB.CheckedChanged += new System.EventHandler(this.update_chart_checkboxes);
            // 
            // Min_value_CB
            // 
            this.Min_value_CB.AutoSize = true;
            this.Min_value_CB.Location = new System.Drawing.Point(763, 136);
            this.Min_value_CB.Name = "Min_value_CB";
            this.Min_value_CB.Size = new System.Drawing.Size(80, 17);
            this.Min_value_CB.TabIndex = 27;
            this.Min_value_CB.Text = "Min Weight";
            this.Min_value_CB.UseVisualStyleBackColor = true;
            this.Min_value_CB.CheckedChanged += new System.EventHandler(this.update_chart_checkboxes);
            // 
            // TimesUsedLabel
            // 
            this.TimesUsedLabel.AutoSize = true;
            this.TimesUsedLabel.Location = new System.Drawing.Point(269, 113);
            this.TimesUsedLabel.Name = "TimesUsedLabel";
            this.TimesUsedLabel.Size = new System.Drawing.Size(35, 13);
            this.TimesUsedLabel.TabIndex = 28;
            this.TimesUsedLabel.Text = "label1";
            // 
            // Difficulty_Value_Label
            // 
            this.Difficulty_Value_Label.AutoSize = true;
            this.Difficulty_Value_Label.Location = new System.Drawing.Point(287, 141);
            this.Difficulty_Value_Label.Name = "Difficulty_Value_Label";
            this.Difficulty_Value_Label.Size = new System.Drawing.Size(35, 13);
            this.Difficulty_Value_Label.TabIndex = 29;
            this.Difficulty_Value_Label.Text = "label2";
            // 
            // MaxWeightValueLabel
            // 
            this.MaxWeightValueLabel.AutoSize = true;
            this.MaxWeightValueLabel.Location = new System.Drawing.Point(463, 109);
            this.MaxWeightValueLabel.Name = "MaxWeightValueLabel";
            this.MaxWeightValueLabel.Size = new System.Drawing.Size(35, 13);
            this.MaxWeightValueLabel.TabIndex = 30;
            this.MaxWeightValueLabel.Text = "label1";
            // 
            // MinWeightValueLabel
            // 
            this.MinWeightValueLabel.AutoSize = true;
            this.MinWeightValueLabel.Location = new System.Drawing.Point(463, 140);
            this.MinWeightValueLabel.Name = "MinWeightValueLabel";
            this.MinWeightValueLabel.Size = new System.Drawing.Size(35, 13);
            this.MinWeightValueLabel.TabIndex = 31;
            this.MinWeightValueLabel.Text = "label1";
            // 
            // Analyze_Exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 590);
            this.Controls.Add(this.MinWeightValueLabel);
            this.Controls.Add(this.MaxWeightValueLabel);
            this.Controls.Add(this.Difficulty_Value_Label);
            this.Controls.Add(this.TimesUsedLabel);
            this.Controls.Add(this.Min_value_CB);
            this.Controls.Add(this.Eff1rm_CB);
            this.Controls.Add(this.Max_value_CB);
            this.Controls.Add(this.ANEMinWeightLabel);
            this.Controls.Add(this.ANELastXdaysLabel);
            this.Controls.Add(this.ANELastXDaysUD);
            this.Controls.Add(this.ANETimeframeLabel);
            this.Controls.Add(this.ANEAnalysisRange);
            this.Controls.Add(this.ANESelectExerciseLabel);
            this.Controls.Add(this.ANEMaxWeightLabel);
            this.Controls.Add(this.Difficulty_Label);
            this.Controls.Add(this.ANFTimesEatenLabel);
            this.Controls.Add(this.ANELastUsedTextBox);
            this.Controls.Add(this.ANFLastUsedLabel);
            this.Controls.Add(this.ANEAnalysisListBox);
            this.Controls.Add(this.ANEChart1);
            this.Name = "Analyze_Exercises";
            this.Text = "AnalyzeExercises";
            ((System.ComponentModel.ISupportInitialize)(this.ANEChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANELastXDaysUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ANEChart1;
        private System.Windows.Forms.Label Difficulty_Label;
        private System.Windows.Forms.Label ANFTimesEatenLabel;
        private System.Windows.Forms.TextBox ANELastUsedTextBox;
        private System.Windows.Forms.Label ANFLastUsedLabel;
        private System.Windows.Forms.ListBox ANEAnalysisListBox;
        private System.Windows.Forms.Label ANEMaxWeightLabel;
        private System.Windows.Forms.Label ANESelectExerciseLabel;
        private System.Windows.Forms.ComboBox ANEAnalysisRange;
        private System.Windows.Forms.Label ANETimeframeLabel;
        private System.Windows.Forms.NumericUpDown ANELastXDaysUD;
        private System.Windows.Forms.Label ANELastXdaysLabel;
        private System.Windows.Forms.Label ANEMinWeightLabel;
        private System.Windows.Forms.CheckBox Max_value_CB;
        private System.Windows.Forms.CheckBox Eff1rm_CB;
        private System.Windows.Forms.CheckBox Min_value_CB;
        private System.Windows.Forms.Label TimesUsedLabel;
        private System.Windows.Forms.Label Difficulty_Value_Label;
        private System.Windows.Forms.Label MaxWeightValueLabel;
        private System.Windows.Forms.Label MinWeightValueLabel;
    }
}