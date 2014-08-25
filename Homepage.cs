using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication1;
using ConsoleApplication1.WindowsFormsApplication3;
using MyLife;
using Constants;

using RDotNet;
using Microsoft.Win32;
using System.IO;

using System.Net;
using System.Threading;
using System.Data.SQLite;

using System.Globalization;




// meals - build them
// dashboard
// obviously, snaphsot of what youve done today/given day / given week (total protein, lifts done, yadda, etc.)
// calendar to schedule workouts, pop up your workout for today that you had scheduled...
// custom sql query builder ... max, mean, all, different fields...

// !!! FOREIGN KEYS ARE AVAILABLE IN SQLITE3 --> USE THEM FOR EXERCISES, WORKOUTS, SCHEDULED EVENTS, FOODLOGS ETC.

// change the row color when details have been entered for workout-day lifts (or checkbox saying im done)

// clean up build workout days. no need for two datasets really, just make a long one.

// string abc = "select [lifts from join to workout_days] where weekname = 'week1' and dayname = 'monday' from recurring events where [whatever combination]";
//  string whatever_combination = "day = 'monday' and recurrence_freq = 'days' and reccurence_every = '5' and reccurence_every * " +
//                                 "recurrence_freq_to_days[1, so 5 * 1] + recurrence_seed [ the first day it was scheduled] = todayasint";


// be able to look back at how good you did at logging/doing your workout
   // green if you logged all exercises, red if none, yellow if some - can do this by checking logs against day against 
   // exercises set to be logged that day. might kill the application to do that much processing though...could update a flag when logging
   // set goals and track the progress...see what % of the time you logged your workout


// !! NEED TO ENFORCE THAT NO WORKOUT_DAY_NAMES AND NO WORKOUT_WEEK CAN BE THE SAME AS ANY OTHER WORKOUT_DAY OR WORKOUT_WEEK RESPECTIVELY
// probly the same for food and lifts too

// some validation needs to be done on the logging pages that the exercize / food has already been added. Or, could just do a non-free form
// list box.

// address default window sizes and locations

// allow them to save the day/week as they build it in the workout_builder - bring up the form, with the
// boxes already filled out

// hmm. for the usercontorls of day and week - do we want the listbox population to be at the usercontrol level or 
// at the form level? Usercontrol level means a hit for every day and a hit for every week to the db. form level means
// we have to assign all of them manually in the code...(in a loop though);

// redo logging, and incorporate one user control for logging, dashboarding logging, and scheduling the details for a lift.

// need a set up to store weights as [actua] values and as percentages
    // build workout days .cs is where we do this. have 2 flags in db saying percentages or absolute, and calculate
    // when we put it into the db

// issue - default value for log exercise details... it is 1, so if we pull in a value for sets that is 1, event wouldnt trigger. howevere
// the minimum is 1 so we cant put 0 or -1 or anything. For now put the initial value at 1.1.... not a good solution at all

// terrible hack with autoscroll on the logging thing. the autoscroll bar was staying painted on the screen (though not functional)
// when the controls shrunk and it was no longer needed

// main page loading, go through full debug on this. Look at when the event change fires for the calendar, event change intended for
// user doing it after page fully loads but yeah...

//
//
//

// FLIP PAGES - put an outline on the screen of where they should place themselves, and then have them take a photo everyday
//              and do a flipbook (quickly show each photo for a few seconds) as/like an animated .gif (!)
//
//
//
//



// to clean up the database....

//using (SQLiteCommand command = m_connection.CreateCommand())
//{
    //command.CommandText = "vacuum;";
    //command.ExecuteNonQuery();
//} 



/// exercise logs need to be in the full integer - 20130805. Rather than date time, or just pick one.
/// exercise_id needs to be in exercise_logs and workout_components - the logging act itself

