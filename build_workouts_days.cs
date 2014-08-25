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
using MyLife;

//using System.Data.DataRowExtensions;

// use a list instead of a datatable/dataset (or, in addition to?)


// you cant just blindly use Max for exercise id....

// use a user control for every exercise instead of a massive datatable?



namespace MyLife
{

    public partial class Build_workouts_days : Form
    {
        // why are there multiple datatables.....this is dumb.
        public  DataSet excercise_ds = new DataSet();
        public  DataTable exercises_dt = new DataTable();
        public  DataTable details_dt = new DataTable();

        public void make_ds()
        {        
            //exercises_dt.Columns.Add("Unique_ID", typeof(string));

            exercises_dt.Columns.Add("exercise_unique_ID", typeof(Int32));
            exercises_dt.Columns["exercise_unique_ID"].AutoIncrement = true;

            exercises_dt.Columns.Add("Workout_Name", typeof(string));
            exercises_dt.Columns.Add("ListBox", typeof(string));
            exercises_dt.Columns.Add("Exercise_Name", typeof(string));
            exercises_dt.Columns.Add("Exercise_order", typeof(Int32));
            
            exercises_dt.Columns.Add("Date_Day_Created", typeof(DateTime));
            exercises_dt.Columns.Add("workout_day1Name", typeof(string));
            exercises_dt.Columns.Add("workout_day2Name", typeof(string));
            exercises_dt.Columns.Add("workout_day3Name", typeof(string));
            exercises_dt.Columns.Add("workout_day4Name", typeof(string));
            exercises_dt.Columns.Add("workout_day5Name", typeof(string));


            details_dt.Columns.Add("Workout_Name", typeof(string));
            details_dt.Columns.Add("exercise_unique_ID", typeof(Int32));
            details_dt.Columns["exercise_unique_ID"].AutoIncrement = true;
            //details_dt.Columns.Add("this_workout_unique_id", typeof(string));
            //details_dt.Columns["this_workout_unique_id"].AutoIncrement = true;
            details_dt.Columns.Add("Exercise_Name", typeof(string));
            details_dt.Columns.Add("Weight_as_pct_e1rm_cb", typeof(bool));
            details_dt.Columns.Add("workout_day_name", typeof(string));
            details_dt.Columns.Add("Exercise_order", typeof(Int32));

            details_dt.Columns.Add("Sets", typeof(decimal));

            details_dt.Columns.Add("Reps1", typeof(Int32));
            details_dt.Columns.Add("Reps2", typeof(Int32));
            details_dt.Columns.Add("Reps3", typeof(Int32));
            details_dt.Columns.Add("Reps4", typeof(Int32));
            details_dt.Columns.Add("Reps5", typeof(Int32));

            details_dt.Columns.Add("Weight1", typeof(double));
            details_dt.Columns.Add("Weight2", typeof(double));
            details_dt.Columns.Add("Weight3", typeof(double));
            details_dt.Columns.Add("Weight4", typeof(double));
            details_dt.Columns.Add("Weight5", typeof(double));

            details_dt.Columns.Add("Rest1", typeof(double));
            details_dt.Columns.Add("Rest2", typeof(double));
            details_dt.Columns.Add("Rest3", typeof(double));
            details_dt.Columns.Add("Rest4", typeof(double));

            excercise_ds.Tables.Add(exercises_dt);
            excercise_ds.Tables.Add(details_dt);
            
        }

        public Build_workouts_days()
        {                        
            InitializeComponent();
            WRKAnalysisListBox.DataSource = helperfns.simple_listbox_populater_distinct("Name", "Name", "Exercise_logs");
            // call function to build the full tables
            make_ds();
            //DataRow row = exercises_dt.NewRow();
            //row["workout_id"] = Convert.ToInt32(Constants_class.db.ExecuteScalar("select max(workout_id) from workout")) + 1;
            //exercises_dt.Rows.Add(row);
        }

        // the workout bank. this allows us to drop outof it basically//
        private void WRKAnalysisListBox_MouseDown(object sender, MouseEventArgs e)
        {
            helperfns.Mousedown_LB_make_drag_outable(sender, e, WRKAnalysisListBox, this);           
        }

