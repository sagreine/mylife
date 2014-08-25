using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication1.WindowsFormsApplication3;

// Error checking - copy a day, then copy another day. "name" should be exercise name everywhere?
// select copy a day, then exit out without doing anything

// err.. one datatable for the class - send it to copy, get it back, send it to db...?

// restrucutre the table so we insert the details into this table too, so we dont have to do a damn join everytime we want fricken anything

namespace MyLife
{
    public partial class build_workouts : Form
    {        
        public build_workouts()
        {
            InitializeComponent();
            Week_to_schedule wk = new Week_to_schedule(0);
            wk.Location = new Point(0,0);
            weeks_panel.Controls.Add(wk);

            // populate the listbox with available lifts
            Exercises_listbox.DataSource = helperfns.simple_listbox_populater_distinct("Name", "Name", "Exercise_logs");
        }

        public build_workouts(int num_weeks)
        {
            InitializeComponent();

            for (int i = 0; i < num_weeks; i++)
            {
                Week_to_schedule this_week = new Week_to_schedule(i);
                this_week.Name = string.Format("Week {0}", i);
                weeks_panel.Controls.Add(this_week);
                this_week.Location = new Point(0, i * this_week.Size.Height + 1);
            }
            // populate the listbox with available lifts
            Exercises_listbox.DataSource = helperfns.simple_listbox_populater_distinct("Name", "Name", "Exercise_logs");
        }

        public build_workouts(Dictionary<string,object> workout_info)
        {
            InitializeComponent();
            int num_weeks = Convert.ToInt32(workout_info["num_weeks"]);

            for (int i = 0; i < num_weeks; i++)
            {
                Week_to_schedule this_week = new Week_to_schedule(i);
                this_week.Name = string.Format("Week {0}", i);
                weeks_panel.Controls.Add(this_week);
                this_week.Location = new Point(0, i * this_week.Size.Height + 1);

                // add the event handler for button click to every day in this week
                foreach (var this_day in this_week.Controls.OfType<Day_to_schedule>())
                {                    
                    this_day.Get_Copy_day_button.Click += new EventHandler(copy_button);
                }                                
            }
            // populate the listbox with available lifts
            Exercises_listbox.DataSource = helperfns.simple_listbox_populater_distinct("Name", "Name", "Exercise_logs");

            // update the form title telling what workout it is and the title label
            this.Text = "Build Workout - " + Convert.ToString(workout_info["workout_name"]);
            workout_name = Convert.ToString(workout_info["workout_name"]);
            workout_id =   Convert.ToInt32(workout_info["workout_id"]);
        }

        string workout_name;
        int workout_id;


        // we are going to pass 2 datatables. 1 holds the list of every day and week. 1 holds all of the exercises already scheduled
        private void copy_button( object sender, EventArgs e)
        {
            Button day_button = sender as Button;
            string day_to_copy_name = day_button.Parent.Name;
            string week_to_copy_name = day_button.Parent.Parent.Name;
            
            // get all of the information into a DataTable, with one row for every exercise in any listbox
            DataTable every_day_full = new DataTable();
            every_day_full.Columns.Add("week_name");
            every_day_full.Columns.Add("day_name");
            every_day_full.Columns.Add("exercise_name");
            every_day_full.Columns.Add("workout_exercise_id");
            every_day_full.Columns.Add("exercise_order");
            every_day_full.Columns.Add("this_is_day_to_copy");

            // a separate datatable to pass. will deprecate this. holds every day and week combination, even if there are no exercises listed
            DataTable list_of_days_and_weeks = new DataTable();
            list_of_days_and_weeks.Columns.Add("week_name");
            list_of_days_and_weeks.Columns.Add("day_name");

            // for each week on the page
            foreach (var given_week in this.weeks_panel.Controls.OfType<Week_to_schedule>())
            {
                // get the name of this week
                string this_week_name = given_week.Name;

                // for each day
                foreach (var given_day in given_week.Controls.OfType<Day_to_schedule>())
                {
                    // we change the name of this day (update it) and add the row to the datatable
                    DataRow this_day_and_week = list_of_days_and_weeks.NewRow();
                    this_day_and_week["week_name"] = given_week.Name;
                    this_day_and_week["day_name"] = given_day.Name;
                    list_of_days_and_weeks.Rows.Add(this_day_and_week);

                    // if this is the day we selected to copy, then this_is_day_to_copy will be set to yes
                    bool this_is_day_to_copy = new bool();
                    if (given_week.Name == week_to_copy_name & given_day.Name == day_to_copy_name)
                    {
                        this_is_day_to_copy = true;
                    }
                    else
                    {
                        this_is_day_to_copy = false;
                    }
                    
                    // for all the exercises currently scheduled in this day, we will have a row in the master DT.                    
                    DataTable current_items = (DataTable)given_day.Get_Days_LB.DataSource;

                    for (int i = 0; i < current_items.Rows.Count; i++)
                    {
                       DataRow given_day_row = every_day_full.NewRow();
                       given_day_row["week_name"] = this_week_name;
                       given_day_row["day_name"] = given_day.Name;
                       given_day_row["exercise_name"] = current_items.Rows[i]["exercise_name"].ToString();
                       given_day_row["workout_exercise_id"] = current_items.Rows[i]["Workout_Exercise_ID"].ToString();
                       given_day_row["exercise_order"] = current_items.Rows[i]["exercise_order"].ToString();                        
                       given_day_row["this_is_day_to_copy"] = this_is_day_to_copy;

                       every_day_full.Rows.Add(given_day_row);
                    }                    
                }                
            }
            Copy_days Copying_days_form = new Copy_days(every_day_full, list_of_days_and_weeks);                                                  
            //using (Copy_days Copying_days_form = new Copy_days(every_day_full, list_of_days_and_weeks))
            Copying_days_form.ShowDialog(); 
                //if (DialogResult == DialogResult.OK)
               // {
                    //{                
                    // All days that will be copied to.
                    DataTable DaysToCopyReturned = Copying_days_form.GetDaysToCopy;

                    // exercises that have been selected to be copied
                    DataTable ExercisesToCopyRetured = Copying_days_form.GetExercisesToCopy;

                    //}
              //  }

            // do the copying for every day that we chose to copy to
            for (int i = 0; i < DaysToCopyReturned.Rows.Count; i++)
            {
               foreach (var given_week in this.weeks_panel.Controls.OfType<Week_to_schedule>())
               {
                   // if we are copying to a day in this week
                   if (given_week.Name == DaysToCopyReturned.Rows[i]["week_name"].ToString())
                   {
                       foreach (var given_day in given_week.Controls.OfType<Day_to_schedule>())
                       {   // if we are copying to this day
                           if (given_day.Name == DaysToCopyReturned.Rows[i]["day_name"].ToString())
                           {  // set the data source for this day to be the data source we are copying
                               given_day.Get_Days_LB.DataSource = null;
                               given_day.Get_Days_LB.DataSource = ExercisesToCopyRetured;
                               given_day.Get_Days_LB.ValueMember = "workout_exercise_id";
                               given_day.Get_Days_LB.DisplayMember = "exercise_name";
                               given_day.Get_Days_LB.SelectedIndex = -1;
                           }
                       }
                   }
               }
            }            
        }

