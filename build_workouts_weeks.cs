using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ConsoleApplication1.WindowsFormsApplication3;
using Constants;
using MyLife;

// add a regular Save button
// need to add a value that holds the order of the exercise_day in the weekday (use items.count or something) so that
// they are 100% unique in the static datatable


// need to address what happens if they have a day in there, then they add restday too. anythign or is it good how it is?

// need to really redo this with usercontrols probably
// err, also do the event handlers like a not idiot would



namespace MyLife
{
    public partial class build_workouts_weeks : Form
    {
        /*public void sort_dt_by_date()
        {

        }

        public void sort_dt_by_alpha()
        {

        }*/
        public build_workouts_weeks()
        {
            InitializeComponent();
            string sql ="Select distinct Workout_Day_Name, Date_Day_created, date_last_used from Workout_Days order by  Date_day_created desc";
            DataTable days = Constants_class.db.GetDataTable(sql);                        

            // if the most recently created day was created more than 10 days ago, re-order the Days, putting the most recently used day first
            if (( DateTime.Now - DateTime.Parse(days.Rows[0]["date_day_created"].ToString())).TotalDays > 10)
            {
                // create a temporary dataview, sort that, and then update the days datatable to be that sorted dataview
                DataView days_sorted = days.DefaultView;
                days_sorted.Sort = "Date_day_created";
                days = days_sorted.ToTable();
            }

            // build the list of workout days, with a Rest Day at the top
            List <string> workout_days_list = new List <string>();
            workout_days_list.Add("Rest Day");

            // add all of the workout days to the list of workout days + rest day in preparation of adding them to the listbox
            foreach (DataRow dr in days.Rows)
            {
                string workout_day_name = Convert.ToString(dr[0]);
                workout_days_list.Add(workout_day_name);
            }            
            workout_days_LB.DataSource = workout_days_list;           
        }
        public void clear_details_lb()
        {
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
        public void update_details_LB(object sender, MouseEventArgs e)
        {

        // error checking to be sure we have clicked on an item
            int index = workout_day_exercises_LB.IndexFromPoint(e.X, e.Y);
            if (index == -1 || workout_day_exercises_LB.Items.Count == 0 || workout_day_exercises_LB.Items[index] == null)
                return;

            //string abc = workout_days_LB.SelectedItem.lift_name.ToString();
            string sql = "Select name, sets, reps1, reps2, reps3, reps4, reps5, weight1, weight2, weight3, weight4, weight5," +
                                      "rest1, rest2, rest3, rest4" +
                          " from workout_days where workout_day_name = '" + workout_days_LB.SelectedItem.ToString() + "' and name ='" +
                           workout_day_exercises_LB.Text + "' and exercise_order = '" + workout_day_exercises_LB.SelectedValue.ToString() + "'";
            ///////// need to create this, pull from workout_days table
            DataTable this_exercises_details = Constants_class.db.GetDataTable(sql);

            // clear all of the details
            clear_details_lb();

            if (this_exercises_details.Rows.Count > 0)
            {
                Exercise_Getting_Details_label.Text = workout_day_exercises_LB.Text;

                SetsUD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Sets"]);
                Reps1UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Reps1"]);
                Reps2UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Reps2"]);
                Reps3UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Reps3"]);
                Reps4UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Reps4"]);
                Reps5UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Reps5"]);
                Weight1UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Weight1"]);
                Weight2UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Weight2"]);
                Weight3UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Weight3"]);
                Weight4UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Weight4"]);
                Weight5UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Weight5"]);
                Rest1UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Rest1"]);
                Rest2UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Rest2"]);
                Rest3UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Rest3"]);
                Rest4UD.Value = Convert.ToDecimal(this_exercises_details.Rows[0]["Rest4"]);
            }
        }
        
        private void each_day_LB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        // when we select on one of our saved workout days
        private void workout_days_LB_MouseDown(object sender, MouseEventArgs e)
        {
            helperfns.Mousedown_LB_make_drag_outable(sender, e, workout_days_LB, this);
            // fill out the lifts associated with this workout day into the box at the bottom
            if (string.IsNullOrEmpty(workout_days_LB.SelectedItem.ToString()) == false)
            {
                // need to account for the same lift in the workout multiple times
                DataTable this_days_lifts = Constants_class.db.GetDataTable("Select name as lift_name, exercise_order as lift_day_order from workout_days " +
                                         "where workout_day_name = '" + workout_days_LB.SelectedItem.ToString() + "' group by name, exercise_order"
                                                );

                // clear any datasource that may be there
                workout_day_exercises_LB.DataSource = null;

                workout_day_exercises_LB.DataSource = this_days_lifts;

                workout_day_exercises_LB.DisplayMember = "lift_name";
                workout_day_exercises_LB.ValueMember = "lift_day_order";

                // clear all of the details from the details box
                clear_details_lb();
                
                // deselect anything in the exercises list box
                workout_day_exercises_LB.SelectedIndex = -1;
            }
        }
        // when we click on one of our exercises
        private void workout_day_exercises_LB_MouseDown(object sender, MouseEventArgs e)
        {
            // update the details box
            update_details_LB(sender, e);
        }
        
        public DataTable all_listboxitems_to_dt(Control.ControlCollection cc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Week_name");
            dt.Columns.Add("Day_of_week");
            dt.Columns.Add("Workout_Day_name");
            dt.Columns.Add("Date_Week_created");

            foreach (Control ctrl in cc)
            {
                if (ctrl is ListBox & ctrl.Enabled == true)
                {
                    for (int i = 0; i < ((ListBox)ctrl).Items.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        int this_row_index = ((TableLayoutPanel)cc.Owner).GetRow(ctrl);
                        string this_row_name = "";
                        switch (this_row_index)
                        {
                            case 1: 
                                this_row_name = Week_1_Name_TB.Text;
                                break;
                            case 2:
                                this_row_name = Week_2_Name_TB.Text;
                                break;
                            case 3:
                                this_row_name = Week_3_Name_TB.Text;
                                break;
                            case 4:
                                this_row_name = Week_4_Name_TB.Text;
                                break;
                            case 5:
                                this_row_name = Week_5_Name_TB.Text;
                                break;
                            case 6:
                                this_row_name = Week_6_Name_TB.Text;
                                break;
                        }
                        dr["Week_name"] = this_row_name;
                        dr["Day_of_week"] = ((TableLayoutPanel)cc.Owner).GetColumn(ctrl);
                        dr["Workout_Day_name"] = ((ListBox)ctrl).Items[i].ToString();
                        dr["Date_Week_created"] = DateTime.Now.ToString("yyyy-MM-dd");
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

       

        private void SaveAndClose_Click(object sender, EventArgs e)
        {            
            Constants_class.db.bulk_insert("Workout_weeks",all_listboxitems_to_dt(tableLayoutPanel1.Controls),true);            
            helperfns.RecursiveClearControls(tableLayoutPanel1.Controls);
            this.Close();
        }


        // when we change the text, we want to enable the textboxs for the week. unless we've deleted everything, when we want to disable them.
        private void Week_1_Name_TB_TextChanged(object sender, EventArgs e)
        {
            // only enable it if it isn't already enabled and the text is null or empty. Note that the week-name-tb-enter 
            // event makes these textboxes empty.
            if (string.IsNullOrEmpty(Week_1_Name_TB.Text) == false & MON1_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON1_LB);
                helperfns.enable_listbox(sender, e, TUE1_LB);
                helperfns.enable_listbox(sender, e, WED1_LB);
                helperfns.enable_listbox(sender, e, THU1_LB);
                helperfns.enable_listbox(sender, e, FRI1_LB);
                helperfns.enable_listbox(sender, e, SAT1_LB);
                helperfns.enable_listbox(sender, e, SUN1_LB);
                // enable the next week's text box
                Week_2_Name_TB.Enabled = true;
            }
            // only disable it if it isn't already disabled and the text is empty (so, you deleted the week name)                
            else if (string.IsNullOrEmpty(Week_1_Name_TB.Text) == true & MON1_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON1_LB);
                helperfns.disable_listbox(sender, e, TUE1_LB);
                helperfns.disable_listbox(sender, e, WED1_LB);
                helperfns.disable_listbox(sender, e, THU1_LB);
                helperfns.disable_listbox(sender, e, FRI1_LB);
                helperfns.disable_listbox(sender, e, SAT1_LB);
                helperfns.disable_listbox(sender, e, SUN1_LB);
            }
        }
        private void Week_2_Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Week_2_Name_TB.Text) == false & MON2_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON2_LB);
                helperfns.enable_listbox(sender, e, TUE2_LB);
                helperfns.enable_listbox(sender, e, WED2_LB);
                helperfns.enable_listbox(sender, e, THU2_LB);
                helperfns.enable_listbox(sender, e, FRI2_LB);
                helperfns.enable_listbox(sender, e, SAT2_LB);
                helperfns.enable_listbox(sender, e, SUN2_LB);
                Week_3_Name_TB.Enabled = true;
            }
            else if (string.IsNullOrEmpty(Week_2_Name_TB.Text) == true & MON2_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON2_LB);
                helperfns.disable_listbox(sender, e, TUE2_LB);
                helperfns.disable_listbox(sender, e, WED2_LB);
                helperfns.disable_listbox(sender, e, THU2_LB);
                helperfns.disable_listbox(sender, e, FRI2_LB);
                helperfns.disable_listbox(sender, e, SAT2_LB);
                helperfns.disable_listbox(sender, e, SUN2_LB);

            }
        }
        private void Week_3_Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Week_3_Name_TB.Text) == false & MON3_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON3_LB);
                helperfns.enable_listbox(sender, e, TUE3_LB);
                helperfns.enable_listbox(sender, e, WED3_LB);
                helperfns.enable_listbox(sender, e, THU3_LB);
                helperfns.enable_listbox(sender, e, FRI3_LB);
                helperfns.enable_listbox(sender, e, SAT3_LB);
                helperfns.enable_listbox(sender, e, SUN3_LB);
                Week_4_Name_TB.Enabled = true;
            }
            else if (string.IsNullOrEmpty(Week_3_Name_TB.Text) == true & MON3_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON3_LB);
                helperfns.disable_listbox(sender, e, TUE3_LB);
                helperfns.disable_listbox(sender, e, WED3_LB);
                helperfns.disable_listbox(sender, e, THU3_LB);
                helperfns.disable_listbox(sender, e, FRI3_LB);
                helperfns.disable_listbox(sender, e, SAT3_LB);
                helperfns.disable_listbox(sender, e, SUN3_LB);
            }
        }
        private void Week_4_Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Week_4_Name_TB.Text) == false & MON4_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON4_LB);
                helperfns.enable_listbox(sender, e, TUE4_LB);
                helperfns.enable_listbox(sender, e, WED4_LB);
                helperfns.enable_listbox(sender, e, THU4_LB);
                helperfns.enable_listbox(sender, e, FRI4_LB);
                helperfns.enable_listbox(sender, e, SAT4_LB);
                helperfns.enable_listbox(sender, e, SUN4_LB);
                Week_5_Name_TB.Enabled = true;
            }
            else if (string.IsNullOrEmpty(Week_4_Name_TB.Text) == true & MON4_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON4_LB);
                helperfns.disable_listbox(sender, e, TUE4_LB);
                helperfns.disable_listbox(sender, e, WED4_LB);
                helperfns.disable_listbox(sender, e, THU4_LB);
                helperfns.disable_listbox(sender, e, FRI4_LB);
                helperfns.disable_listbox(sender, e, SAT4_LB);
                helperfns.disable_listbox(sender, e, SUN4_LB);
            }
        }
        private void Week_5_Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Week_5_Name_TB.Text) == false & MON5_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON5_LB);
                helperfns.enable_listbox(sender, e, TUE5_LB);
                helperfns.enable_listbox(sender, e, WED5_LB);
                helperfns.enable_listbox(sender, e, THU5_LB);
                helperfns.enable_listbox(sender, e, FRI5_LB);
                helperfns.enable_listbox(sender, e, SAT5_LB);
                helperfns.enable_listbox(sender, e, SUN5_LB);
                Week_6_Name_TB.Enabled = true;
            }
            else if (string.IsNullOrEmpty(Week_5_Name_TB.Text) == true & MON5_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON5_LB);
                helperfns.disable_listbox(sender, e, TUE5_LB);
                helperfns.disable_listbox(sender, e, WED5_LB);
                helperfns.disable_listbox(sender, e, THU5_LB);
                helperfns.disable_listbox(sender, e, FRI5_LB);
                helperfns.disable_listbox(sender, e, SAT5_LB);
                helperfns.disable_listbox(sender, e, SUN5_LB);
            }
        }
        private void Week_6_Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Week_6_Name_TB.Text) == false & MON6_LB.Enabled == false)
            {
                helperfns.enable_listbox(sender, e, MON6_LB);
                helperfns.enable_listbox(sender, e, TUE6_LB);
                helperfns.enable_listbox(sender, e, WED6_LB);
                helperfns.enable_listbox(sender, e, THU6_LB);
                helperfns.enable_listbox(sender, e, FRI6_LB);
                helperfns.enable_listbox(sender, e, SAT6_LB);
                helperfns.enable_listbox(sender, e, SUN6_LB);
            }
            else if (string.IsNullOrEmpty(Week_6_Name_TB.Text) == true & MON6_LB.Enabled == true)
            {
                helperfns.disable_listbox(sender, e, MON6_LB);
                helperfns.disable_listbox(sender, e, TUE6_LB);
                helperfns.disable_listbox(sender, e, WED6_LB);
                helperfns.disable_listbox(sender, e, THU6_LB);
                helperfns.disable_listbox(sender, e, FRI6_LB);
                helperfns.disable_listbox(sender, e, SAT6_LB);
                helperfns.disable_listbox(sender, e, SUN6_LB);
            }
        }
        private void Week_1_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_1_Name_TB, "Week 1 Name");
        }
        private void Week_2_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_2_Name_TB, "Week 2 Name");
        }
        private void Week_3_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_3_Name_TB, "Week 3 Name");
        }
        private void Week_4_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_4_Name_TB, "Week 4 Name");
        }
        private void Week_5_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_5_Name_TB, "Week 5 Name");
        }
        private void Week_6_Name_TB_Enter(object sender, EventArgs e)
        {
            helperfns.enter_tb_clear_ifstring(sender, e, Week_6_Name_TB, "Week 6 Name");
        }

        // update so we update the last_used_date here
        // make every day list box dragdroppable
        private void MON1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON1_LB.Items.Contains("Rest Day"))
            {
                MON1_LB.Items.Clear();
            }
            MON1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void MON2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON2_LB.Items.Contains("Rest Day"))
            {
                MON2_LB.Items.Clear();
            }
            MON2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void MON3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON3_LB.Items.Contains("Rest Day"))
            {
                MON3_LB.Items.Clear();
            }
            MON3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void MON4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON4_LB.Items.Contains("Rest Day"))
            {
                MON4_LB.Items.Clear();
            }
            MON4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void MON5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON5_LB.Items.Contains("Rest Day"))
            {
                MON5_LB.Items.Clear();
            }
            MON5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void MON6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (MON6_LB.Items.Contains("Rest Day"))
            {
                MON6_LB.Items.Clear();
            }
            MON6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE1_LB.Items.Contains("Rest Day"))
            {
                TUE1_LB.Items.Clear();
            }
            TUE1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE2_LB.Items.Contains("Rest Day"))
            {
                TUE2_LB.Items.Clear();
            }
            TUE2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE3_LB.Items.Contains("Rest Day"))
            {
                TUE3_LB.Items.Clear();
            }
            TUE3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE4_LB.Items.Contains("Rest Day"))
            {
                TUE4_LB.Items.Clear();
            }
            TUE4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE5_LB.Items.Contains("Rest Day"))
            {
                TUE5_LB.Items.Clear();
            }
            TUE5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void TUE6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (TUE6_LB.Items.Contains("Rest Day"))
            {
                TUE6_LB.Items.Clear();
            }
            TUE6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED1_LB.Items.Contains("Rest Day"))
            {
                WED1_LB.Items.Clear();
            }
            WED1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED2_LB.Items.Contains("Rest Day"))
            {
                WED2_LB.Items.Clear();
            }
            WED2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED3_LB.Items.Contains("Rest Day"))
            {
                WED3_LB.Items.Clear();
            }
            WED3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED4_LB.Items.Contains("Rest Day"))
            {
                WED4_LB.Items.Clear();
            }
            WED4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED5_LB.Items.Contains("Rest Day"))
            {
                WED5_LB.Items.Clear();
            }
            WED5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void WED6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (WED6_LB.Items.Contains("Rest Day"))
            {
                WED6_LB.Items.Clear();
            }
            WED6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU1_LB.Items.Contains("Rest Day"))
            {
                THU1_LB.Items.Clear();
            }
            THU1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU2_LB.Items.Contains("Rest Day"))
            {
                THU2_LB.Items.Clear();
            }
            THU2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU3_LB.Items.Contains("Rest Day"))
            {
                THU3_LB.Items.Clear();
            }
            THU3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU4_LB.Items.Contains("Rest Day"))
            {
                THU4_LB.Items.Clear();
            }
            THU4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU5_LB.Items.Contains("Rest Day"))
            {
                THU5_LB.Items.Clear();
            }
            THU5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void THU6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (THU6_LB.Items.Contains("Rest Day"))
            {
                THU6_LB.Items.Clear();
            }
            THU6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI1_LB.Items.Contains("Rest Day"))
            {
                FRI1_LB.Items.Clear();
            }
            FRI1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI2_LB.Items.Contains("Rest Day"))
            {
                FRI2_LB.Items.Clear();
            }
            FRI2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI3_LB.Items.Contains("Rest Day"))
            {
                FRI3_LB.Items.Clear();
            }
            FRI3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI4_LB.Items.Contains("Rest Day"))
            {
                FRI4_LB.Items.Clear();
            }
            FRI4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI5_LB.Items.Contains("Rest Day"))
            {
                FRI5_LB.Items.Clear();
            }
            FRI5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void FRI6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (FRI6_LB.Items.Contains("Rest Day"))
            {
                FRI6_LB.Items.Clear();
            }
            FRI6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT1_LB.Items.Contains("Rest Day"))
            {
                SAT1_LB.Items.Clear();
            }
            SAT1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT2_LB.Items.Contains("Rest Day"))
            {
                SAT2_LB.Items.Clear();
            }
            SAT2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT3_LB.Items.Contains("Rest Day"))
            {
                SAT3_LB.Items.Clear();
            }
            SAT3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT4_LB.Items.Contains("Rest Day"))
            {
                SAT4_LB.Items.Clear();
            }
            SAT4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT5_LB.Items.Contains("Rest Day"))
            {
                SAT5_LB.Items.Clear();
            }
            SAT5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SAT6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SAT6_LB.Items.Contains("Rest Day"))
            {
                SAT6_LB.Items.Clear();
            }
            SAT6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN1_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN1_LB.Items.Contains("Rest Day"))
            {
                SUN1_LB.Items.Clear();
            }
            SUN1_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN2_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN2_LB.Items.Contains("Rest Day"))
            {
                SUN2_LB.Items.Clear();
            }
            SUN2_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN3_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN3_LB.Items.Contains("Rest Day"))
            {
                SUN3_LB.Items.Clear();
            }
            SUN3_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN4_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN4_LB.Items.Contains("Rest Day"))
            {
                SUN4_LB.Items.Clear();
            }
            SUN4_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN5_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN5_LB.Items.Contains("Rest Day"))
            {
                SUN5_LB.Items.Clear();
            }
            SUN5_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
        private void SUN6_LB_DragDrop(object sender, DragEventArgs e)
        {
            if (SUN6_LB.Items.Contains("Rest Day"))
            {
                SUN6_LB.Items.Clear();
            }
            SUN6_LB.Items.Add(helperfns.listBox_DragDrop(sender, e));
        }
    }

    public class lift_name_dayorder
    {
        public string lift_name { get; set; }
        public string lift_day_order { get; set; }

        public lift_name_dayorder(string lift_name, string lift_day_order)
        {
            this.lift_name = lift_name;
            this.lift_day_order = lift_day_order;
        }            
    }  

}