        // when we click on an item in one of our days //
        private void ListBox_MouseDown(object sender, MouseEventArgs e )
        {
            {
                
                    ListBox listbox = (ListBox)sender;
                int index = listbox.IndexFromPoint(e.X, e.Y);
                if (index == -1 || listbox.Items.Count == 0 || listbox.Items[index] == null)
                    return;
                string selected_exercise = listbox.Items[index].ToString();

                // what to do when an item is selected
                // load everything for the panel
                Exercise_Getting_Details_label.Text = selected_exercise;
                
                // if we wantt o move the panel when an item is selected uncomment this code
                DetailsPanel.Location = new System.Drawing.Point(510, listbox.Location.Y);                
                DetailsPanel.Size = new System.Drawing.Size(343, 278);
                // not sure if this actually works
                DetailsPanel.TabIndex = listbox.TabIndex + 1;

                // this works but is stupid as hell. converts an int to a string, then back to an int....
                // .First() doesn't work without the ToString. equivalent?
                String tmp_fixthis = (from myRow in exercises_dt.AsEnumerable()
                                    where myRow.Field<string>("Exercise_Name") == selected_exercise &
                                         myRow.Field<int>("Exercise_order") == index &
                                         myRow.Field<string>("ListBox") == listbox.Name
                                    select myRow.Field<int>("exercise_unique_ID").ToString()).First();

                int exercise_unique_ID = Convert.ToInt32(tmp_fixthis);
                current_unq_id.exercise_unique_ID = exercise_unique_ID;

                //MessageBox.Show(Convert.ToString(exercise_unique_ID));
                
                /*if(exercises_dt.Columns["Exercise_Name"][index] == selected_exercise &
                    exercises_dt.Columns["Exercise_order"][index] == index &
                    exercises_dt.Columns["ListBox"][index] == listbox.Name)
                {
                    int this_exercise_id = exercises_dt.Columns["exercise_unique_ID"];
                }*/
                // when we click on a day, we want to update the form with the values we have
                // already input. We've set this to nothing to start with, so if we haven't input that 
                //  will not be a problem.d
                /*int exercise_unique_ID = index;*/

                SetsUD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Sets"]);// [exercise_unique_ID];
                Reps1UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Reps1"]);// [exercise_unique_ID];
                Reps2UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Reps2"]);// [exercise_unique_ID];
                Reps3UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Reps3"]);// [exercise_unique_ID];
                Reps4UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Reps4"]);// [exercise_unique_ID];
                Reps5UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Reps5"]);//[exercise_unique_ID];
                ExerciseDetailsPanel.Weight_as_pct_e1rm_cb.Checked = Convert.ToBoolean(details_dt.Rows[exercise_unique_ID]["Weight_as_pct_e1rm_cb"]);
                Weight1UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Weight1"]);//[exercise_unique_ID];
                Weight2UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Weight2"]);//[exercise_unique_ID];
                Weight3UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Weight3"]);//[exercise_unique_ID];
                Weight4UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Weight4"]);//[exercise_unique_ID];
                Weight5UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Weight5"]);//[exercise_unique_ID];
                Rest1UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Rest1"]);// [exercise_unique_ID];
                Rest2UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Rest2"]);//[exercise_unique_ID];
                Rest3UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Rest3"]);//[exercise_unique_ID];
                Rest4UD.Value = Convert.ToDecimal(details_dt.Rows[exercise_unique_ID]["Rest4"])    ;//[exercise_unique_ID];
            }
        }

