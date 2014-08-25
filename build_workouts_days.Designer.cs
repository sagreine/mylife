using System.Collections.Generic;
using System.Data;



namespace MyLife
{
    partial class Build_workouts_days
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
        
        
       
        /////

        /////


   
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExerciseDetailsPanel = new MyLife.LogExerciseDetails();
            this.WRKAnalysisListBox = new System.Windows.Forms.ListBox();
            this.WRKSelectExerciseLabel = new System.Windows.Forms.Label();
            this.Day1ListBox = new System.Windows.Forms.ListBox();
            this.DayOfTheWeekComboBox = new System.Windows.Forms.ComboBox();
            this.Day1NameTextBox = new System.Windows.Forms.TextBox();
            this.Day2NameTextBox = new System.Windows.Forms.TextBox();
            this.Day2ListBox = new System.Windows.Forms.ListBox();
            this.Day3NameTextBox = new System.Windows.Forms.TextBox();
            this.Day3ListBox = new System.Windows.Forms.ListBox();
            this.Day4NameTextBox = new System.Windows.Forms.TextBox();
            this.Day4ListBox = new System.Windows.Forms.ListBox();
            this.Day5NameTextBox = new System.Windows.Forms.TextBox();
            this.Day5ListBox = new System.Windows.Forms.ListBox();
            this.DayOfWeekLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.DetailsCompleteCB = new System.Windows.Forms.CheckBox();
            this.DetailsForLabel = new System.Windows.Forms.Label();
            this.Exercise_Getting_Details_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SetCounterLabel = new System.Windows.Forms.Label();
            this.RepsLabel = new System.Windows.Forms.Label();
            this.Rest4UD = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.Rest3UD = new System.Windows.Forms.NumericUpDown();
            this.RestLabel = new System.Windows.Forms.Label();
            this.Rest2UD = new System.Windows.Forms.NumericUpDown();
            this.Set1Label = new System.Windows.Forms.Label();
            this.Rest1UD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Weight5UD = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Weight4UD = new System.Windows.Forms.NumericUpDown();
            this.Reps1UD = new System.Windows.Forms.NumericUpDown();
            this.Weight3UD = new System.Windows.Forms.NumericUpDown();
            this.Reps2UD = new System.Windows.Forms.NumericUpDown();
            this.Weight2UD = new System.Windows.Forms.NumericUpDown();
            this.Reps3UD = new System.Windows.Forms.NumericUpDown();
            this.Weight1UD = new System.Windows.Forms.NumericUpDown();
            this.Reps4UD = new System.Windows.Forms.NumericUpDown();
            this.Reps5UD = new System.Windows.Forms.NumericUpDown();
            this.SetsUD = new System.Windows.Forms.NumericUpDown();
            this.SetsLabel = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.DetailsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rest4UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest3UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest2UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest1UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight5UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight4UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps1UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight3UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps2UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps3UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight1UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps4UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps5UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseDetailsPanel
            // 
            this.ExerciseDetailsPanel.AutoSize = true;
            this.ExerciseDetailsPanel.current_exercise = "";
            this.ExerciseDetailsPanel.Location = new System.Drawing.Point(510, 331);
            this.ExerciseDetailsPanel.Name = "ExerciseDetailsPanel";
            this.ExerciseDetailsPanel.setsUD = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExerciseDetailsPanel.Size = new System.Drawing.Size(266, 305);
            this.ExerciseDetailsPanel.TabIndex = 81;
            // 
            // WRKAnalysisListBox
            // 
            this.WRKAnalysisListBox.FormattingEnabled = true;
            this.WRKAnalysisListBox.Location = new System.Drawing.Point(12, 135);
            this.WRKAnalysisListBox.Name = "WRKAnalysisListBox";
            this.WRKAnalysisListBox.Size = new System.Drawing.Size(128, 316);
            this.WRKAnalysisListBox.TabIndex = 10;
            this.WRKAnalysisListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WRKAnalysisListBox_MouseDown);
            // 
            // WRKSelectExerciseLabel
            // 
            this.WRKSelectExerciseLabel.AutoSize = true;
            this.WRKSelectExerciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRKSelectExerciseLabel.Location = new System.Drawing.Point(9, 105);
            this.WRKSelectExerciseLabel.Name = "WRKSelectExerciseLabel";
            this.WRKSelectExerciseLabel.Size = new System.Drawing.Size(168, 18);
            this.WRKSelectExerciseLabel.TabIndex = 19;
            this.WRKSelectExerciseLabel.Text = "Drag Exercise to Day";
            // 
            // Day1ListBox
            // 
            this.Day1ListBox.AllowDrop = true;
            this.Day1ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Day1ListBox.Enabled = false;
            this.Day1ListBox.FormattingEnabled = true;
            this.Day1ListBox.Location = new System.Drawing.Point(214, 53);
            this.Day1ListBox.Name = "Day1ListBox";
            this.Day1ListBox.Size = new System.Drawing.Size(154, 82);
            this.Day1ListBox.TabIndex = 20;
            this.Day1ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragDrop);
            this.Day1ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragOver);
            this.Day1ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // DayOfTheWeekComboBox
            // 
            this.DayOfTheWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayOfTheWeekComboBox.FormattingEnabled = true;
            this.DayOfTheWeekComboBox.Items.AddRange(new object[] {
            "Back",
            "Shoulder",
            "Arms",
            "Legs",
            "Chest"});
            this.DayOfTheWeekComboBox.Location = new System.Drawing.Point(374, 53);
            this.DayOfTheWeekComboBox.Name = "DayOfTheWeekComboBox";
            this.DayOfTheWeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.DayOfTheWeekComboBox.TabIndex = 32;
            // 
            // Day1NameTextBox
            // 
            this.Day1NameTextBox.Location = new System.Drawing.Point(274, 31);
            this.Day1NameTextBox.Name = "Day1NameTextBox";
            this.Day1NameTextBox.Size = new System.Drawing.Size(95, 20);
            this.Day1NameTextBox.TabIndex = 46;
            this.Day1NameTextBox.TextChanged += new System.EventHandler(this.Day1NameTextBox_TextChanged);
            // 
            // Day2NameTextBox
            // 
            this.Day2NameTextBox.Location = new System.Drawing.Point(274, 145);
            this.Day2NameTextBox.Name = "Day2NameTextBox";
            this.Day2NameTextBox.Size = new System.Drawing.Size(95, 20);
            this.Day2NameTextBox.TabIndex = 50;
            this.Day2NameTextBox.TextChanged += new System.EventHandler(this.Day2NameTextBox_TextChanged);
            // 
            // Day2ListBox
            // 
            this.Day2ListBox.AllowDrop = true;
            this.Day2ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Day2ListBox.Enabled = false;
            this.Day2ListBox.FormattingEnabled = true;
            this.Day2ListBox.Location = new System.Drawing.Point(214, 167);
            this.Day2ListBox.Name = "Day2ListBox";
            this.Day2ListBox.Size = new System.Drawing.Size(154, 82);
            this.Day2ListBox.TabIndex = 47;
            this.Day2ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragDrop);
            this.Day2ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragOver);
            this.Day2ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // Day3NameTextBox
            // 
            this.Day3NameTextBox.Location = new System.Drawing.Point(274, 259);
            this.Day3NameTextBox.Name = "Day3NameTextBox";
            this.Day3NameTextBox.Size = new System.Drawing.Size(95, 20);
            this.Day3NameTextBox.TabIndex = 54;
            this.Day3NameTextBox.TextChanged += new System.EventHandler(this.Day3NameTextBox_TextChanged);
            // 
            // Day3ListBox
            // 
            this.Day3ListBox.AllowDrop = true;
            this.Day3ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Day3ListBox.Enabled = false;
            this.Day3ListBox.FormattingEnabled = true;
            this.Day3ListBox.Location = new System.Drawing.Point(214, 281);
            this.Day3ListBox.Name = "Day3ListBox";
            this.Day3ListBox.Size = new System.Drawing.Size(154, 82);
            this.Day3ListBox.TabIndex = 51;
            this.Day3ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragDrop);
            this.Day3ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragOver);
            this.Day3ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // Day4NameTextBox
            // 
            this.Day4NameTextBox.Location = new System.Drawing.Point(274, 372);
            this.Day4NameTextBox.Name = "Day4NameTextBox";
            this.Day4NameTextBox.Size = new System.Drawing.Size(95, 20);
            this.Day4NameTextBox.TabIndex = 58;
            this.Day4NameTextBox.TextChanged += new System.EventHandler(this.Day4NameTextBox_TextChanged);
            // 
            // Day4ListBox
            // 
            this.Day4ListBox.AllowDrop = true;
            this.Day4ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Day4ListBox.Enabled = false;
            this.Day4ListBox.FormattingEnabled = true;
            this.Day4ListBox.Location = new System.Drawing.Point(214, 394);
            this.Day4ListBox.Name = "Day4ListBox";
            this.Day4ListBox.Size = new System.Drawing.Size(154, 82);
            this.Day4ListBox.TabIndex = 55;
            this.Day4ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragDrop);
            this.Day4ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragOver);
            this.Day4ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // Day5NameTextBox
            // 
            this.Day5NameTextBox.Location = new System.Drawing.Point(274, 485);
            this.Day5NameTextBox.Name = "Day5NameTextBox";
            this.Day5NameTextBox.Size = new System.Drawing.Size(95, 20);
            this.Day5NameTextBox.TabIndex = 62;
            this.Day5NameTextBox.TextChanged += new System.EventHandler(this.Day5NameTextBox_TextChanged);
            // 
            // Day5ListBox
            // 
            this.Day5ListBox.AllowDrop = true;
            this.Day5ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Day5ListBox.Enabled = false;
            this.Day5ListBox.FormattingEnabled = true;
            this.Day5ListBox.Location = new System.Drawing.Point(214, 507);
            this.Day5ListBox.Name = "Day5ListBox";
            this.Day5ListBox.Size = new System.Drawing.Size(154, 82);
            this.Day5ListBox.TabIndex = 59;
            this.Day5ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragDrop);
            this.Day5ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DayListBox_DragOver);
            this.Day5ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // DayOfWeekLabel
            // 
            this.DayOfWeekLabel.AutoSize = true;
            this.DayOfWeekLabel.Location = new System.Drawing.Point(211, 37);
            this.DayOfWeekLabel.Name = "DayOfWeekLabel";
            this.DayOfWeekLabel.Size = new System.Drawing.Size(57, 13);
            this.DayOfWeekLabel.TabIndex = 21;
            this.DayOfWeekLabel.Text = "Day Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Day Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Day Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Day Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Day Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Workout type - strength, size, endurance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Muscle Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Muscle Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Muscle Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Muscle Group";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Muscle Group";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Back",
            "Shoulder",
            "Arms",
            "Legs",
            "Chest"});
            this.comboBox1.Location = new System.Drawing.Point(374, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Back",
            "Shoulder",
            "Arms",
            "Legs",
            "Chest"});
            this.comboBox2.Location = new System.Drawing.Point(374, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 74;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Back",
            "Shoulder",
            "Arms",
            "Legs",
            "Chest"});
            this.comboBox3.Location = new System.Drawing.Point(374, 394);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 75;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Back",
            "Shoulder",
            "Arms",
            "Legs",
            "Chest"});
            this.comboBox4.Location = new System.Drawing.Point(374, 507);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 76;
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(186, 664);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(116, 39);
            this.SaveAndClose.TabIndex = 77;
            this.SaveAndClose.Text = "Save Workout";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.LightSalmon;
            this.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsPanel.Controls.Add(this.DetailsCompleteCB);
            this.DetailsPanel.Controls.Add(this.DetailsForLabel);
            this.DetailsPanel.Controls.Add(this.Exercise_Getting_Details_label);
            this.DetailsPanel.Controls.Add(this.tableLayoutPanel1);
            this.DetailsPanel.Controls.Add(this.SetsUD);
            this.DetailsPanel.Controls.Add(this.SetsLabel);
            this.DetailsPanel.Location = new System.Drawing.Point(510, 53);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(430, 278);
            this.DetailsPanel.TabIndex = 79;
            this.DetailsPanel.Leave += new System.EventHandler(this.DetailsPanel_Leave);
            // 
            // DetailsCompleteCB
            // 
            this.DetailsCompleteCB.AutoSize = true;
            this.DetailsCompleteCB.Location = new System.Drawing.Point(176, 60);
            this.DetailsCompleteCB.Name = "DetailsCompleteCB";
            this.DetailsCompleteCB.Size = new System.Drawing.Size(102, 17);
            this.DetailsCompleteCB.TabIndex = 55;
            this.DetailsCompleteCB.Text = "DetailsComplete";
            this.DetailsCompleteCB.UseVisualStyleBackColor = true;
            // 
            // DetailsForLabel
            // 
            this.DetailsForLabel.AutoSize = true;
            this.DetailsForLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DetailsForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsForLabel.Location = new System.Drawing.Point(84, 19);
            this.DetailsForLabel.Name = "DetailsForLabel";
            this.DetailsForLabel.Size = new System.Drawing.Size(99, 22);
            this.DetailsForLabel.TabIndex = 54;
            this.DetailsForLabel.Text = "Details for:";
            // 
            // Exercise_Getting_Details_label
            // 
            this.Exercise_Getting_Details_label.AutoSize = true;
            this.Exercise_Getting_Details_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Exercise_Getting_Details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercise_Getting_Details_label.Location = new System.Drawing.Point(189, 19);
            this.Exercise_Getting_Details_label.Name = "Exercise_Getting_Details_label";
            this.Exercise_Getting_Details_label.Size = new System.Drawing.Size(2, 22);
            this.Exercise_Getting_Details_label.TabIndex = 53;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.12782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.87218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.SetCounterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RepsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rest4UD, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rest3UD, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.RestLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rest2UD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Set1Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Rest1UD, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Weight5UD, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Weight4UD, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Reps1UD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Weight3UD, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Reps2UD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Weight2UD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Reps3UD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Weight1UD, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Reps4UD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Reps5UD, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 170);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // SetCounterLabel
            // 
            this.SetCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetCounterLabel.AutoSize = true;
            this.SetCounterLabel.Location = new System.Drawing.Point(22, 5);
            this.SetCounterLabel.Name = "SetCounterLabel";
            this.SetCounterLabel.Size = new System.Drawing.Size(23, 13);
            this.SetCounterLabel.TabIndex = 51;
            this.SetCounterLabel.Text = "Set";
            // 
            // RepsLabel
            // 
            this.RepsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepsLabel.AutoSize = true;
            this.RepsLabel.Location = new System.Drawing.Point(82, 5);
            this.RepsLabel.Name = "RepsLabel";
            this.RepsLabel.Size = new System.Drawing.Size(35, 13);
            this.RepsLabel.TabIndex = 25;
            this.RepsLabel.Text = "Reps:";
            // 
            // Rest4UD
            // 
            this.Rest4UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rest4UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rest4UD.Location = new System.Drawing.Point(299, 118);
            this.Rest4UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rest4UD.Name = "Rest4UD";
            this.Rest4UD.Size = new System.Drawing.Size(39, 20);
            this.Rest4UD.TabIndex = 48;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(138, 5);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(87, 13);
            this.WeightLabel.TabIndex = 39;
            this.WeightLabel.Text = "Weight: (% 1RM)";
            // 
            // Rest3UD
            // 
            this.Rest3UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rest3UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rest3UD.Location = new System.Drawing.Point(299, 86);
            this.Rest3UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rest3UD.Name = "Rest3UD";
            this.Rest3UD.Size = new System.Drawing.Size(39, 20);
            this.Rest3UD.TabIndex = 47;
            // 
            // RestLabel
            // 
            this.RestLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestLabel.AutoSize = true;
            this.RestLabel.Location = new System.Drawing.Point(279, 5);
            this.RestLabel.Name = "RestLabel";
            this.RestLabel.Size = new System.Drawing.Size(78, 13);
            this.RestLabel.TabIndex = 50;
            this.RestLabel.Text = "Rest (seconds)";
            // 
            // Rest2UD
            // 
            this.Rest2UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rest2UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rest2UD.Location = new System.Drawing.Point(299, 57);
            this.Rest2UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rest2UD.Name = "Rest2UD";
            this.Rest2UD.Size = new System.Drawing.Size(39, 20);
            this.Rest2UD.TabIndex = 46;
            // 
            // Set1Label
            // 
            this.Set1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Set1Label.AutoSize = true;
            this.Set1Label.Location = new System.Drawing.Point(27, 32);
            this.Set1Label.Name = "Set1Label";
            this.Set1Label.Size = new System.Drawing.Size(13, 13);
            this.Set1Label.TabIndex = 53;
            this.Set1Label.Text = "1";
            // 
            // Rest1UD
            // 
            this.Rest1UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rest1UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rest1UD.Location = new System.Drawing.Point(299, 28);
            this.Rest1UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rest1UD.Name = "Rest1UD";
            this.Rest1UD.Size = new System.Drawing.Size(39, 20);
            this.Rest1UD.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "2";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "3";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "4";
            // 
            // Weight5UD
            // 
            this.Weight5UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight5UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight5UD.Location = new System.Drawing.Point(162, 148);
            this.Weight5UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Weight5UD.Name = "Weight5UD";
            this.Weight5UD.Size = new System.Drawing.Size(39, 20);
            this.Weight5UD.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "5";
            // 
            // Weight4UD
            // 
            this.Weight4UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight4UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight4UD.Location = new System.Drawing.Point(162, 118);
            this.Weight4UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Weight4UD.Name = "Weight4UD";
            this.Weight4UD.Size = new System.Drawing.Size(39, 20);
            this.Weight4UD.TabIndex = 36;
            // 
            // Reps1UD
            // 
            this.Reps1UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reps1UD.Location = new System.Drawing.Point(85, 28);
            this.Reps1UD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Reps1UD.Name = "Reps1UD";
            this.Reps1UD.Size = new System.Drawing.Size(29, 20);
            this.Reps1UD.TabIndex = 24;
            this.Reps1UD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Weight3UD
            // 
            this.Weight3UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight3UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight3UD.Location = new System.Drawing.Point(162, 86);
            this.Weight3UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Weight3UD.Name = "Weight3UD";
            this.Weight3UD.Size = new System.Drawing.Size(39, 20);
            this.Weight3UD.TabIndex = 34;
            // 
            // Reps2UD
            // 
            this.Reps2UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reps2UD.Location = new System.Drawing.Point(85, 57);
            this.Reps2UD.Name = "Reps2UD";
            this.Reps2UD.Size = new System.Drawing.Size(29, 20);
            this.Reps2UD.TabIndex = 28;
            // 
            // Weight2UD
            // 
            this.Weight2UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight2UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight2UD.Location = new System.Drawing.Point(162, 57);
            this.Weight2UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Weight2UD.Name = "Weight2UD";
            this.Weight2UD.Size = new System.Drawing.Size(39, 20);
            this.Weight2UD.TabIndex = 30;
            // 
            // Reps3UD
            // 
            this.Reps3UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reps3UD.Location = new System.Drawing.Point(85, 86);
            this.Reps3UD.Name = "Reps3UD";
            this.Reps3UD.Size = new System.Drawing.Size(29, 20);
            this.Reps3UD.TabIndex = 32;
            // 
            // Weight1UD
            // 
            this.Weight1UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weight1UD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight1UD.Location = new System.Drawing.Point(162, 28);
            this.Weight1UD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Weight1UD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Weight1UD.Name = "Weight1UD";
            this.Weight1UD.Size = new System.Drawing.Size(39, 20);
            this.Weight1UD.TabIndex = 26;
            this.Weight1UD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Reps4UD
            // 
            this.Reps4UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reps4UD.Location = new System.Drawing.Point(88, 118);
            this.Reps4UD.Name = "Reps4UD";
            this.Reps4UD.Size = new System.Drawing.Size(22, 20);
            this.Reps4UD.TabIndex = 35;
            // 
            // Reps5UD
            // 
            this.Reps5UD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reps5UD.Location = new System.Drawing.Point(88, 148);
            this.Reps5UD.Name = "Reps5UD";
            this.Reps5UD.Size = new System.Drawing.Size(22, 20);
            this.Reps5UD.TabIndex = 37;
            // 
            // SetsUD
            // 
            this.SetsUD.Location = new System.Drawing.Point(60, 59);
            this.SetsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetsUD.Name = "SetsUD";
            this.SetsUD.Size = new System.Drawing.Size(39, 20);
            this.SetsUD.TabIndex = 22;
            this.SetsUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetsLabel
            // 
            this.SetsLabel.AutoSize = true;
            this.SetsLabel.Location = new System.Drawing.Point(19, 59);
            this.SetsLabel.Name = "SetsLabel";
            this.SetsLabel.Size = new System.Drawing.Size(28, 13);
            this.SetsLabel.TabIndex = 23;
            this.SetsLabel.Text = "Sets";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Strength",
            "Size",
            "Endurance",
            "Density",
            "Cardio"});
            this.comboBox5.Location = new System.Drawing.Point(12, 69);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 80;
            // 
            // Build_workouts_days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 750);
            this.Controls.Add(this.ExerciseDetailsPanel);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Day5NameTextBox);
            this.Controls.Add(this.Day5ListBox);
            this.Controls.Add(this.Day4NameTextBox);
            this.Controls.Add(this.Day4ListBox);
            this.Controls.Add(this.Day3NameTextBox);
            this.Controls.Add(this.Day3ListBox);
            this.Controls.Add(this.Day2NameTextBox);
            this.Controls.Add(this.Day2ListBox);
            this.Controls.Add(this.Day1NameTextBox);
            this.Controls.Add(this.DayOfTheWeekComboBox);
            this.Controls.Add(this.DayOfWeekLabel);
            this.Controls.Add(this.Day1ListBox);
            this.Controls.Add(this.WRKSelectExerciseLabel);
            this.Controls.Add(this.WRKAnalysisListBox);
            this.Name = "Build_workouts_days";
            this.Text = "Workout Days";
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rest4UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest3UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest2UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rest1UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight5UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight4UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps1UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight3UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps2UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps3UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight1UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps4UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reps5UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WRKAnalysisListBox;
        private System.Windows.Forms.Label WRKSelectExerciseLabel;
        private System.Windows.Forms.ListBox Day1ListBox;
        private System.Windows.Forms.ComboBox DayOfTheWeekComboBox;
        private System.Windows.Forms.TextBox Day1NameTextBox;
        private System.Windows.Forms.TextBox Day2NameTextBox;
        private System.Windows.Forms.ListBox Day2ListBox;
        private System.Windows.Forms.TextBox Day3NameTextBox;
        private System.Windows.Forms.ListBox Day3ListBox;
        private System.Windows.Forms.TextBox Day4NameTextBox;
        private System.Windows.Forms.ListBox Day4ListBox;
        private System.Windows.Forms.TextBox Day5NameTextBox;
        private System.Windows.Forms.ListBox Day5ListBox;
        private System.Windows.Forms.Label DayOfWeekLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button SaveAndClose;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.CheckBox DetailsCompleteCB;
        private System.Windows.Forms.Label DetailsForLabel;
        private System.Windows.Forms.Label Exercise_Getting_Details_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SetCounterLabel;
        private System.Windows.Forms.Label RepsLabel;
        private System.Windows.Forms.NumericUpDown Rest4UD;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.NumericUpDown Rest3UD;
        private System.Windows.Forms.Label RestLabel;
        private System.Windows.Forms.NumericUpDown Rest2UD;
        private System.Windows.Forms.Label Set1Label;
        private System.Windows.Forms.NumericUpDown Rest1UD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Weight5UD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Weight4UD;
        private System.Windows.Forms.NumericUpDown Reps1UD;
        private System.Windows.Forms.NumericUpDown Weight3UD;
        private System.Windows.Forms.NumericUpDown Reps2UD;
        private System.Windows.Forms.NumericUpDown Weight2UD;
        private System.Windows.Forms.NumericUpDown Reps3UD;
        private System.Windows.Forms.NumericUpDown Weight1UD;
        private System.Windows.Forms.NumericUpDown Reps4UD;
        private System.Windows.Forms.NumericUpDown Reps5UD;
        private System.Windows.Forms.NumericUpDown SetsUD;
        private System.Windows.Forms.Label SetsLabel;
        private System.Windows.Forms.ComboBox comboBox5;
        private LogExerciseDetails ExerciseDetailsPanel;
    }
}