using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// need to address what happens when you uncheck a day to copy - set it back to the default color of the checkbox's parent (not the default of
// all controls overall)

namespace MyLife
{
    public partial class Copy_days : Form
    {
        public Copy_days(DataTable all_exercises, DataTable all_weeks_and_days)
        {
            InitializeComponent();            

            // get the distinct weeks
            DataView view = new DataView(all_weeks_and_days);
            DataTable distinctWeeks = view.ToTable(true, "week_name");
            int num_weeks = distinctWeeks.Rows.Count;

            // set the top of the thing, so that we have the day we selected by itself. also, adjust the day that is being copied
            DataRow[] exercise_to_copy = all_exercises.Select("this_is_day_to_copy = true");
            DataTable all_exercises_to_copy = exercise_to_copy.CopyToDataTable();

            // update the class-wide datatable to the parameter datatable, so it can be used by the button click method.
            exercises_to_copy = all_exercises_to_copy;
            

            string week_to_copy = all_exercises_to_copy.Rows[0]["week_name"].ToString();
            string day_to_copy = all_exercises_to_copy.Rows[0]["day_name"].ToString();


            //add each exercise from this day to the list of ones we choose to copy or not;
            for (int i = 0; i < all_exercises_to_copy.Rows.Count; i++)
            {
                Copy_exercises_DG.Rows.Add();
                Copy_exercises_DG.Rows[i].Cells["exercise_name"].Value = all_exercises_to_copy.Rows[i]["exercise_name"].ToString();

                // set each row check by default
                Copy_exercises_DG.Rows[i].Cells["Copy_exercise_DG_YN"].Value = true;
            }
            
            for (int week_num = 0; week_num < num_weeks; week_num++)
            {
                // add the weeks to the form
                Week_to_schedule this_week = new Week_to_schedule(week_num);
                this_week.Name = string.Format("Week {0}", week_num);
                weeks_panel.Controls.Add(this_week);

                // shrink the vertical height of the week
                this_week.Size = new Size(945, 250);
                this_week.Location = new Point(0, week_num * this_week.Size.Height + 1);

                // we want to change the header panel for this control so it doesn't look like the week we are copying
                this_week.Get_Header_Panel.Controls["Saved_weeks_label"].Text = "Select Day(s) to Copy Exercises to";                
                // make the font of this label bigger
                this_week.Get_Header_Panel.Controls["Saved_weeks_label"].Font =
                     new Font(this_week.Get_Header_Panel.Controls["Saved_weeks_label"].Font.FontFamily, 14F, this_week.Get_Header_Panel.Controls["Saved_weeks_label"].Font.Style);
                
                this_week.Get_Header_Panel.Controls["Saved_weeks_label"].Size = new System.Drawing.Size(750, 30);

                // hide the buttons and dropdown
                this_week.Get_Header_Panel.Controls["Saved_weeks_CB"].Visible = false;
                this_week.Get_Header_Panel.Controls["Copy_week_button"].Visible = false;
                this_week.Get_Header_Panel.Controls["Save_week_button"].Visible = false;
                this_week.Get_Header_Panel.Size = new Size(945,75);
                
                // Customize the days that show up.
                foreach (var this_day in this_week.Controls.OfType<Day_to_schedule>())
                {
                    /// Make many of the default options invisible (hint hint, make a new usercontrol at this point dude)
                    this_day.Get_Saved_days_label.Visible = false;
                    this_day.Get_Saved_days_CB.Visible = false;

                    this_day.Get_Copy_day_button.Visible = false;
                    this_day.Get_Save_day_button.Visible = false;
                    this_day.Get_Clear_day_button.Visible = false;
                    ///
                    // shrink the day vertically, because we hid a bunch of controls
                    this_day.Size = new Size(134,200);

                    // Add a new checkbox
                    CheckBox to_copy_checkbox = new CheckBox();
                    to_copy_checkbox.CheckedChanged += new EventHandler(to_copy_checkbox_CheckedChanged);
                    to_copy_checkbox.Name = "to_copy_checkbox";
                    to_copy_checkbox.Location = new Point(23, 167);
                    to_copy_checkbox.Text = "Copy To Day";                    
                    this_day.Controls.Add(to_copy_checkbox);
                    

                    // if this isn't the day we are copying
                    if (this_week.Name != week_to_copy || this_day.Name != day_to_copy)
                    {
                        // populate the list box with all of the exercises from this day on the previous form
                        DataRow[] rows_of_exercises = all_exercises.Select("week_name = '" + this_week.Name +
                                                                     "' and day_name = '" + this_day.Name + "'");
                        DataTable this_days_exercises = rows_of_exercises.CopyToDataTable();
                        //this_days_exercises = new DataTable();
                        this_day.Get_Days_LB.DataSource = null;

                        this_day.Get_Days_LB.DataSource = this_days_exercises;
                        this_day.Get_Days_LB.ValueMember = "workout_exercise_id";
                        this_day.Get_Days_LB.DisplayMember = "exercise_name";
                        this_day.Get_Days_LB.SelectedIndex = -1;
                        this_day.Get_Days_LB.Enabled = false;
                    }
                    else // if this is the day we are copying
                    {
                        to_copy_checkbox.Enabled = false;
                        
                        // put a custom set of items into the listbox, to show this day is being copied
                        this_day.Get_Days_LB.DataSource = null;
                        DataTable day_to_copy_dt = new DataTable();
                        day_to_copy_dt.Columns.Add("Display");
                        day_to_copy_dt.Rows.Add();
                        day_to_copy_dt.Rows.Add();
                        day_to_copy_dt.Rows.Add();
                        day_to_copy_dt.Rows.Add();
                        day_to_copy_dt.Rows[0]["Display"] = "";
                        day_to_copy_dt.Rows[1]["Display"] = "";
                        day_to_copy_dt.Rows[2]["Display"] = "";
                        day_to_copy_dt.Rows[3]["Display"] = "        Copied Day";

                        this_day.Get_Days_LB.DataSource = day_to_copy_dt;
                        this_day.Get_Days_LB.DisplayMember = "Display";
                        this_day.Get_Days_LB.Enabled = false;
                        this_day.Get_Days_LB.SelectedIndex = -1;
                    }
                }                
            }

                        
            // update the form title telling what workout it is and the title label
            this.Text = "Build Workout - Copy Days";                     
        }
        private DataTable exercises_to_copy;
        private DataTable DTC;
        public DataTable GetDaysToCopy { get { return DTC; } }
        public DataTable GetExercisesToCopy { get { return exercises_to_copy; } }
        //public static DataTable all_exercises_copying { get; set; }        

