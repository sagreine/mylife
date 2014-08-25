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
using System.Data.SqlClient;
using Constants;
using System.Data.SQLite;

// sketched out workout_id identifying here....

namespace MyLife
{
    public partial class Workout_info : Form
    {
        public Workout_info()
        {
            InitializeComponent();
        }

        private void Build_workout_button_Click(object sender, EventArgs e)
        {


            // pass all of the data to the build workouts form
            Dictionary<string, object> dt_with_workout_inf = new Dictionary<string, object>();
            
            dt_with_workout_inf.Add("workout_name", WorkoutNameTextBox.Text);
            dt_with_workout_inf.Add("focus", Workout_focus_CB.Text);
            dt_with_workout_inf.Add("num_weeks", Number_weeks_NUD.Value);
            dt_with_workout_inf.Add("num_days_in_workout", Number_weeks_NUD.Value * 7);
            dt_with_workout_inf.Add("workout_id",helperfns.get_Max_value("workout_id", "workouts"));

            // insert this workout into the db - dont use built in insert function because this is not a string, string dictionary
            string sql = " insert into workouts(name, num_days_in_workout,focus) " +
                  "values('" + WorkoutNameTextBox.Text + "', " + Number_weeks_NUD.Value * 7 + ",'" + Workout_focus_CB.Text + "'  )";
            Constants.Constants_class.db.ExecuteScalar(sql);

            // parameterized
            /*SQLiteConnection conn = new SQLiteConnection(Constants_class.db.dbConnection);
            SQLiteCommand cmd = new SQLiteCommand("insert into workouts(name, num_days_in_workout) values ('@name', '@num_days_in_workout')", conn);
            SQLiteParameter name = new SQLiteParameter();
            name.ParameterName = "@name";
            SQLiteParameter num_days_in_workout = new SQLiteParameter();
            num_days_in_workout.ParameterName = "@num_days_in_workout";
            //param.Value = inputCity;
            cmd.Parameters.Add(name);
            cmd.Parameters.Add(num_days_in_workout);
            conn.*/

            build_workouts workout = new build_workouts(dt_with_workout_inf);
            //this.Hide();
            //build_workouts workout = new build_workouts(Convert.ToInt16(Number_weeks_NUD.Value));
            workout.Show();  
            
        }
    }
}