        // when you drop an item onto a day //
        public void add_exercise_localDT(object sender, DragEventArgs e, ListBox day_listbox)
        {
            // if we dropped something
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                // create a new row for this exercise in the exercises_dt dataTable
                // unique id row is autoincremented as an integer.
                DataRow new_row = exercises_dt.NewRow();
                                              
                // then add the workout name to this same row.                                
                //new_row["Workout_Name"] = WorkoutNameTextBox.Text;

                // then add the exercise name of what you've just dragdropped, to the dataset.                
                new_row["Exercise_Name"] = str;
                new_row["Exercise_order"] = day_listbox.Items.Count - 1; // not sure if this is right *** ////////////
                new_row["Listbox"] = day_listbox.Name;                

                // add this new row to the exercises table
                exercises_dt.Rows.Add(new_row);

                //  Then prepare this for the details dataset
                // get the biggest unique id
                int max_exercises_unique_id = int.MinValue;
                foreach (DataRow dr in exercises_dt.Rows)
                {
                    int this_id = dr.Field<int>("exercise_unique_ID");
                    max_exercises_unique_id = Math.Max(max_exercises_unique_id, this_id);
                }                
                //MessageBox.Show((max_exercises_unique_id.ToString()));
                // we dont need to update exercise_unique_id, cuz it auto increments //
                
                DataRow new_detail_row = details_dt.NewRow();
                // assign this rows id to 1 more than the max
                new_detail_row["exercise_unique_ID"] = max_exercises_unique_id;
                //new_detail_row["Workout_Name"] = WorkoutNameTextBox.Text;                                
                
                new_detail_row["Exercise_Name"] = str;
                // give everything a blank value or default value
                new_detail_row["Sets"] = 1;
                new_detail_row["Reps1"] = 1;
                new_detail_row["Reps2"] = 0;
                new_detail_row["Reps2"] = 0;
                new_detail_row["Reps3"] = 0;
                new_detail_row["Reps4"] = 0;
                new_detail_row["Reps5"] = 0;
                new_detail_row["weight_as_pct_e1rm_cb"] = true;
                new_detail_row["Weight1"] = 1;
                new_detail_row["Weight2"] = 0;
                new_detail_row["Weight3"] = 0;
                new_detail_row["Weight4"] = 0;
                new_detail_row["Weight5"] = 0;
                new_detail_row["Rest1"] = 0;
                new_detail_row["Rest2"] = 0;
                new_detail_row["Rest3"] = 0;
                new_detail_row["Rest4"] = 0;
                new_detail_row["Exercise_order"] = day_listbox.Items.Count - 1; // not sure if this is right *** ////////////

                // get the name of the workout day associated with this               
                string workout_day_name = "";
                switch (day_listbox.Name)
                {
                    case "Day1ListBox": workout_day_name = Day1NameTextBox.Text; break;
                    case "Day2ListBox": workout_day_name = Day2NameTextBox.Text; break;
                    case "Day3ListBox": workout_day_name = Day3NameTextBox.Text; break;
                    case "Day4ListBox": workout_day_name = Day4NameTextBox.Text; break;
                    case "Day5ListBox": workout_day_name = Day5NameTextBox.Text; break;
                }

                new_detail_row["Workout_day_name"] = workout_day_name;

                details_dt.Rows.Add(new_detail_row);

                ///////// add the exercise order from above to the new_detail_row too. this is the order within the box
                // protects if they add the same lift multiple times in the same day
            }
        }



 
        private void SaveAndClose_Click(object sender, EventArgs e)
        {
              
            try
            {                                   
                // upload all of the days and the lifts and their details

                // if we need to, store the weight as % 1 rep max. otherwise, 
                double e1rm_or_1 = 1;
                //if (ExerciseDetailsPanel.weight_as_pct_e1rm_rb.Checked == true)
                if ((bool)details_dt.Rows[0]["Weight_as_pct_e1rm_cb"] == true)    //ExerciseDetailsPanel.Weight_as_pct_e1rm_cb.Checked == true)
                {
                    e1rm_or_1 = Convert.ToDouble(
                                                 Constants_class.db.ExecuteScalar(
                                                      "select epley_e1rm from exercises where name = '"
                                                      + details_dt.Rows[0]["Exercise_Name"].ToString() + "'")
                                                );
                }

                for (int i = 0; i < details_dt.Rows.Count; i++)
            {
                Dictionary<String, string> exercise_day_details = new Dictionary<string, string>();
                //exercise_day_details.Add("Date_Day_Created", "2012-03-12");
                exercise_day_details.Add("Date_Day_Created", DateTime.Now.ToString("yyyy-MM-dd"));
                exercise_day_details.Add("Name", details_dt.Rows[i]["Exercise_Name"].ToString());
                exercise_day_details.Add("Workout_day_name", details_dt.Rows[i]["workout_day_name"].ToString());
                exercise_day_details.Add("Exercise_order", details_dt.Rows[i]["Exercise_order"].ToString());
                exercise_day_details.Add("Sets", details_dt.Rows[i]["Sets"].ToString());
                exercise_day_details.Add("Reps1", details_dt.Rows[i]["Reps1"].ToString());
                exercise_day_details.Add("Reps2", details_dt.Rows[i]["Reps2"].ToString());
                exercise_day_details.Add("Reps3", details_dt.Rows[i]["Reps3"].ToString());
                exercise_day_details.Add("Reps4", details_dt.Rows[i]["Reps4"].ToString());
                exercise_day_details.Add("Reps5", details_dt.Rows[i]["Reps5"].ToString());

                exercise_day_details.Add("Weight1", ((Double)details_dt.Rows[i]["Weight1"] * e1rm_or_1).ToString());
                exercise_day_details.Add("Weight2", ((Double)details_dt.Rows[i]["Weight2"] * e1rm_or_1).ToString());
                exercise_day_details.Add("Weight3", ((Double)details_dt.Rows[i]["Weight3"] * e1rm_or_1).ToString());
                exercise_day_details.Add("Weight4", ((Double)details_dt.Rows[i]["Weight4"] * e1rm_or_1).ToString());
                exercise_day_details.Add("Weight5", ((Double)details_dt.Rows[i]["Weight5"] * e1rm_or_1).ToString());                                
                    
                exercise_day_details.Add("Rest1", details_dt.Rows[i]["Rest1"].ToString());
                exercise_day_details.Add("Rest2", details_dt.Rows[i]["Rest2"].ToString());
                exercise_day_details.Add("Rest3", details_dt.Rows[i]["Rest3"].ToString());
                exercise_day_details.Add("Rest4", details_dt.Rows[i]["Rest4"].ToString());

                // upload this record to the permanent db
                Constants_class.db.Insert("Workout_Days", exercise_day_details, false);
                this.Close();
            } 
                
            }

            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }


