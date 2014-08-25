using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;
using ConsoleApplication1.WindowsFormsApplication3;
using MyLife;

// Make sure when we create the clear-day button and/or implement deleting that if we delete all of the exercises from a day
// that we put rest day back in there, and more importantly we reassign the tag of Rest Day to the day.

// this table has one key. That needs to be renamed to be unique to days. And, it needs another key to be added that is
// a foreign key to the overall exercises bank

/// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/// !!!!!!!! this could easily be redone to allow it to work generically for exercises and me !!
/// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

namespace MyLife
{
    public partial class Day_to_schedule : UserControl
    {
        public Day_to_schedule()
        {
            InitializeComponent();
        }

        public Day_to_schedule(int day_num)
        {
            InitializeComponent();
            Day_number_label.Text += Convert.ToString(day_num);
            Saved_days_CB.DisplayMember = "workout_day_name";
            // populate the saved days dropdown combobox with all available days
            Saved_days_CB.DataSource = Constants_class.db.GetDataTable("Select distinct workout_day_name from workout_days");
            
            Saved_days_CB.SelectedIndex = -1;
            // make it so when you change it, the event fires5
            Saved_days_CB.SelectedIndexChanged += new System.EventHandler(Saved_days_CB_SelectedIndexChanged);
            initialize_to_rest_day();
        }
        // sets to initial rest day
        public void initialize_to_rest_day()
        {
            // initialize so the default is Rest Day
            DataTable rest_day = new DataTable();
            rest_day.Columns.Add("Workout_Exercise_ID");
            rest_day.Columns.Add("exercise_name");
            rest_day.Columns.Add("exercise_order");
            rest_day.Rows.Add();

            rest_day.Rows[0]["Workout_Exercise_ID"] = -1;
            rest_day.Rows[0]["exercise_name"] = "Rest Day";

            Days_LB.ValueMember = "Workout_Exercise_ID";
            Days_LB.DisplayMember = "exercise_name";
            Days_LB.DataSource = rest_day;
            Days_LB.SelectedIndex = -1;
        }

        // clears the day button
        public void clear_Days_LB()
        {
            if (Days_LB.DataSource != null)
            {                
                Days_LB.DataSource = null;
            }
            else
            {
                Days_LB.Items.Clear();  
            }
            initialize_to_rest_day();
        }

        // when you change the dropdown to pick a saved day
        private void Saved_days_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear whatever is currently in the day
            clear_Days_LB();

            // assign the exercises from the saved day to this day
            string sql = "Select Workout_Exercise_ID, name as exercise_name, exercise_order from workout_days where workout_day_name = '" + Saved_days_CB.Text + "'";
            DataTable this_days_exercises = Constants_class.db.GetDataTable(sql);
                                         
            // make this dataTable the datasource, and set the value and display members
            Days_LB.DataSource = this_days_exercises;

            Days_LB.ValueMember = "Workout_Exercise_ID";
            Days_LB.DisplayMember = "exercise_name";
            Days_LB.SelectedIndex = -1;
        }

        private void Clear_day_button_Click(object sender, EventArgs e)
        {
            clear_Days_LB();
        }

        private void Days_LB_DragDrop(object sender, DragEventArgs e)
        {
            // get the current data source as a data table
            DataTable exercises = (DataTable)Days_LB.DataSource;

            // if the day is blank or set as a Rest Day
            if (exercises == null || exercises.Rows[0]["exercise_name"].ToString() == "Rest Day")
            {
                exercises = new DataTable();
                exercises.Columns.Add("Workout_Exercise_ID");
                exercises.Columns.Add("exercise_name");
                exercises.Columns.Add("exercise_order");
                Days_LB.Tag = "Non Rest Day";
            }

            // add the item we just dropped to that datatable
            DataRow this_exercise = exercises.NewRow();

            // get the item we just dragdropped. We want to assign this a negative workout_exercise_id, because it is not part of a day
            // then, later when we retrieve the details from that table (day table) this exercise won't be found and the details won't be
            // searched for. This allows workout_exercise_id to be nonnull. We do need them to be distinct as well, so multiplication and addition
            // are used together just to create a distinct negative number.
            this_exercise["Workout_Exercise_ID"] = -1 * exercises.Rows.Count;
            this_exercise["exercise_name"] = helperfns.listBox_DragDrop(sender, e);
            this_exercise["exercise_order"] = exercises.Rows.Count;
            exercises.Rows.Add(this_exercise);

            // assign the full dataTable to the days_Lb after clearing it out
            clear_Days_LB();
            Days_LB.ValueMember = "Workout_Exercise_ID";
            Days_LB.DisplayMember = "exercise_name";

            Days_LB.DataSource = exercises;
            Days_LB.SelectedIndex = -1;
        }

        private void Save_day_button_Click(object sender, EventArgs e)
        {
            // open the form to build a day
        }

        private void Days_LB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        // allow public access to the copy_day_button and exercises listbox
        public Button Get_Copy_day_button { get { return this.Copy_day_button; } }
        public Button Get_Save_day_button { get { return this.Save_day_button; } }
        public Button Get_Clear_day_button { get { return this.Clear_day_button; } }
        public ListBox Get_Days_LB { get { return this.Days_LB; } }
        public Label Get_Saved_days_label { get { return this.Saved_days_label; } }
        public ComboBox Get_Saved_days_CB { get { return this.Saved_days_CB; } }

        
        
    }
}
