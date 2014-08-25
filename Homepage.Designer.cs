using ConsoleApplication1;
using ConsoleApplication1.WindowsFormsApplication3;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;





namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logAFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logAnExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.HomepageFoodPictureBox = new System.Windows.Forms.PictureBox();
            this.HomepageExercisePictureBox = new System.Windows.Forms.PictureBox();
            this.foodslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterdb1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.HomepageMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAFoodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnExerciseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logAFoodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logAnExerciseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementsAndImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomepageExerciseTT = new System.Windows.Forms.ToolTip(this.components);
            this.HomepageFoodToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HomepageAnalyzeTT = new System.Windows.Forms.ToolTip(this.components);
            this.HomepageAnalysisPanel = new System.Windows.Forms.Panel();
            this.HomePageMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.todays_exercises_panel = new System.Windows.Forms.Panel();
            this.Todays_exercises_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Log_Exercise_label = new System.Windows.Forms.Label();
            this.Details_for_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.diet_dashboard_DGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomepageFoodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomepageExercisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterdb1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource1)).BeginInit();
            this.HomepageMainMenuStrip.SuspendLayout();
            this.todays_exercises_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diet_dashboard_DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // addAFoodToolStripMenuItem
            // 
            this.addAFoodToolStripMenuItem.Name = "addAFoodToolStripMenuItem";
            this.addAFoodToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // addAnExerciseToolStripMenuItem
            // 
            this.addAnExerciseToolStripMenuItem.Name = "addAnExerciseToolStripMenuItem";
            this.addAnExerciseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logAFoodToolStripMenuItem
            // 
            this.logAFoodToolStripMenuItem.Name = "logAFoodToolStripMenuItem";
            this.logAFoodToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logAnExerciseToolStripMenuItem
            // 
            this.logAnExerciseToolStripMenuItem.Name = "logAnExerciseToolStripMenuItem";
            this.logAnExerciseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // HomepageFoodPictureBox
            // 
            this.HomepageFoodPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomepageFoodPictureBox.Image = global::MyLife.Properties.Resources.ID_1008976;
            this.HomepageFoodPictureBox.Location = new System.Drawing.Point(0, 577);
            this.HomepageFoodPictureBox.Name = "HomepageFoodPictureBox";
            this.HomepageFoodPictureBox.Size = new System.Drawing.Size(402, 269);
            this.HomepageFoodPictureBox.TabIndex = 10;
            this.HomepageFoodPictureBox.TabStop = false;
            this.HomepageFoodToolTip.SetToolTip(this.HomepageFoodPictureBox, "Click here to Log a Food!");
            this.HomepageFoodPictureBox.Click += new System.EventHandler(this.HomepageFoodPictureBox_Click);
            // 
            // HomepageExercisePictureBox
            // 
            this.HomepageExercisePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomepageExercisePictureBox.Image = global::MyLife.Properties.Resources.ID_100114077;
            this.HomepageExercisePictureBox.Location = new System.Drawing.Point(421, 577);
            this.HomepageExercisePictureBox.Name = "HomepageExercisePictureBox";
            this.HomepageExercisePictureBox.Size = new System.Drawing.Size(402, 269);
            this.HomepageExercisePictureBox.TabIndex = 9;
            this.HomepageExercisePictureBox.TabStop = false;
            this.HomepageExerciseTT.SetToolTip(this.HomepageExercisePictureBox, "Click here to Log an Exercise!");
            this.HomepageExercisePictureBox.Click += new System.EventHandler(this.HomepageExercisePictureBox_Click);
            // 
            // HomepageMainMenuStrip
            // 
            this.HomepageMainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HomepageMainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HomepageMainMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.HomepageMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.logToolStripMenuItem1,
            this.buildToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.analyzeToolStripMenuItem,
            this.myBodyToolStripMenuItem});
            this.HomepageMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomepageMainMenuStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.HomepageMainMenuStrip.Name = "HomepageMainMenuStrip";
            this.HomepageMainMenuStrip.Size = new System.Drawing.Size(1253, 27);
            this.HomepageMainMenuStrip.TabIndex = 12;
            this.HomepageMainMenuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAFoodToolStripMenuItem1,
            this.addAnExerciseToolStripMenuItem1});
            this.addToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(46, 23);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // addAFoodToolStripMenuItem1
            // 
            this.addAFoodToolStripMenuItem1.Name = "addAFoodToolStripMenuItem1";
            this.addAFoodToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.addAFoodToolStripMenuItem1.Text = "Add a Food";
            this.addAFoodToolStripMenuItem1.Click += new System.EventHandler(this.addAFoodToolStripMenuItem1_Click);
            // 
            // addAnExerciseToolStripMenuItem1
            // 
            this.addAnExerciseToolStripMenuItem1.Name = "addAnExerciseToolStripMenuItem1";
            this.addAnExerciseToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.addAnExerciseToolStripMenuItem1.Text = "Add an Exercise";
            this.addAnExerciseToolStripMenuItem1.Click += new System.EventHandler(this.addAnExerciseToolStripMenuItem1_Click);
            // 
            // logToolStripMenuItem1
            // 
            this.logToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logAFoodToolStripMenuItem1,
            this.logAnExerciseToolStripMenuItem1});
            this.logToolStripMenuItem1.Name = "logToolStripMenuItem1";
            this.logToolStripMenuItem1.Size = new System.Drawing.Size(44, 23);
            this.logToolStripMenuItem1.Text = "Log";
            // 
            // logAFoodToolStripMenuItem1
            // 
            this.logAFoodToolStripMenuItem1.Name = "logAFoodToolStripMenuItem1";
            this.logAFoodToolStripMenuItem1.Size = new System.Drawing.Size(171, 24);
            this.logAFoodToolStripMenuItem1.Text = "Log a Food";
            this.logAFoodToolStripMenuItem1.Click += new System.EventHandler(this.logAFoodToolStripMenuItem1_Click);
            // 
            // logAnExerciseToolStripMenuItem1
            // 
            this.logAnExerciseToolStripMenuItem1.Name = "logAnExerciseToolStripMenuItem1";
            this.logAnExerciseToolStripMenuItem1.Size = new System.Drawing.Size(171, 24);
            this.logAnExerciseToolStripMenuItem1.Text = "Log an Exercise";
            this.logAnExerciseToolStripMenuItem1.Click += new System.EventHandler(this.logAnExerciseToolStripMenuItem1_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workoutToolStripMenuItem,
            this.workoutWeekToolStripMenuItem,
            this.workoutToolStripMenuItem2});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // workoutToolStripMenuItem
            // 
            this.workoutToolStripMenuItem.Name = "workoutToolStripMenuItem";
            this.workoutToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.workoutToolStripMenuItem.Text = "Workout Day";
            this.workoutToolStripMenuItem.Click += new System.EventHandler(this.workoutToolStripMenuItem_Click);
            // 
            // workoutWeekToolStripMenuItem
            // 
            this.workoutWeekToolStripMenuItem.Name = "workoutWeekToolStripMenuItem";
            this.workoutWeekToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.workoutWeekToolStripMenuItem.Text = "Workout Week";
            this.workoutWeekToolStripMenuItem.Click += new System.EventHandler(this.workoutWeekToolStripMenuItem_Click);
            // 
            // workoutToolStripMenuItem2
            // 
            this.workoutToolStripMenuItem2.Name = "workoutToolStripMenuItem2";
            this.workoutToolStripMenuItem2.Size = new System.Drawing.Size(170, 24);
            this.workoutToolStripMenuItem2.Text = "Workout";
            this.workoutToolStripMenuItem2.Click += new System.EventHandler(this.workoutToolStripMenuItem2_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workoutToolStripMenuItem1});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // workoutToolStripMenuItem1
            // 
            this.workoutToolStripMenuItem1.Name = "workoutToolStripMenuItem1";
            this.workoutToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.workoutToolStripMenuItem1.Text = "Workout";
            this.workoutToolStripMenuItem1.Click += new System.EventHandler(this.workoutToolStripMenuItem1_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodsToolStripMenuItem,
            this.exercisesToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            // 
            // foodsToolStripMenuItem
            // 
            this.foodsToolStripMenuItem.Name = "foodsToolStripMenuItem";
            this.foodsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.foodsToolStripMenuItem.Text = "Foods";
            this.foodsToolStripMenuItem.Click += new System.EventHandler(this.foodsToolStripMenuItem_Click);
            // 
            // exercisesToolStripMenuItem
            // 
            this.exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            this.exercisesToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.exercisesToolStripMenuItem.Text = "Exercises";
            this.exercisesToolStripMenuItem.Click += new System.EventHandler(this.exercisesToolStripMenuItem_Click);
            // 
            // myBodyToolStripMenuItem
            // 
            this.myBodyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measurementsAndImagesToolStripMenuItem});
            this.myBodyToolStripMenuItem.Name = "myBodyToolStripMenuItem";
            this.myBodyToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.myBodyToolStripMenuItem.Text = "My Body";
            // 
            // measurementsAndImagesToolStripMenuItem
            // 
            this.measurementsAndImagesToolStripMenuItem.Name = "measurementsAndImagesToolStripMenuItem";
            this.measurementsAndImagesToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.measurementsAndImagesToolStripMenuItem.Text = "Measurements and Images";
            this.measurementsAndImagesToolStripMenuItem.Click += new System.EventHandler(this.measurementsAndImagesToolStripMenuItem_Click);
            // 
            // HomepageExerciseTT
            // 
            this.HomepageExerciseTT.ToolTipTitle = "Log an Exercise";
            // 
            // HomepageFoodToolTip
            // 
            this.HomepageFoodToolTip.ToolTipTitle = "Log a Food";
            // 
            // HomepageAnalyzeTT
            // 
            this.HomepageAnalyzeTT.ToolTipTitle = "Analysis";
            // 
            // HomepageAnalysisPanel
            // 
            this.HomepageAnalysisPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HomepageAnalysisPanel.Location = new System.Drawing.Point(837, 577);
            this.HomepageAnalysisPanel.Name = "HomepageAnalysisPanel";
            this.HomepageAnalysisPanel.Size = new System.Drawing.Size(402, 269);
            this.HomepageAnalysisPanel.TabIndex = 13;
            this.HomepageAnalysisPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomepageAnalysisPanel_MouseClick);
            // 
            // HomePageMonthCalendar
            // 
            this.HomePageMonthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePageMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageMonthCalendar.Location = new System.Drawing.Point(3, 30);
            this.HomePageMonthCalendar.Name = "HomePageMonthCalendar";
            this.HomePageMonthCalendar.TabIndex = 14;
            this.HomePageMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.HomePageMonthCalendar_DateSelected);
            // 
            // todays_exercises_panel
            // 
            this.todays_exercises_panel.AutoScroll = true;
            this.todays_exercises_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todays_exercises_panel.Controls.Add(this.Todays_exercises_TLP);
            this.todays_exercises_panel.Location = new System.Drawing.Point(12, 223);
            this.todays_exercises_panel.Name = "todays_exercises_panel";
            this.todays_exercises_panel.Size = new System.Drawing.Size(709, 348);
            this.todays_exercises_panel.TabIndex = 15;
            // 
            // Todays_exercises_TLP
            // 
            this.Todays_exercises_TLP.AutoSize = true;
            this.Todays_exercises_TLP.BackColor = System.Drawing.SystemColors.Control;
            this.Todays_exercises_TLP.ColumnCount = 5;
            this.Todays_exercises_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Todays_exercises_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Todays_exercises_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Todays_exercises_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Todays_exercises_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Todays_exercises_TLP.Location = new System.Drawing.Point(0, 0);
            this.Todays_exercises_TLP.Name = "Todays_exercises_TLP";
            this.Todays_exercises_TLP.RowCount = 1;
            this.Todays_exercises_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Todays_exercises_TLP.Size = new System.Drawing.Size(692, 137);
            this.Todays_exercises_TLP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Logged Today";
            // 
            // Log_Exercise_label
            // 
            this.Log_Exercise_label.AutoSize = true;
            this.Log_Exercise_label.Location = new System.Drawing.Point(235, 207);
            this.Log_Exercise_label.Name = "Log_Exercise_label";
            this.Log_Exercise_label.Size = new System.Drawing.Size(68, 13);
            this.Log_Exercise_label.TabIndex = 1;
            this.Log_Exercise_label.Text = "Log Exercise";
            // 
            // Details_for_label
            // 
            this.Details_for_label.AutoSize = true;
            this.Details_for_label.BackColor = System.Drawing.SystemColors.Control;
            this.Details_for_label.Location = new System.Drawing.Point(397, 207);
            this.Details_for_label.Name = "Details_for_label";
            this.Details_for_label.Size = new System.Drawing.Size(100, 13);
            this.Details_for_label.TabIndex = 17;
            this.Details_for_label.Text = "Details for Exercise:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercise";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(121, 207);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(30, 13);
            this.Date_Label.TabIndex = 18;
            this.Date_Label.Text = "Date";
            // 
            // diet_dashboard_DGV
            // 
            this.diet_dashboard_DGV.AllowUserToAddRows = false;
            this.diet_dashboard_DGV.AllowUserToDeleteRows = false;
            this.diet_dashboard_DGV.AllowUserToOrderColumns = true;
            this.diet_dashboard_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diet_dashboard_DGV.Location = new System.Drawing.Point(727, 224);
            this.diet_dashboard_DGV.Name = "diet_dashboard_DGV";
            this.diet_dashboard_DGV.Size = new System.Drawing.Size(512, 347);
            this.diet_dashboard_DGV.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(274, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 159);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(781, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Put stuff in here that shows what you have eaten today (calories, etc.), maybe wh" +
    "at you have lifted today too. How many more calories etc. do you have to eat tod" +
    "ay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Logging food for today stuff goes here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Today\'s Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1253, 848);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diet_dashboard_DGV);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.todays_exercises_panel);
            this.Controls.Add(this.Log_Exercise_label);
            this.Controls.Add(this.Details_for_label);
            this.Controls.Add(this.HomePageMonthCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomepageAnalysisPanel);
            this.Controls.Add(this.HomepageFoodPictureBox);
            this.Controls.Add(this.HomepageExercisePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HomepageMainMenuStrip);
            this.MainMenuStrip = this.HomepageMainMenuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLife";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomepageFoodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomepageExercisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterdb1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource1)).EndInit();
            this.HomepageMainMenuStrip.ResumeLayout(false);
            this.HomepageMainMenuStrip.PerformLayout();
            this.todays_exercises_panel.ResumeLayout(false);
            this.todays_exercises_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diet_dashboard_DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logAFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logAnExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource foodslistBindingSource;
        private System.Windows.Forms.BindingSource masterdb1DataSetBindingSource;
        private System.Windows.Forms.BindingSource foodsBindingSource;
        private System.Windows.Forms.BindingSource foodsBindingSource1;
        private PictureBox HomepageExercisePictureBox;
        private PictureBox HomepageFoodPictureBox;
        private MenuStrip HomepageMainMenuStrip;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem addAFoodToolStripMenuItem1;
        private ToolStripMenuItem addAnExerciseToolStripMenuItem1;
        private ToolStripMenuItem logToolStripMenuItem1;
        private ToolStripMenuItem logAFoodToolStripMenuItem1;
        private ToolStripMenuItem logAnExerciseToolStripMenuItem1;
        private ToolStripMenuItem analyzeToolStripMenuItem;
        private ToolTip HomepageExerciseTT;
        private ToolTip HomepageFoodToolTip;
        private ToolTip HomepageAnalyzeTT;
        private ToolStripMenuItem foodsToolStripMenuItem;
        private ToolStripMenuItem exercisesToolStripMenuItem;
        private Panel HomepageAnalysisPanel;
        private MonthCalendar HomePageMonthCalendar;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem workoutToolStripMenuItem;
        private ToolStripMenuItem workoutWeekToolStripMenuItem;
        private ToolStripMenuItem workoutToolStripMenuItem2;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem workoutToolStripMenuItem1;
        private Panel todays_exercises_panel;
        private TableLayoutPanel Todays_exercises_TLP;
        private Label label1;
        private Label Log_Exercise_label;
        private Label label4;
        private Label Details_for_label;
        private Label Date_Label;
        private ToolStripMenuItem myBodyToolStripMenuItem;
        private ToolStripMenuItem measurementsAndImagesToolStripMenuItem;
        private DataGridView diet_dashboard_DGV;
        private Panel panel1;
        private Label label3;
        private Label label6;
        private Label label5;        
        // private WindowsFormsApplication2.Master_db1DataSet master_db1DataSet;
        //private WindowsFormsApplication2.Master_db1DataSetTableAdapters.foods_listTableAdapter foods_listTableAdapter;
        //private WindowsFormsApplication2.Master_db1DataSetTableAdapters.foods_listTableAdapter foods_listTableAdapter1;
        //private WindowsFormsApplication2.Master_db1DataSetTableAdapters.foodsTableAdapter foodsTableAdapter;





    }

}

