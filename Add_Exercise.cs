using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using ConsoleApplication1.WindowsFormsApplication3;
using Constants;

namespace MyLife
{
    public partial class Add_Exercise : Form
    {
        private void addexercise_basic()
        {
            Dictionary<String, string> data = new Dictionary<String, string>();
            string max_int = Constants_class.db.ExecuteScalar("Select max(Exercise_id) from Exercises");
            if (max_int == "") { max_int = "1"; }
            else
            {
                max_int = Convert.ToString(Convert.ToInt32(max_int) + 1);
            }
            data.Add("Exercise_id", max_int);
            data.Add("name", AddExerciseNameTextBox.Text);
            data.Add("Time_1_Rep", AddExerciseT1RUpDown.Text);
            data.Add("Time_1_Set", AddExerciseT1SUpDown.Text);
            data.Add("Required_Equipment", AddExerciseRETextBox.Text);
            data.Add("comments", AddExerciseCommentsTextBox.Text);
            data.Add("Enjoyment_Level", AddExerciseELUpDown.Text);
            data.Add("Difficulty", AddExerciseDiffUpDown.Text);
            data.Add("Muscles_Worked", AddExerciseMWTextBox.Text);
            // default 1rm to 1
            data.Add("epley_e1rm", "1");

            //if (AddExerciseRecommendRBYes.Checked == true)
            //{
                data.Add("Recommend",AddExerciseRecommendRBYes.Checked.ToString());
                //data.Add("Recommend", "true");
            //}
            //else if (AddExerciseRecommendRBNo.Checked == false)
            //{
                //data.Add("Recommend", "false");
            //}
            //else
            //{
                //data.Add("Recommend", "errorz");
            //}


            try
            {
                Constants_class.db.Insert("Exercises", data,true);
            }

            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }        
        public Add_Exercise()
        {
            InitializeComponent();
        }

        private void AddExerciseSaveButton_Click(object sender, EventArgs e)
        {
            addexercise_basic();
            this.Close();
        }

        private void AddESaveAndContinueButton_Click(object sender, System.EventArgs e)
        {
            addexercise_basic();
            helperfns.RecursiveClearControls(this.Controls);
        }

        private void AEGoogleIt_Click(object sender, EventArgs e)
        {
            helperfns.GoogleItButtonGo(AddExerciseNameTextBox);
        }

        private void AECancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
