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


namespace MyLife
{
    public partial class Add_Food : Form
    {
        private void addfood_basic()
        {
            Dictionary<String, string> data = new Dictionary<String, string>();
            string max_int = helperfns.get_Max_value("food_id", "Foods"); /*Constants_class.db.ExecuteScalar("Select max(food_id) from Foods");
            if (max_int == "") { max_int = "1"; }
            else
            {
                max_int = Convert.ToString(Convert.ToInt32(max_int) + 1);
            }*/
            data.Add("food_id", max_int);
            data.Add("name", AddFoodNameTextBox.Text);
            data.Add("serving_size", AddFoodServingSizeUpDown.Text);
            data.Add("calories", AddFoodCaloriesUpDown.Text);
            data.Add("carbs", AddFoodCarbohydratesUpDown.Text);
            data.Add("fat", AddFoodFatUpDown.Text);
            data.Add("protein", AddFoodProteinUpDown.Text);

            //if (AddFoodRecommendRBYes.Checked == true)
            //{
                data.Add("Recommend", AddFoodRecommendRBNo.Checked.ToString());
                //data.Add("Recommend", "true");
            //}
            //else if (AddFoodRecommendRBNo.Checked == false)
            //{
                //data.Add("Recommend", "false");
            //}
            //else
            //{
                //data.Add("Recommend", "errorz");
            //}
            data.Add("comments", AddFoodCommentsTextBox.Text);

            try
            {
                Constants_class.db.Insert("foods", data,true);
            }

            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }

        public Add_Food()
        {
            InitializeComponent();
        }

        private void AddFoodSaveButton_Click(object sender, EventArgs e)
        {
            addfood_basic();
            this.Close();
        }

        public void AddFoodSaveAndContinueButton_Click(object sender, EventArgs e)
        {
            addfood_basic();
            helperfns.RecursiveClearControls(this.Controls);
        }

        private void AFGoogleIt_Click(object sender, EventArgs e)
        {
            helperfns.GoogleItButtonGo(AddFoodNameTextBox);
        }

        private void AFCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
