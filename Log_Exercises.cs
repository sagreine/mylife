using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication1.WindowsFormsApplication3;
using Constants;

// right now we do upload the master effective 1 rm to the exercises table, but we do not include a e1rm in the workout log
// this is calculated only at analyze time currently (though there is a field for it in exercise_logs).
// thought was what if we change the formula used to calculate it (or add multiple or something)..
namespace MyLife
{
    public partial class Log_Exercises : Form
    {

        public void logExercise_basic()
        {
            // shouldnt these two be the same...
            string new_exercise_logs_id = helperfns.get_Max_value("Exercise_logs_id", "Exercise_logs");
            string new_exercise_details_logs_id = helperfns.get_Max_value("Exercise_logs_details_id", "Exercise_logs_details");

            DateTime obj = LogExerciseCalendar.SelectionStart;
            string mydate_pre = obj.ToString();
            string mydate = DateTime.Parse(mydate_pre).ToString("yyyy-MM-dd");

            // log for the whole exercise log. details logged separately
            Dictionary<String, string> Exercise_logs = new Dictionary<String, string>();
                                    
            Exercise_logs.Add("Exercise_logs_id", new_exercise_logs_id);
            Exercise_logs.Add("Name", LogExerciseNameCB.Text);
            Exercise_logs.Add("Sets", led_usercontrol.setsUD.ToString());//((NumericUpDown)logExerciseDetails.Controls["SetsUD"]).Value.ToString());
            Exercise_logs.Add("Difficulty", LogExerciseDifficultyUD.Text);
            Exercise_logs.Add("More_or_less", LogExerciseMoreOrLessUD.Text);
            Exercise_logs.Add("Felt_Good", LogExerciseFeltGoodUD.Text);
            Exercise_logs.Add("Comments", led_usercontrol.comments_tb.Text);
            Exercise_logs.Add("Date_Exercised", mydate);
            Exercise_logs.Add("When_Logged", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            DataTable Exercise_logs_details = new DataTable();            
            Exercise_logs_details.Columns.Add("Exercise_logs_id");
            Exercise_logs_details.Columns.Add("Reps");
            Exercise_logs_details.Columns.Add("Name");
            Exercise_logs_details.Columns.Add("Weight");
            Exercise_logs_details.Columns.Add("epley_e1rm");
            Exercise_logs_details.Columns.Add("Date_Exercised");

            // for every row in the panel - up to the number of sets though duh
            for (int row = 0; row < /*logExerciseDetails1.Info_tlp_get.RowCount*/ led_usercontrol.setsUD; row++)
            {
                // we are only going to log details for sets with more than 0 reps                                   
                if (((NumericUpDown)led_usercontrol.ctrlcol["RepsUD" + Convert.ToString(row + 1)]).Value > 0)
                {
                    DataRow This_set = Exercise_logs_details.NewRow();                    
                    This_set["Exercise_logs_id"] = new_exercise_logs_id;
                    This_set["Reps"] = Convert.ToInt32(((NumericUpDown)led_usercontrol.ctrlcol["RepsUD" + Convert.ToString(row + 1)]).Value);
                    This_set["Name"] = LogExerciseNameCB.Text;
                    This_set["Weight"] = Convert.ToDouble(((NumericUpDown)led_usercontrol.ctrlcol["WeightUD" + Convert.ToString(row + 1)]).Value);
                    This_set["epley_e1rm"] = calculations.epley_e1rm(
                        Convert.ToDouble(((NumericUpDown)led_usercontrol.ctrlcol["WeightUD" + Convert.ToString(row + 1)]).Value),
                        Convert.ToInt32(((NumericUpDown)led_usercontrol.ctrlcol["RepsUD" + Convert.ToString(row + 1)]).Value));
                    This_set["Date_Exercised"] = mydate;

                    Exercise_logs_details.Rows.Add(This_set);
                }                
            }
            try
            {
                    // insert all of the rows into exercise details
                Constants_class.db.bulk_insert("Exercise_logs_details", Exercise_logs_details, false);
                    
                    // update the max effective 1 rep max
                    string sql2 = "select max(epley_e1rm) from exercise_logs_details where name = '" + LogExerciseNameCB.Text + "' and date_exercised = '" + mydate + "'";
                    double this_1rm = Convert.ToDouble(Constants_class.db.ExecuteScalar(sql2));
                    // add the epley 1rm for today to the exercise_logs table
                    Exercise_logs.Add("epley_e1rm", Convert.ToString(this_1rm));
                    Constants_class.db.Insert("Exercise_logs", Exercise_logs, false);

                    // if the epley_e1rm is smaller than this epley_e1rm, update the 1rm and the date it was achieved
                    if (Convert.ToDouble(Constants_class.db.ExecuteScalar("select max(epley_e1rm) from exercise_logs where name = '" + LogExerciseNameCB.Text +"'")) < this_1rm )
                    {
                        Dictionary<String, string> update_historical_exercises = new Dictionary<String, string>();
                        // upload the epley 1rm, and the date this 1rm was achieved to the exercises table
                        update_historical_exercises.Add("epley_e1RM", Convert.ToString(this_1rm));
                        update_historical_exercises.Add("date_epley_1rm", mydate);
                        Constants_class.db.Update("Exercises", update_historical_exercises, "name = '" + LogExerciseNameCB.Text + "'");
                    }
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }

        public LogExerciseDetails led_usercontrol;

        // use inheritance....
        public Log_Exercises(DateTime? date_logging)
        {
            InitializeComponent();

            led_usercontrol = logExerciseDetails;            
            /*= new LogExerciseDetails();
            this.Controls.Add(led_usercontrol);
             led_usercontrol.Location = new System.Drawing.Point(558, 1); ;*/

            if (date_logging.HasValue)
            {
                LogExerciseCalendar.SelectionStart = Convert.ToDateTime(date_logging);
                LogExerciseCalendar.SelectionEnd = Convert.ToDateTime(date_logging);
            }
            else
            {
                LogExerciseCalendar.SelectionStart = DateTime.Now;
            }

            // put the focus on some control other than label1, so as to not trigger the expansion (dropdown) of the ExerciseName ComboBox
            ActiveControl = label1;                                 
        }
        public Log_Exercises(LogExerciseDetails led)
        {
            InitializeComponent();

            // get rid of the one that is there, and add the one we pass to it. pretty stupid.
            logExerciseDetails.Dispose();
            LogExerciseDetails led2 = led.copy_setsweightreprest(led);
            Controls.Add(led2);

            led2.Location = new System.Drawing.Point(352, 127);
            led2.Name = "logExerciseDetails";
            
            led_usercontrol = led2;

            // set the text box to the current exercise
            LogExerciseNameCB.Text = led2.current_exercise;

            // put the focus on some control other than label1, so as to not trigger the expansion (dropdown) of the ExerciseName ComboBox
            ActiveControl = label1;                            
        }

        public Log_Exercises()
        {
            InitializeComponent();
            led_usercontrol = logExerciseDetails;
            LogExerciseCalendar.SelectionStart = DateTime.Now;

            // put the focus on some control other than label1, so as to not trigger the expansion (dropdown) of the ExerciseName ComboBox
            ActiveControl = label1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            logExercise_basic();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logExercise_basic();
            this.DialogResult = DialogResult.OK;
            helperfns.RecursiveClearControls(this.Controls);
        }

        // this whole setup with initializer function etc. in this function and the next is pretty terrible
        private void LogExerciseNameCB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LogExerciseNameCB.Text) == true)
            {
                //helperfns.combo_box_name_initializer("Exercises", LogExerciseNameCB, "", "DISTINCT", LogExerciseNameCB_TextChanged);
                helperfns.combo_box_name_initializer("Exercises", LogExerciseNameCB, "DISTINCT", LogExerciseNameCB_TextChanged, "Exercise_id", 5);
            }
            LogExerciseNameCB.TextChanged += new EventHandler(LogExerciseNameCB_TextChanged);
        }

        private void LECancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogExerciseNameCB_Leave(object sender, EventArgs e)
        {
            helperfns.combo_box_shrinker(this.LogExerciseNameCB);
        }

        // this requeries the database to return only the items that match what you've written.
        private void LogExerciseNameCB_TextChanged(object sender, EventArgs e)
        {
            helperfns.combo_box_name_initializer("Exercises", LogExerciseNameCB, "UPDATE", LogExerciseNameCB_Leave, "Exercise_id", 5);
        }
    }
}


