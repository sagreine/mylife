using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// remember to name the controls in the row so they can be referenced later and/or 


namespace MyLife
{
    public partial class LogExerciseDetails : UserControl
    {
        public LogExerciseDetails(string exercise)
        {
            InitializeComponent();
            this.current_exercise = exercise;
        }
        public LogExerciseDetails()
        {
            InitializeComponent();
            this.current_exercise = "";
        }
        private string Current_Exercise;
        public string current_exercise { get { return Current_Exercise; } set { Current_Exercise = value; } }        
        public TableLayoutPanel Info_tlp_get { get { return this.Info_tlp; } }        
        // this top one should be taken out of other programs and use the other one......
        //public Double SetsUD_get { get { return Convert.ToDouble(this.SetsUD.Value); } }
        public Decimal setsUD { get { return this.SetsUD.Value; } set{SetsUD.Value = value;} }
        public TextBox comments_tb { get { return Comments_tb; } set { Comments_tb.Text = value.ToString(); } }
        public Label detailsforlabel { get { return DetailsForLabel; } set { DetailsForLabel.Text = value.ToString(); } }
        
        public ControlCollection ctrlcol 
         { 
             get { return this.Info_tlp.Controls; }
         }

        public CheckBox Weight_as_pct_e1rm_cb 
         {
             get { return weight_as_pct_e1rm_cb; }
             set
             {
                 if (weight_as_pct_e1rm_cb.Checked == true)
                 {
                     weight_as_pct_e1rm_cb.Checked = false;
                 }
                 else
                 {
                     weight_as_pct_e1rm_cb.Checked = true;
                 }
             }
        }

        // set reps, sets, weight for all for this exercise
        public void ctrlcol_set(DataRow repsandweight)
        {
            // for every set, get the info
            for (int i = 1; i <= setsUD; i++)
            {
                // as long as we aren't trying to assing a value that is less than the minimum acceptable value for this reps box 
                if (Convert.ToDecimal(repsandweight["Reps" + i.ToString()]) >= ((NumericUpDown)ctrlcol["RepsUD" + i.ToString()]).Minimum)                    
                {
                    // this is incredibly stupid. binding....
                    ((NumericUpDown)ctrlcol["RepsUD" + i.ToString()]).Value = Convert.ToDecimal(repsandweight["Reps" + i.ToString()]);
                    ((NumericUpDown)ctrlcol["WeightUD" + i.ToString()]).Value = Convert.ToDecimal(repsandweight["Weight" + i.ToString()]);
                    ((NumericUpDown)ctrlcol["RestUD" + i.ToString()]).Value = Convert.ToDecimal(repsandweight["Rest" + i.ToString()]);
                }
            }            
        }

