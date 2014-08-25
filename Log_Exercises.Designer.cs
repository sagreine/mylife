using ConsoleApplication1.WindowsFormsApplication3;

namespace MyLife
{
    partial class Log_Exercises
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogExerciseNameLabel = new System.Windows.Forms.Label();
            this.LogExerciseNameCB = new System.Windows.Forms.ComboBox();
            this.LogExerciseDateExercisedLabel = new System.Windows.Forms.Label();
            this.LogExerciseCalendar = new System.Windows.Forms.MonthCalendar();
            this.LECancelButton = new System.Windows.Forms.Button();
            this.LogExerciseMoreOrLessUD = new System.Windows.Forms.DomainUpDown();
            this.LogExerciseFeltGoodUD = new System.Windows.Forms.DomainUpDown();
            this.LogExerciseDifficultyLabel = new System.Windows.Forms.Label();
            this.LogExerciseMoreOrLessLabel = new System.Windows.Forms.Label();
            this.LogExerciseFeltGood = new System.Windows.Forms.Label();
            this.LogExerciseDifficultyUD = new System.Windows.Forms.NumericUpDown();
            this.logExerciseDetails = new MyLife.LogExerciseDetails();
            ((System.ComponentModel.ISupportInitialize)(this.LogExerciseDifficultyUD)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Log Exercise";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Log Exercise and Add Another";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log an Exercise";
            // 
            // LogExerciseNameLabel
            // 
            this.LogExerciseNameLabel.AutoSize = true;
            this.LogExerciseNameLabel.Location = new System.Drawing.Point(29, 87);
            this.LogExerciseNameLabel.Name = "LogExerciseNameLabel";
            this.LogExerciseNameLabel.Size = new System.Drawing.Size(78, 13);
            this.LogExerciseNameLabel.TabIndex = 0;
            this.LogExerciseNameLabel.Text = "Exercise Name";
            // 
            // LogExerciseNameCB
            // 
            this.LogExerciseNameCB.CausesValidation = false;
            this.LogExerciseNameCB.FormattingEnabled = true;
            this.LogExerciseNameCB.IntegralHeight = false;
            this.LogExerciseNameCB.Location = new System.Drawing.Point(113, 84);
            this.LogExerciseNameCB.Name = "LogExerciseNameCB";
            this.LogExerciseNameCB.Size = new System.Drawing.Size(121, 21);
            this.LogExerciseNameCB.TabIndex = 4;
            this.LogExerciseNameCB.SelectedValueChanged += new System.EventHandler(this.LogExerciseNameCB_Leave);
            this.LogExerciseNameCB.TextChanged += new System.EventHandler(this.LogExerciseNameCB_TextChanged);
            this.LogExerciseNameCB.Enter += new System.EventHandler(this.LogExerciseNameCB_Enter);
            this.LogExerciseNameCB.Leave += new System.EventHandler(this.LogExerciseNameCB_Leave);
            // 
            // LogExerciseDateExercisedLabel
            // 
            this.LogExerciseDateExercisedLabel.AutoSize = true;
            this.LogExerciseDateExercisedLabel.Location = new System.Drawing.Point(29, 127);
            this.LogExerciseDateExercisedLabel.Name = "LogExerciseDateExercisedLabel";
            this.LogExerciseDateExercisedLabel.Size = new System.Drawing.Size(82, 13);
            this.LogExerciseDateExercisedLabel.TabIndex = 30;
            this.LogExerciseDateExercisedLabel.Text = "Date Exercised:";
            // 
            // LogExerciseCalendar
            // 
            this.LogExerciseCalendar.Location = new System.Drawing.Point(113, 127);
            this.LogExerciseCalendar.Name = "LogExerciseCalendar";
            this.LogExerciseCalendar.TabIndex = 16;
            // 
            // LECancelButton
            // 
            this.LECancelButton.Location = new System.Drawing.Point(236, 392);
            this.LECancelButton.Name = "LECancelButton";
            this.LECancelButton.Size = new System.Drawing.Size(102, 44);
            this.LECancelButton.TabIndex = 44;
            this.LECancelButton.Text = "Cancel";
            this.LECancelButton.UseVisualStyleBackColor = true;
            this.LECancelButton.Click += new System.EventHandler(this.LECancelButton_Click);
            // 
            // LogExerciseMoreOrLessUD
            // 
            this.LogExerciseMoreOrLessUD.Items.Add("More");
            this.LogExerciseMoreOrLessUD.Items.Add("Less");
            this.LogExerciseMoreOrLessUD.Location = new System.Drawing.Point(113, 366);
            this.LogExerciseMoreOrLessUD.Name = "LogExerciseMoreOrLessUD";
            this.LogExerciseMoreOrLessUD.Size = new System.Drawing.Size(47, 20);
            this.LogExerciseMoreOrLessUD.TabIndex = 18;
            // 
            // LogExerciseFeltGoodUD
            // 
            this.LogExerciseFeltGoodUD.Items.Add("Yes");
            this.LogExerciseFeltGoodUD.Items.Add("No");
            this.LogExerciseFeltGoodUD.Location = new System.Drawing.Point(113, 344);
            this.LogExerciseFeltGoodUD.Name = "LogExerciseFeltGoodUD";
            this.LogExerciseFeltGoodUD.Size = new System.Drawing.Size(47, 20);
            this.LogExerciseFeltGoodUD.TabIndex = 17;
            // 
            // LogExerciseDifficultyLabel
            // 
            this.LogExerciseDifficultyLabel.AutoSize = true;
            this.LogExerciseDifficultyLabel.Location = new System.Drawing.Point(29, 319);
            this.LogExerciseDifficultyLabel.Name = "LogExerciseDifficultyLabel";
            this.LogExerciseDifficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.LogExerciseDifficultyLabel.TabIndex = 27;
            this.LogExerciseDifficultyLabel.Text = "Difficulty:";
            // 
            // LogExerciseMoreOrLessLabel
            // 
            this.LogExerciseMoreOrLessLabel.AutoSize = true;
            this.LogExerciseMoreOrLessLabel.Location = new System.Drawing.Point(29, 368);
            this.LogExerciseMoreOrLessLabel.Name = "LogExerciseMoreOrLessLabel";
            this.LogExerciseMoreOrLessLabel.Size = new System.Drawing.Size(61, 13);
            this.LogExerciseMoreOrLessLabel.TabIndex = 28;
            this.LogExerciseMoreOrLessLabel.Text = "Next Time?";
            // 
            // LogExerciseFeltGood
            // 
            this.LogExerciseFeltGood.AutoSize = true;
            this.LogExerciseFeltGood.Location = new System.Drawing.Point(29, 346);
            this.LogExerciseFeltGood.Name = "LogExerciseFeltGood";
            this.LogExerciseFeltGood.Size = new System.Drawing.Size(59, 13);
            this.LogExerciseFeltGood.TabIndex = 29;
            this.LogExerciseFeltGood.Text = "Felt Good?";
            // 
            // LogExerciseDifficultyUD
            // 
            this.LogExerciseDifficultyUD.Location = new System.Drawing.Point(113, 317);
            this.LogExerciseDifficultyUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LogExerciseDifficultyUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LogExerciseDifficultyUD.Name = "LogExerciseDifficultyUD";
            this.LogExerciseDifficultyUD.Size = new System.Drawing.Size(39, 20);
            this.LogExerciseDifficultyUD.TabIndex = 16;
            this.LogExerciseDifficultyUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // logExerciseDetails
            // 
            this.logExerciseDetails.AutoSize = true;
            this.logExerciseDetails.current_exercise = "";
            this.logExerciseDetails.Location = new System.Drawing.Point(352, 127);
            this.logExerciseDetails.Name = "logExerciseDetails";
            this.logExerciseDetails.setsUD = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logExerciseDetails.Size = new System.Drawing.Size(274, 183);
            this.logExerciseDetails.TabIndex = 45;
            // 
            // Log_Exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 446);
            this.Controls.Add(this.logExerciseDetails);
            this.Controls.Add(this.LECancelButton);
            this.Controls.Add(this.LogExerciseDifficultyUD);
            this.Controls.Add(this.LogExerciseCalendar);
            this.Controls.Add(this.LogExerciseDateExercisedLabel);
            this.Controls.Add(this.LogExerciseFeltGood);
            this.Controls.Add(this.LogExerciseMoreOrLessLabel);
            this.Controls.Add(this.LogExerciseDifficultyLabel);
            this.Controls.Add(this.LogExerciseFeltGoodUD);
            this.Controls.Add(this.LogExerciseMoreOrLessUD);
            this.Controls.Add(this.LogExerciseNameCB);
            this.Controls.Add(this.LogExerciseNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Log_Exercises";
            this.Text = "Exercise_Logs";
            ((System.ComponentModel.ISupportInitialize)(this.LogExerciseDifficultyUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LogExerciseNameLabel;
        private System.Windows.Forms.ComboBox LogExerciseNameCB;
        private System.Windows.Forms.Label LogExerciseDateExercisedLabel;
        private System.Windows.Forms.MonthCalendar LogExerciseCalendar;
        private System.Windows.Forms.Button LECancelButton;
        private LogExerciseDetails logExerciseDetails;
        private System.Windows.Forms.DomainUpDown LogExerciseMoreOrLessUD;
        private System.Windows.Forms.DomainUpDown LogExerciseFeltGoodUD;
        private System.Windows.Forms.Label LogExerciseDifficultyLabel;
        private System.Windows.Forms.Label LogExerciseMoreOrLessLabel;
        private System.Windows.Forms.Label LogExerciseFeltGood;
        private System.Windows.Forms.NumericUpDown LogExerciseDifficultyUD;
    }
}