        private void Exercises_listbox_MouseDown(object sender, MouseEventArgs e)
        {
            helperfns.Mousedown_LB_make_drag_outable(sender, e, Exercises_listbox, this);
        }

        private void Workout_Scheduler_Click(object sender, EventArgs e)
        {
            // insert all of the datasources for these days into db

            

            // need a new table for that - workout exercises
            DataTable every_rep_to_schedule = new DataTable();            
            every_rep_to_schedule.Columns.Add("workout_id");
            every_rep_to_schedule.Columns.Add("week_number");
            every_rep_to_schedule.Columns.Add("day_number");
            // if this came from a saved day, we want to link to that shit
            every_rep_to_schedule.Columns.Add("workout_exercise_id");
            every_rep_to_schedule.Columns.Add("exercise_name");            
            every_rep_to_schedule.Columns.Add("exercise_order_daily");
            every_rep_to_schedule.Columns.Add("exercise_order_absolute");
            
            // counter that will go through every exercise in the whole workout
            int exercise_order_absolute = 0;
            int week_number = 0;
            int day_number = 0;

            foreach (var given_week in this.weeks_panel.Controls.OfType<Week_to_schedule>())
            {
                week_number++;
                foreach (var given_day in given_week.Controls.OfType<Day_to_schedule>())
                {
                    // list of exercises in the day, including any details that might be there
                    DataTable exercise_list = (DataTable)given_day.Get_Days_LB.DataSource;
                    day_number++;
                    for (int exercise = 0; exercise < exercise_list.Rows.Count; exercise++)
                    {
                        DataRow this_lift = every_rep_to_schedule.NewRow();
                        //this_lift["workout_name"] = workout_name;
                        this_lift["workout_id"] = workout_id;
                        this_lift["week_number"] = week_number;
                        this_lift["day_number"] = day_number;
                        this_lift["workout_exercise_id"] = exercise_list.Rows[exercise]["workout_exercise_id"].ToString();
                        this_lift["exercise_name"] = exercise_list.Rows[exercise]["exercise_name"].ToString();
                        this_lift["exercise_order_daily"] = exercise_list.Rows[exercise]["exercise_order"].ToString();
                        this_lift["exercise_order_absolute"] = exercise_order_absolute;

                        // add this exercise to the master datatable
                        every_rep_to_schedule.Rows.Add(this_lift);

                        // increment the workout-wide ordering integer
                        exercise_order_absolute++;
                        
                    }
                }
            }

            
            //bulk_insert the details of it
            Constants.Constants_class.db.bulk_insert("Workout_components", every_rep_to_schedule, false);

            // open the scheduler page                    
            Workout_Scheduler workout_scheduler = new Workout_Scheduler(workout_id);
            this.Close();
            workout_scheduler.Show();
        }        
    }
}