        // add or remove rows to the details panel, for the number of sets you are going to perform
        public void SetsUD_ValueChanged(object sender, EventArgs e)
        {
            Info_tlp.SuspendLayout();
            // if we need to add a row, add it  

            // this is moderately complex, because we start our first set on row 1, not row 0
            while (Info_tlp.RowCount - 1 < Convert.ToInt32(setsUD))
            {
                string new_setsval = Convert.ToString(this.Info_tlp.RowCount);

                // the controls that go into each row

                Label sets_label = new Label();
                sets_label.Name = "SetLabel" + new_setsval;
                sets_label.Text = new_setsval;
                sets_label.Size = new System.Drawing.Size(13,13);
                sets_label.Anchor = AnchorStyles.None;
                

                NumericUpDown Reps = new NumericUpDown();
                Reps.Name = "RepsUD" + new_setsval;
                Reps.Value = 0;
                Reps.Minimum = 0;
                Reps.Maximum = 100;
                Reps.Size = new System.Drawing.Size(50, 20);
                Reps.Anchor = AnchorStyles.None;
                // for the first Reps thing
                if (this.Info_tlp.RowCount == 1)
                {
                    Reps.Minimum = 1;
                }

                NumericUpDown Weight = new NumericUpDown();
                Weight.Name = "WeightUD" + new_setsval;
                Weight.Minimum = 0;
                Weight.Increment = 5;
                Weight.Maximum = 2000;
                Weight.Size = new System.Drawing.Size(50, 20);
                Weight.Anchor = AnchorStyles.None;

                NumericUpDown Rest = new NumericUpDown();
                Rest.Name = "RestUD" + new_setsval;
                Rest.Minimum = 0;
                Rest.Increment = 5;
                Rest.Maximum = 1200;
                Rest.Size = new System.Drawing.Size(50, 20);
                Rest.Anchor = AnchorStyles.None;


                // add these controls to the new row                
                Info_tlp.RowCount++;

                Info_tlp.Controls.Add(sets_label, 0, Info_tlp.RowCount );
                Info_tlp.Controls.Add(Reps, 1, Info_tlp.RowCount);
                Info_tlp.Controls.Add(Weight, 2, Info_tlp.RowCount);
                Info_tlp.Controls.Add(Rest, 3, Info_tlp.RowCount );
            }

            // try moving the order? also, want to get rid of them entirely not just remove them from the table...
            while (Info_tlp.RowCount - 1 > Convert.ToInt32(setsUD))
            {
                string old_setsval = Convert.ToString(this.Info_tlp.RowCount - 1); 
                // delete the controls in this row
                //for(int col = 0; col < Info_tlp.ColumnCount; col++)
                //{
                    // couldnt get to work
                    //Control ctrl = Info_tlp.GetControlFromPosition(col,Info_tlp.RowCount - 1); 
                    //Info_tlp.Controls.Remove(ctrl);    ]

                Info_tlp.Controls.RemoveByKey("SetLabel" + old_setsval);
                Info_tlp.Controls.RemoveByKey("RepsUD" + old_setsval);
                Info_tlp.Controls.RemoveByKey("WeightUD" + old_setsval);
                Info_tlp.Controls.RemoveByKey("RestUD" + old_setsval);
                //Info_tlp.Controls["RestUD" + old_setsval].Dispose();

                //}
                // remove the row from the layout panel
                Info_tlp.RowCount--;
                
            }
            Info_tlp.ResumeLayout();
        }

        // this entire thing is f*cking terrible
        // revisit this once we fix the god damn database
        public LogExerciseDetails copy_setsweightreprest(LogExerciseDetails copy_from)
        {
            LogExerciseDetails copy_to = new LogExerciseDetails(copy_from.current_exercise);

            copy_to.setsUD = copy_from.setsUD;
            copy_to.detailsforlabel.Text = copy_from.detailsforlabel.Text;
            copy_to.comments_tb.Text = copy_from.comments_tb.Text;
            copy_to.Weight_as_pct_e1rm_cb.Visible = copy_from.Weight_as_pct_e1rm_cb.Visible;

            DataTable repsandweight_tbl = new DataTable();

            //object[] array = new object[(Int32)copy_from.setsUD * 3];
            DataRow repsandweight = repsandweight_tbl.NewRow();

            // this is required because i am really stupid. that is how i check to make sure this is a 
            repsandweight_tbl.Columns.Add("SETS");
            repsandweight["SETS"] = setsUD;

            // for every set, get the info. But, this needs to go onto one datarow because I am an idiot
            for (int i = 1; i <= setsUD; i++)
            {
                

                repsandweight_tbl.Columns.Add("Reps" + i.ToString());
                repsandweight_tbl.Columns.Add("Weight" + i.ToString());
                repsandweight_tbl.Columns.Add("Rest" + i.ToString());

                

                repsandweight["Reps" + i.ToString()] =  ((NumericUpDown)copy_from.ctrlcol["RepsUD" + i.ToString()]).Value;
                repsandweight["Weight" + i.ToString()] = ((NumericUpDown)copy_from.ctrlcol["WeightUD" + i.ToString()]).Value;
                repsandweight["Rest" + i.ToString()] = ((NumericUpDown)copy_from.ctrlcol["RestUD" + i.ToString()]).Value;           
            }
            //DataRow repsandweight = repsandweight_tbl.Rows[0];
            copy_to.ctrlcol_set(repsandweight);
            return copy_to;
        }
    }
}
