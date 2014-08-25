using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;


// need to address when we choose a saved week, what happens if there is more than one workout day saved for a given day?
// it can't be  a combobox that only allows one selection...

namespace MyLife
{
    public partial class Week_to_schedule : UserControl
    {
        public Week_to_schedule(int week)
        {
            InitializeComponent();                                   
            Week_number_label.Text += Convert.ToString(week + 1) ;

            for (int i = 0; i < 7; i++)
            {
                Day_to_schedule day_to_schedule = new Day_to_schedule((week * 7) + 1 + i);
                string this_control_name = string.Format("day_to_schedule{0}", Convert.ToString(i));

                day_to_schedule.Name = this_control_name;
                this.Controls.Add(day_to_schedule);
                day_to_schedule.Location = new Point(day_to_schedule.Size.Width * i + 1, 50);
            }
            // populate the saved weeks dropdown option with all saved weeks
            Saved_weeks_CB.DisplayMember = "week_name";
            Saved_weeks_CB.DataSource = Constants_class.db.GetDataTable("Select distinct week_name from workout_weeks");
        }

        // when we choose a saved week
        private void Saved_weeks_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable new_days = 
                          Constants_class.db.GetDataTable("Select distinct workout_day_name, day_of_week from workout_weeks where week_name =  '" 
                                                          + Saved_weeks_CB.Text + "'");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < new_days.Rows.Count; j++)
                {
                    // check every row of the datatable, and then if this row belongs to this day, add it to the the items to be selected
                    if (new_days.Rows[j]["day_of_week"].ToString() == Convert.ToString(i))
                    {

                    }
                }
                this.Controls[string.Format("day_to_schedule{0}", Convert.ToString(i))].Text = "";
            }
        }
        public Panel Get_Header_Panel { get { return this.Header_panel; } }
    }
}