        private void DetailsPanel_Leave(object sender, EventArgs e)
        {            
            // when we leave the details panel, we write the values in the panel to the temp dataset
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Sets"] = SetsUD.Value; // [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Reps1"] = Reps1UD.Value; // [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Reps2"] = Reps2UD.Value;// [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Reps3"] = Reps3UD.Value;// [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Reps4"] = Reps4UD.Value;// [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Reps5"] = Reps5UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight_as_pct_e1rm_cb"] = ExerciseDetailsPanel.Weight_as_pct_e1rm_cb.CheckState;
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight1"] = Weight1UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight2"] = Weight2UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight3"] = Weight3UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight4"] = Weight4UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Weight5"] = Weight5UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Rest1"] = Rest1UD.Value;  // [exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Rest2"] = Rest2UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Rest3"] = Rest3UD.Value;//[exercise_unique_ID];
            details_dt.Rows[current_unq_id.exercise_unique_ID]["Rest4"] = Rest4UD.Value;//[exercise_unique_ID];
            

            // and reset everything in the panel to their minimum values
            SetsUD.Value = SetsUD.Minimum;
            Reps1UD.Value = Reps1UD.Minimum;
            Reps2UD.Value = Reps2UD.Minimum;
            Reps3UD.Value = Reps3UD.Minimum;
            Reps4UD.Value = Reps4UD.Minimum;
            Reps5UD.Value = Reps5UD.Minimum;
            Weight1UD.Value = Weight1UD.Minimum;
            Weight2UD.Value = Weight2UD.Minimum;
            Weight3UD.Value = Weight3UD.Minimum;
            Weight4UD.Value = Weight4UD.Minimum;
            Weight5UD.Value = Weight5UD.Minimum;
            Rest1UD.Value = Rest1UD.Minimum;
            Rest2UD.Value = Rest2UD.Minimum;
            Rest3UD.Value = Rest3UD.Minimum;
            Rest4UD.Value = Rest4UD.Minimum;
        }

        private void Day1NameTextBox_TextChanged(object sender, EventArgs e)
        {
            helperfns.enable_listbox(sender, e, Day1ListBox);
        }

        private void Day2NameTextBox_TextChanged(object sender, EventArgs e)
        {
            helperfns.enable_listbox(sender, e, Day2ListBox);
        }

        private void Day3NameTextBox_TextChanged(object sender, EventArgs e)
        {
            helperfns.enable_listbox(sender, e, Day3ListBox);
        }

        private void Day4NameTextBox_TextChanged(object sender, EventArgs e)
        {
            helperfns.enable_listbox(sender, e, Day4ListBox);
        }

        private void Day5NameTextBox_TextChanged(object sender, EventArgs e)
        {
            helperfns.enable_listbox(sender, e, Day5ListBox);
        }
        // generalize this...
        private void TextBox_TextChanged(object sender, EventArgs e)
        { }

        private void DayListBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox LB = (ListBox)sender;
            LB.Items.Add(helperfns.listBox_DragDrop(LB, e));
            add_exercise_localDT(LB, e, Day1ListBox);
        }

        private void DayListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
    public static class current_unq_id
    {
        public static int exercise_unique_ID = new int();
    }

}