////////////////////////////////////////////////////////////////////////
/// if we have multiple of the same exercise scheduled ---> they are marked as logged on both of them on the homepage
/// // and that is bad (they get the edit button and the checkbox for already logged. -?-> all them to uncheck the box to log anew?
////////////////////////////////////////////////////////////////////////

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //disable R stuff for now.
             /*RGraphAppHook cbt;
             REngine engine;
             REngine.SetDllDirectory(GetRPath());
             REngine.CreateInstance("RDotNet");
             engine = REngine.GetInstanceFromID("RDotNet");
             cbt = new RGraphAppHook { GraphControl = HomepageAnalysisPanel };

             //engine.EagerEvaluate("data(Fruits)");
             //
             cbt.Install();
             engine.EagerEvaluate("par(mar=c(.2,.2,.2,.2))");
             engine.EagerEvaluate("plot(rnorm(100), xaxt='n', yaxt='n', ann=FALSE)");             
             cbt.Uninstall();*/

            //bring in todays exercises
             //DataTable todays_exercises_dt = 
            
            //string sql = "select name from sqlite_master where type='table'";
            //DataTable tables = Constants_class.db.GetDataTable(sql);
            //for (int i = 0; i < tables.Rows.Count; i++)
            //{
                //DataTable ds = Constants_class.db.GetDataTable("PRAGMA table_info(" + tables.Rows[i][0] + ");");
            //}



             update_Todays_exercises_TLP(todays_exercises(DateTime.Now, DateTime.Now));            
        }
        // what to do when we click a button
        public void log_this_exercise_Click(object sender, EventArgs e)
        {
            Button log_THIS_exercise_btn = (Button)sender;

            // we named each led this way, except minus 1. This is an absolutely terrible way to do this (what happens when we change the way
              // we name our leds as we add them????? -this would break with no warning until we get to this point....)
            int this_row_index =  Todays_exercises_TLP.GetRow(log_THIS_exercise_btn);            

            LogExerciseDetails  led = (LogExerciseDetails)Todays_exercises_TLP.Controls["led" + this_row_index.ToString()];
            
            Log_Exercises logExercise = new Log_Exercises(led);

            // check that the actual thing below doesn't happen if the dialog is cancelled (I don't know enough about this)

            if (logExercise.ShowDialog() == DialogResult.OK)
            {
               CheckBox logged_today_cb = (CheckBox)Todays_exercises_TLP.Controls["logged_today_cb" + this_row_index.ToString()];               
               set_exercise_to_logged(log_THIS_exercise_btn, logged_today_cb);
            }
        }

        public void set_exercise_to_logged (Button button, CheckBox checkbox)
        {                
            // actually, should change this to an "edit log" button rather than disable it. Also, will need to implement
            // the checkbox and this change on the create the tlp event..
            button.Enabled = false;
            button.Text = "Edit Log";
            //button.Click +=new EventHandler(button_Click_editlog);
            checkbox.Checked = true;
        }
        public int datetime_to_int(DateTime dt)
        {
            //if (dt.HasValue)
            //{
                return int.Parse(dt.ToString("yyyyMMdd")); 
            //}
            //else
            //{
              //  return -1;
            //}
        }
        private void update_Todays_exercises_TLP(DataTable todays_exercises_dt)
        {
            Todays_exercises_TLP.SuspendLayout();
            // clear the table thing
            Todays_exercises_TLP.Controls.Clear();
            Todays_exercises_TLP.RowCount = 0;
            Todays_exercises_TLP.RowStyles.Clear();

            //DataTable dt = Constants_class.db.GetDataTable("");

            // find out if we have logged this exercise on the given day

            // then, we want to represent each of these exercises. We want to assign the details, the exercise name, and make a button
            for (int exrc = 0; exrc < todays_exercises_dt.Rows.Count; exrc++)
            {


                //YourCountrol control = new YourControl();
                // setup your control properties
//                Todays_exercises_TLP.Controls.Add(control);


                // add the exercise name
                //
                //
                // COUGH this is not how you spell exercise...
                //
                //
                Label excercise_name = new Label();
                excercise_name.Name = "excercise_name" + exrc.ToString();
                excercise_name.Text = todays_exercises_dt.Rows[exrc]["Exercise_name"].ToString();
                //excercise_name.Size = new System.Drawing.Size(100, 13);
                excercise_name.Anchor = AnchorStyles.None;
                Todays_exercises_TLP.Controls.Add(excercise_name, 0, Todays_exercises_TLP.RowCount);


                // add the date this is scheduled for
                Label excercise_date = new Label();
                excercise_date.Name = "excercise_name" + exrc.ToString();
                DateTime date_from_db;

                // parse the long int turned string into a datetime ("20130618" => equivalent datetime
                if (DateTime.TryParseExact(todays_exercises_dt.Rows[exrc]["date"].ToString(), "yyyyMMdd",
                           CultureInfo.InvariantCulture,
                           DateTimeStyles.None,
                           out date_from_db))
               {
                    // format the datetime as desired as a string and put it into the date label
                  excercise_date.Text = date_from_db.ToString("MM/dd/yyyy");
                  //  excercise_date.Text = anint.ToString("MM/dd/yyyy");
                  excercise_date.Size = new System.Drawing.Size(100, 13);
                  excercise_date.Anchor = AnchorStyles.None;
                  Todays_exercises_TLP.Controls.Add(excercise_date, 1, Todays_exercises_TLP.RowCount);
               }
               else
               {
                  excercise_date.Text = "Unknown - Not Logged in database, check";
               }

                CheckBox logged_today_cb = new CheckBox();
                logged_today_cb.Name = "logged_today_cb" + exrc.ToString();
                logged_today_cb.Text = "Logged Today";
                //excercise_name.Size = new System.Drawing.Size(100, 13);
                logged_today_cb.Anchor = AnchorStyles.None;
                Todays_exercises_TLP.Controls.Add(logged_today_cb, 4, Todays_exercises_TLP.RowCount);

                // if we have already logged for this date for this exercise, set this box as checked
                if (string.IsNullOrEmpty(todays_exercises_dt.Rows[exrc]["exercise_id"].ToString()) == false)
                {
                    logged_today_cb.Checked = true;
                }
                
                if (todays_exercises_dt.Rows[exrc]["Exercise_name"].ToString() != "Rest Day")
                {
                    // add the log this exercise button
                    Button log_this_exercise = new Button();
                    log_this_exercise.Name = "log_this_exercise" + exrc.ToString();
                    log_this_exercise.Text = "Log Exercise";
                    log_this_exercise.Size = new System.Drawing.Size(80, 24);
                    log_this_exercise.Anchor = AnchorStyles.None;
                    // what happens when button is clicked? we will want a way to return if log is completed or not, to update "Logged?" control
                    log_this_exercise.Click += new EventHandler(log_this_exercise_Click);

                    Todays_exercises_TLP.Controls.Add(log_this_exercise, 2, Todays_exercises_TLP.RowCount);

                    LogExerciseDetails led = new LogExerciseDetails(todays_exercises_dt.Rows[exrc]["Exercise_name"].ToString());
                    led.detailsforlabel.Text = todays_exercises_dt.Rows[exrc]["Exercise_name"].ToString();
                    led.Name = "led" + exrc.ToString();
                    led.Anchor = AnchorStyles.Top;
                    // for now...
                    led.Enabled = false;
                    //led.Location = new System.Drawing.Point(60,3); 
                    led.Weight_as_pct_e1rm_cb.Visible = false;

                    // need a fucking flag for this in the god damn database
                    // if it isn't a rest day, add a details panel for it


                    led.setsUD = Convert.ToDecimal(todays_exercises_dt.Rows[exrc]["SETS"]);
                    Todays_exercises_TLP.Controls.Add(led, 3, Todays_exercises_TLP.RowCount);
                    led.ctrlcol_set(todays_exercises_dt.Rows[exrc]);
                }
                // add an indicator that this exercise has been logged



                Todays_exercises_TLP.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Todays_exercises_TLP.RowCount = Todays_exercises_TLP.RowStyles.Count;
                //Todays_exercises_TLP.RowCount++;

            }

            Todays_exercises_TLP.ResumeLayout();

        }
        private DataTable todays_exercises(DateTime start_date, DateTime end_date)
        {
            // this first query might get removed when tables are redone. Basically we want the workout_id(s) of any scheduled workout(s)
            string sql_get_workouts_scheduled = "select distinct workout_id from cal_events inner join workout_components "
                                               +" where " +
                                              " cal_events.workout_components_id = workout_components.workout_components_id and dtend <= "
                                               + datetime_to_int(start_date) + " and dtstart >= " + datetime_to_int(start_date);
            DataTable workouts_scheduled = Constants_class.db.GetDataTable(sql_get_workouts_scheduled);

            // Data table that will hold all exercises between the date range
            DataTable todays_ex = new DataTable();   
            // for each unique workout that is scheduled currently. { That is 1 big reason (of many) for a potential table restructuring}
            for (int i = 0; i < workouts_scheduled.Rows.Count; i++)
            {
                string sql_to_get_details = "select wc.Exercise_name, wc.workout_components_id, el.exercise_id,  wc.Exercise_order_daily, " +
                                            "wc.week_number, wc.day_number, cal.dtstart as date, " +
                                            "coalesce(wd.SETS,1) as SETS, coalesce(wd.REPS1,0) as REPS1, coalesce(wd.REPS2,0) as REPS2, " +
                                  "coalesce(wd.REPS3,0) as REPS3, coalesce(wd.REPS4,0) as REPS4, coalesce(wd.REPS5,0) as REPS5, coalesce(wd.Weight1,0) as Weight1," +
                                  "coalesce(wd.Weight2,0) as Weight2, coalesce(wd.Weight3,0) as Weight3, coalesce(wd.Weight4,0) as Weight4, coalesce(wd.Weight5,0) as Weight5, " +
                                  " coalesce(wd.Rest1,0) as Rest1, coalesce(wd.Rest2,0) as Rest2, coalesce(wd.Rest3,0) as Rest3, coalesce(wd.Rest4,0) as Rest4 " +
                                  "FROM cal_events cal inner join workout_components wc left outer join WORKOUT_DAYS wd on " +
                                  "wc.workout_exercise_id = wd.Workout_Exercise_ID left outer join exercise_logs el on el.exercise_id = wc.exercise_id and el.date_exercised = cal.dtstart " +
                                  " where cal.workout_components_id " +
                                  "= wc.workout_components_id "
                                  + "and wc.workout_id = " + workouts_scheduled.Rows[i]["workout_id"] +
                                  " and cal.dtstart >= " + datetime_to_int(start_date) + " and cal.dtend <= " + datetime_to_int(end_date) +
                                  "  "
                                  + "order by dtstart";
                // the first time through
                if (i == 0)
                {
                    todays_ex = Constants_class.db.GetDataTable(sql_to_get_details);
                }
                else
                {
                    todays_ex.Rows.Add(Constants_class.db.GetDataTable(sql_to_get_details));
                }                
            }
            return todays_ex;
        }

        private void HomePageMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            Todays_exercises_TLP.SuspendLayout();

            // add the events for the selected dates
            update_Todays_exercises_TLP(todays_exercises(HomePageMonthCalendar.SelectionStart, HomePageMonthCalendar.SelectionEnd));

            Todays_exercises_TLP.ResumeLayout();

            // SO HACK... get rid of the scroll bar if we dont need it because for some reasno it was staying on the page when the underlying control was resized (Paint event on control?)
            if (Todays_exercises_TLP.Size.Height < todays_exercises_panel.Size.Height)
            {
                todays_exercises_panel.AutoScroll = false;
            }
            else
            {
                todays_exercises_panel.AutoScroll = true;
            }

        }
        #region homepage_activities_form_launchers
        public static string GetRPath()
        {
            RegistryKey rCore = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\R-core");
            if (rCore == null)
            {
                throw new ApplicationException("Registry key for R-core not found.");
            }
            bool is64Bit = IntPtr.Size == 8;
            RegistryKey r = rCore.OpenSubKey(is64Bit ? "R64" : "R");
            if (r == null)
            {
                throw new ApplicationException("Registry key is not found.");
            }
            Version currentVersion = new Version((string)r.GetValue("Current Version"));
            string installPath = (string)r.GetValue("InstallPath");
            string bin = Path.Combine(installPath, "bin");
            // Up to 2.11.x, DLLs are installed in R_HOME\bin.
            // From 2.12.0, DLLs are installed in the one level deeper directory.
            return currentVersion < new Version(2, 12) ? bin : Path.Combine(bin, is64Bit ? "x64" : "i386");
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_db1DataSet.foods' table. You can move, or remove it, as needed.
            //this.foodsTableAdapter.Fill(this.master_db1DataSet.foods);
            // TODO: This line of code loads data into the 'master_db1DataSet.foods_list' table. You can move, or remove it, as needed.
            //this.foods_listTableAdapter.Fill(this.master_db1DataSet.foods);
            this.WindowState = FormWindowState.Maximized;
        }

        private void addAFoodToolStripMenuItem1_Click(object sender, EventArgs e)
        {                        
            Add_Food addFood = new Add_Food();
            addFood.Show();                       
        }

        private void addAnExerciseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Exercise addExercise = new Add_Exercise();
            addExercise.Show();
        }

        private void logAFoodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Log_Food logFood = new Log_Food(HomePageMonthCalendar.SelectionStart);
            logFood.Show();
        }

        private void HomepageFoodPictureBox_Click(object sender, EventArgs e)
        {
            Log_Food logFood = new Log_Food(HomePageMonthCalendar.SelectionStart);
            logFood.Show();
        }

        private void logAnExerciseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Log_Exercises logExercise = new Log_Exercises(HomePageMonthCalendar.SelectionStart);
            logExercise.Show();
        }

        private void HomepageExercisePictureBox_Click(object sender, EventArgs e)
        {
            Log_Exercises logExercise = new Log_Exercises(HomePageMonthCalendar.SelectionStart);
            logExercise.Show();
        }


        private void HomepageAnalysisPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // RGraphForm rgraphform = new RGraphForm();
            //rgraphform.Show();
        }

        private void foodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analyze_Foods analyzefoods = new Analyze_Foods();
            analyzefoods.Show();
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analyze_Exercises analyzeexercises = new Analyze_Exercises();
            analyzeexercises.Show();
        }

        private void workoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Build_workouts_days workouts = new Build_workouts_days(); 
            workouts.Show();            
        }


        private void workoutWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            build_workouts_weeks workouts = new build_workouts_weeks();
            workouts.Show();  
        }

        private void HomepageAnalysisPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void workoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Workout_info workout = new Workout_info();
            workout.Show();  
        }

        private void workoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Workout_Scheduler workout_scheduler = new Workout_Scheduler();
            workout_scheduler.Show();
        }

        private void measurementsAndImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BodyMeasurements bodymeasurements = new BodyMeasurements();
            bodymeasurements.Show();
        }
        #endregion





    }
}
namespace Constants
{
    public static class Constants_class
    {
//       public static readonly SQLiteDatabase db = new SQLiteDatabase("C:\\Users\\Scott\\Documents\\R\\new_db\\Master_db1.sqlite");
        public static readonly SQLiteDatabase db = new SQLiteDatabase("C:\\Users\\sgreiner\\Documents\\csharp\\Master_db1.sqlite");
       // public static readonly SQLiteConnection db = new SQLiteConnection("C:\\Users\\Scott\\Documents\\R\\new_db\\Master_db1.sqlite");?

        
       public static readonly int cal_id = 1;
       public static readonly Color week_header_background_color = System.Drawing.Color.BurlyWood;
       public static readonly Color week_days_background_color = System.Drawing.Color.PeachPuff;
    }
}