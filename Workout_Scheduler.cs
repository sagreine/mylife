using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;
using ConsoleApplication1;
using ConsoleApplication1.WindowsFormsApplication3;

namespace MyLife
{
    public partial class Workout_Scheduler : Form
    {
        public Workout_Scheduler()
        {
            InitializeComponent();
            // so that we can select only one day in the monthcalendar
            num_days_in_workout = 1;
            init_form();            
        }
        public Workout_Scheduler(int workout_id)
        {
            InitializeComponent();
           // selected_workout_name = "";
            //num_days_in_workout = 0;
            init_form();
            // initialize to this workout, as long as it was added to db correctly and exists there
            if (Constants_class.db.GetDataTable("Select workout_id from Workouts where workout_id = " + workout_id.ToString()).Rows.Count > 0)
            {                
                // this fires the event for selectedIndex changed
                Saved_Workouts_cb.SelectedValue = workout_id;                             
            }            
        }

        // private string selected_workout_name;
        private int num_days_in_workout;


        public void init_form()
        {
            
            Saved_Workouts_cb.DataSource =
               Constants_class.db.GetDataTable("Select workout_id, name, num_days_in_workout from Workouts order by times_scheduled desc");
            Saved_Workouts_cb.ValueMember = "workout_id";
            Saved_Workouts_cb.DisplayMember = "name";
            Saved_Workouts_cb.SelectedIndex = -1;
            // update things for the workout, including updating the calendar range
            
            Saved_Workouts_cb.SelectedIndexChanged += new EventHandler(Saved_Workouts_cb_SelectedIndexChanged);
            Saved_Workouts_cb.SelectedIndexChanged += new EventHandler(Workout_days_mc_DateSelected);  
                        

            // set up the month calendar
            Workout_days_mc.MinDate = System.DateTime.Today.AddDays(-7);
            Workout_days_mc.MaxDate = System.DateTime.Today.AddDays(730);            
        }
        public void update_num_days_in_workout()
        {
            // set the current workspace workout_id, except for the first time when we initialize the form with no item selected
            if (Saved_Workouts_cb.SelectedIndex != -1)
            {                
                int this_workout_id = Convert.ToInt32(Saved_Workouts_cb.SelectedValue);
                DataTable workouts = (DataTable)Saved_Workouts_cb.DataSource;
                DataRow selected_exercise = workouts.Rows.Find(this_workout_id);
                num_days_in_workout = Convert.ToInt32(selected_exercise["num_days_in_workout"]);
                Number_days_in_workout_lbl.Text = "Number of Days in Workout: " + Convert.ToString(selected_exercise["num_days_in_workout"]);
                this.Text = "Schedule Workout: " + selected_exercise["name"];
                Workout_days_mc.MaxSelectionCount = num_days_in_workout;
            }
        }
    

        private void Schedule_button_Click(object sender, EventArgs e)
        {
            
            // insert dates into db


            // guessing here - what field to use as the start date for an event (even if one time event)?            
            // way one - bring into c#, then put into db
            DataTable workouts_to_schedule =
                Constants_class.db.GetDataTable("select workout_components_id, exercise_name as title, workout_exercise_id, " +                 
                "day_number from workout_components where workout_id = '" +
                Convert.ToInt32(Saved_Workouts_cb.SelectedValue) + "' order by " + " workout_components_id, exercise_order_daily");
            
            workouts_to_schedule.Columns.Add("dtstart");
            workouts_to_schedule.Columns.Add("dtend");
            workouts_to_schedule.Columns.Add("cal_id");
                       
            for (int i = 0; i < workouts_to_schedule.Rows.Count; i++)
            {
                //workouts_to_schedule.Rows[i]["dtstart"] = 
                DateTime start_date = Workout_days_mc.SelectionRange.Start.AddDays(Convert.ToDouble(workouts_to_schedule.Rows[i]["day_number"]) - 1);

                int event_dt = int.Parse(start_date.ToString("yyyyMMdd"));

                workouts_to_schedule.Rows[i]["dtstart"] = event_dt;
                workouts_to_schedule.Rows[i]["dtend"] = event_dt;

                    //Workout_days_mc.SelectionRange.Start.AddDays(Convert.ToDouble(workouts_to_schedule.Rows[i]["day_number"]));
                workouts_to_schedule.Rows[i]["cal_id"] = Constants_class.cal_id;
            }
            // remove this. we needed this to get the date range and number of days in workout, but dont want to insert this into db.5
            workouts_to_schedule.Columns.Remove("day_number");

            // sample. Put this into descrption - list the workout name and all of the lifts
            /*
            Friday\, June 07\, 2013 3:00 PM-3:30 PM (UTC-05:00) Easte
	rn Time (US & Canada).\nWhere: Kevin/Scott call Margaux\n\nNote: The GMT o
	ffset above does not reflect daylight saving time adjustments.\n\n*~*~*~*~
	*~*~*~*~*~*\n\nHi Margaux and Scott\,\n\nI thought it might be useful to r
	eserve some time to catch up on the drill down and AF tasks given everyone
	’s busy schedules. Let’s start off meeting by weekly and we can change
	 the frequency to weekly once things really get going. This will be a good
	 time for us to ask questions of each other and find out what we need to d
	o to keep the task on schedule. \n 
        */

            Constants_class.db.bulk_insert("cal_events", workouts_to_schedule, true);



            // way two - do all in db - don't bring the data from SQL to C# for processing - 
                /// 1. dont do it at all
                /// 2. log, then update from c#
            // insert (#columns, event_start), or join

            this.Close();
        }

        private void Saved_Workouts_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_num_days_in_workout();                                         
        }

        // make it so selecting one date selects that date plus the rest of the dates
        private void Workout_days_mc_DateSelected(object sender, EventArgs e)
        {
            if (Workout_days_mc.SelectionStart.AddDays(num_days_in_workout - 2) < Workout_days_mc.MaxDate)
            {
                Workout_days_mc.SelectionEnd = Workout_days_mc.SelectionStart.AddDays(num_days_in_workout - 1);
            }
            else MessageBox.Show("The end date of this workout is beyond the maximum schedulable limit.");
        }

        /*
         * string sql_to_get_details = "select workout_components.*, workout_days.SETS, workout_days.REPS1, workout_days.REPS2, " +
                                        "workout_days.REPS3, workout_days.REPS4, workout_days.REPS5, workout_days.Weight1," +
                                        "workout_days.Weight2, workout_days.Weight3, workout_days.Weight4, workout_days.Weight5, " +
                                        " workout_days.Rest1, workout_days.Rest2, workout_days.Rest3, workout_days.Rest4" +
                                         "FROM workout_components left join WORKOUT_DAYS on "+ 
                                         "workout_components.workout_exercise_id = workout_days.Workout_Exercise_ID " +
                                         "where workout_components.workout_id = '' ";
            DataTable exercises_to_insert = Constants.Constants_class.db.GetDataTable(sql_to_get_details);
         * */
    }
}