        private void to_copy_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked == true)
            {
                checkbox.Parent.BackColor = System.Drawing.Color.DarkBlue;
            }
            else
            {
                // need to change this part here
                checkbox.Parent.BackColor = Constants.Constants_class.week_days_background_color;
            }
        }
        private void Copy_to_days_button_Click(object sender, EventArgs e)
        {
            // instance of the datatable we will be returning that tells what days we want to copy to
            DTC = new DataTable();
            DTC.Columns.Add("week_name");
            DTC.Columns.Add("day_name");

            // for every exercise in the list of exercises in the day we are copying (that we got as param to build this form)
            for (int i = exercises_to_copy.Rows.Count - 1; i > 0; i--)
            {                
                // if this exercise is not checked in the DataGridView above 
                if ((bool)Copy_exercises_DG.Rows[i].Cells[0].Value == false)
                {                    
                    // Remove the Row (from the all exercises table) that we will return as exercises we want to copy to other days
                    exercises_to_copy.Rows.Remove(exercises_to_copy.Rows[i]);
                }
            }

            // look through every day in every week, to see if that checkbox is selected. If it is, record the week_name
            // and day name.
            foreach (var this_week in weeks_panel.Controls.OfType<Week_to_schedule>())
            {                                                
                foreach (var this_day in this_week.Controls.OfType<Day_to_schedule>())
                {
                    CheckBox copying_this_day = (CheckBox)this_day.Controls["to_copy_checkbox"];
                    // if this is a day we are copying to, make a new row with the week and day name, and add it to the DT of days to copy
                    if (copying_this_day.Checked == true)
                    {
                        DataRow this_day_to_copy_to = GetDaysToCopy.NewRow();
                        this_day_to_copy_to["week_name"] = this_week.Name;
                        this_day_to_copy_to["day_name"] = this_day.Name;
                        GetDaysToCopy.Rows.Add(this_day_to_copy_to);
                    }
                }
            }
            this.Close();
        } 
    }    
}
