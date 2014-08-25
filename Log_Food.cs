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

// look at changing it so the listbox dropdown thing doesn't dropdown all the way until the textbox
// is initially clicked in. Also, maybe reorganize the thing itself so that this doesn't get in the way of the calendar when it drops down.

namespace MyLife
{
    public partial class Log_Food : Form
    {
        private void logfood_basic()
        {
            Dictionary<String, string> data = new Dictionary<String, string>();
            string max_int = Constants_class.db.ExecuteScalar("Select max(food_logs_id) from food_logs");
            if (string.IsNullOrEmpty(max_int)) { max_int = "1"; }
            else
            {
                max_int = Convert.ToString(Convert.ToInt32(max_int) + 1);
            }
            data.Add("food_logs_id", max_int);
            data.Add("name", LogFoodNameComboBox.Text);
            data.Add("Servings", LogFoodServingsTextBox.Text);
            data.Add("Taste_Rating", LogFoodTasteRatingUD.Text);
            data.Add("Cooking_Style", LogFoodCookingStyleTextBox.Text);            
            //data.Add("Time_Eaten", AddFoodProteinTextBox.Text); // Not added to form yet
            data.Add("comments", LogFoodCommentsTextBox.Text);


            DateTime obj = LogFoodDateEatenCalendar.SelectionStart;
            string mydate_pre = obj.ToString();
            string mydate = DateTime.Parse(mydate_pre).ToString("yyyy-MM-dd");
            data.Add("Date_Eaten", mydate);
            data.Add("When_Logged", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // update last used in the foods table // 
            //Dictionary<String, string> historical = new Dictionary<String, string>();
            //historical.Add("Last_used", DateTime.Today.ToString("yyyy-MM-dd"));
            //string where = " upper(name)  = '" + comboBox2.Text.ToUpper() + "'";

            try
            {
                Constants_class.db.Insert("food_logs", data,true);
                //db.Update("Foods", historical, where); // doesnt work right now
            }

            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }


        public Log_Food(DateTime? date_logging)
        {
            InitializeComponent();

            if (date_logging.HasValue)
            {
                LogFoodDateEatenCalendar.SelectionStart = Convert.ToDateTime(date_logging);
                LogFoodDateEatenCalendar.SelectionEnd = Convert.ToDateTime(date_logging);
            }
            else
            {
                LogFoodDateEatenCalendar.SelectionStart = DateTime.Now;
            }
        }

        public Log_Food()
        {
            InitializeComponent();
            LogFoodDateEatenCalendar.SelectionStart = DateTime.Now;            
        }


        private void LogFoodSaveButton_Click(object sender, EventArgs e)
        {
            logfood_basic();
            this.Close();
        }

        private void LogFoodSaveAndContinueButton_Click(object sender, EventArgs e)
        {
            logfood_basic();
            helperfns.RecursiveClearControls(this.Controls);
        }

        // very strange.... wut for this and next function
        private void LogFoodNameComboBox_Enter(object sender, EventArgs e)
        {
            // this -if- is an extra error check. So that nothing happens if you click in the textbox more than once etc.. Not reset in that case.
            if (string.IsNullOrEmpty(LogFoodNameComboBox.Text))
            {
                //helperfns.combo_box_name_initializer("Foods", LogFoodNameComboBox, "", "DISTINCT", LogFoodNameComboBox_TextChanged);
                this.LogFoodNameComboBox.TextChanged += new System.EventHandler(this.LogFoodNameComboBox_TextChanged);
            }            
        }
        // wut.
        private void LogFoodNameComboBox_TextChanged(object sender, EventArgs e)
        {
            this.LogFoodNameComboBox.TextChanged -= new System.EventHandler(this.LogFoodNameComboBox_TextChanged);
            //helperfns.combo_box_name_initializer("Foods", LogFoodNameComboBox, LogFoodNameComboBox.Text, "UPDATE", LogFoodNameComboBox_TextChanged);
            this.LogFoodNameComboBox.TextChanged += new System.EventHandler(this.LogFoodNameComboBox_TextChanged);
        }

        private void LFCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogFoodNameComboBox_Leave(object sender, EventArgs e)
        {
             helperfns.combo_box_shrinker(this.LogFoodNameComboBox);
        }

    }
}
