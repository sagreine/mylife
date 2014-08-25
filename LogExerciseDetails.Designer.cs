namespace MyLife
{
    partial class LogExerciseDetails
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
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.weight_as_pct_e1rm_cb = new System.Windows.Forms.CheckBox();
            this.Comments_tb = new System.Windows.Forms.TextBox();
            this.Comments_lbl = new System.Windows.Forms.Label();
            this.DetailsForLabel = new System.Windows.Forms.Label();
            this.Info_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.SetCounterLabel = new System.Windows.Forms.Label();
            this.RepsLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.RestLabel = new System.Windows.Forms.Label();
            this.SetsUD = new System.Windows.Forms.NumericUpDown();
            this.SetsLabel = new System.Windows.Forms.Label();
            this.DetailsPanel.SuspendLayout();
            this.Info_tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetsUD)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.AutoSize = true;
            this.DetailsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsPanel.Controls.Add(this.weight_as_pct_e1rm_cb);
            this.DetailsPanel.Controls.Add(this.Comments_tb);
            this.DetailsPanel.Controls.Add(this.Comments_lbl);
            this.DetailsPanel.Controls.Add(this.DetailsForLabel);
            this.DetailsPanel.Controls.Add(this.Info_tlp);
            this.DetailsPanel.Controls.Add(this.SetsUD);
            this.DetailsPanel.Controls.Add(this.SetsLabel);
            this.DetailsPanel.Location = new System.Drawing.Point(0, 3);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(252, 162);
            this.DetailsPanel.TabIndex = 80;
            // 
            // weight_as_pct_e1rm_cb
            // 
            this.weight_as_pct_e1rm_cb.AutoSize = true;
            this.weight_as_pct_e1rm_cb.Location = new System.Drawing.Point(106, 47);
            this.weight_as_pct_e1rm_cb.Name = "weight_as_pct_e1rm_cb";
            this.weight_as_pct_e1rm_cb.Size = new System.Drawing.Size(140, 17);
            this.weight_as_pct_e1rm_cb.TabIndex = 82;
            this.weight_as_pct_e1rm_cb.Text = "Weight as % 1 Rep Max";
            this.weight_as_pct_e1rm_cb.UseVisualStyleBackColor = true;
            // 
            // Comments_tb
            // 
            this.Comments_tb.Location = new System.Drawing.Point(61, 74);
            this.Comments_tb.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Comments_tb.Name = "Comments_tb";
            this.Comments_tb.Size = new System.Drawing.Size(188, 20);
            this.Comments_tb.TabIndex = 56;
            // 
            // Comments_lbl
            // 
            this.Comments_lbl.AutoSize = true;
            this.Comments_lbl.Location = new System.Drawing.Point(3, 77);
            this.Comments_lbl.Name = "Comments_lbl";
            this.Comments_lbl.Size = new System.Drawing.Size(56, 13);
            this.Comments_lbl.TabIndex = 55;
            this.Comments_lbl.Text = "Comments";
            // 
            // DetailsForLabel
            // 
            this.DetailsForLabel.AutoSize = true;
            this.DetailsForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsForLabel.Location = new System.Drawing.Point(-2, 0);
            this.DetailsForLabel.Name = "DetailsForLabel";
            this.DetailsForLabel.Size = new System.Drawing.Size(71, 20);
            this.DetailsForLabel.TabIndex = 54;
            this.DetailsForLabel.Text = "Log for:";
            // 
            // Info_tlp
            // 
            this.Info_tlp.AutoSize = true;
            this.Info_tlp.BackColor = System.Drawing.SystemColors.Control;
            this.Info_tlp.ColumnCount = 4;
            this.Info_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Info_tlp.Controls.Add(this.SetCounterLabel, 0, 0);
            this.Info_tlp.Controls.Add(this.RepsLabel, 1, 0);
            this.Info_tlp.Controls.Add(this.WeightLabel, 2, 0);
            this.Info_tlp.Controls.Add(this.RestLabel, 3, 0);
            this.Info_tlp.Location = new System.Drawing.Point(2, 100);
            this.Info_tlp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Info_tlp.Name = "Info_tlp";
            this.Info_tlp.RowCount = 1;
            this.Info_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Info_tlp.Size = new System.Drawing.Size(247, 46);
            this.Info_tlp.TabIndex = 52;
            // 
            // SetCounterLabel
            // 
            this.SetCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetCounterLabel.AutoSize = true;
            this.SetCounterLabel.Location = new System.Drawing.Point(3, 16);
            this.SetCounterLabel.Name = "SetCounterLabel";
            this.SetCounterLabel.Size = new System.Drawing.Size(23, 13);
            this.SetCounterLabel.TabIndex = 51;
            this.SetCounterLabel.Text = "Set";
            // 
            // RepsLabel
            // 
            this.RepsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepsLabel.AutoSize = true;
            this.RepsLabel.Location = new System.Drawing.Point(32, 16);
            this.RepsLabel.Name = "RepsLabel";
            this.RepsLabel.Size = new System.Drawing.Size(35, 13);
            this.RepsLabel.TabIndex = 25;
            this.RepsLabel.Text = "Reps:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(73, 16);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(87, 13);
            this.WeightLabel.TabIndex = 39;
            this.WeightLabel.Text = "Weight: (% 1RM)";
            // 
            // RestLabel
            // 
            this.RestLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestLabel.AutoSize = true;
            this.RestLabel.Location = new System.Drawing.Point(166, 16);
            this.RestLabel.Name = "RestLabel";
            this.RestLabel.Size = new System.Drawing.Size(78, 13);
            this.RestLabel.TabIndex = 50;
            this.RestLabel.Text = "Rest (seconds)";
            // 
            // SetsUD
            // 
            this.SetsUD.Location = new System.Drawing.Point(61, 47);
            this.SetsUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.SetsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetsUD.Name = "SetsUD";
            this.SetsUD.Size = new System.Drawing.Size(39, 20);
            this.SetsUD.TabIndex = 22;
            this.SetsUD.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.SetsUD.ValueChanged += new System.EventHandler(this.SetsUD_ValueChanged);
            // 
            // SetsLabel
            // 
            this.SetsLabel.AutoSize = true;
            this.SetsLabel.Location = new System.Drawing.Point(20, 47);
            this.SetsLabel.Name = "SetsLabel";
            this.SetsLabel.Size = new System.Drawing.Size(28, 13);
            this.SetsLabel.TabIndex = 23;
            this.SetsLabel.Text = "Sets";
            // 
            // LogExerciseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DetailsPanel);
            this.Name = "LogExerciseDetails";
            this.Size = new System.Drawing.Size(252, 168);
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.Info_tlp.ResumeLayout(false);
            this.Info_tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetsUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.TextBox Comments_tb;
        private System.Windows.Forms.Label Comments_lbl;
        private System.Windows.Forms.Label DetailsForLabel;
        private System.Windows.Forms.TableLayoutPanel Info_tlp;
        private System.Windows.Forms.Label SetCounterLabel;
        private System.Windows.Forms.Label RepsLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label RestLabel;
        private System.Windows.Forms.NumericUpDown SetsUD;
        private System.Windows.Forms.Label SetsLabel;
        private System.Windows.Forms.CheckBox weight_as_pct_e1rm_cb;


    }
}
