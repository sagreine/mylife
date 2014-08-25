using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;
using ConsoleApplication1.WindowsFormsApplication3;

namespace MyLife
{
    public partial class Analyze_Exercises : Form
    {
        public Analyze_Exercises()
        {
            InitializeComponent();
            ANEAnalysisListBox.DataSource = helperfns.simple_listbox_populater_distinct("Name","Name", "Exercise_logs_details");                   
        }

        // old style setup, where weight and reps were wide format (weight1, weight2, weight3
        /*private string select_extreme_weight( string sqlfunction, string var_to_pick,string where)
       {            
            string sql_extreme_weight = "Select max(Col1) as weight From (" +
                   "Select " + sqlfunction + "("+var_to_pick+"1) as Col1 FROM exercise_logs where "+ where + " name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")" +
                   " union"+
                   " Select " + sqlfunction + "(" + var_to_pick + "2) as Col2 FROM exercise_logs where " + where + " name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")" +
                   " union"+
                   " Select " + sqlfunction + "(" + var_to_pick + "3) as Col3 FROM exercise_logs where " + where + " name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")" +
                   " union"+
                   " Select " + sqlfunction + "(" + var_to_pick + "4) as Col4 FROM exercise_logs where " + where + " name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")" +
                   " union"+
                   " Select " + sqlfunction + "(" + var_to_pick + "5) as Col5 from exercise_logs where " + where + " name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")" +
                    ")  "
                   ;

            string weight = Convert.ToString(Constants_class.db.ExecuteScalar(sql_extreme_weight)); 
           return weight;
           
       }*/
        //"select max weight per date, and date"
        private DataTable select_extreme_weight_and_date(string sqlfunction)
        {
                string sql_extreme_weight = "Select " + sqlfunction + "(weight) as weight, strftime('%m/%d',date_exercised) as date From exercise_logs_details " +
                       "where name= '" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + 
                       ") group by date_exercised order by date_exercised";
                DataTable weight = Constants_class.db.GetDataTable(sql_extreme_weight);
                return weight;
        }

        private void select_count()
        {
            string used = "Select count(*) from Exercise_logs where name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) )) < " + ANELastXDaysUD.Value.ToString();
            TimesUsedLabel.Text = Constants_class.db.ExecuteScalar(used);
        }

        private void chart_updater()
        {
            // add a legend, if one doesn't exist
            if (ANEChart1.Legends.IndexOf("main_legend") == -1)
            {
                ANEChart1.Legends.Add("main_legend");
                ANEChart1.Legends["main_legend"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top; 
            }            
            // chart the serieses
            if (Max_value_CB.Checked == true)
            {
                // chart the max weight series
                DataTable max_per_date = select_extreme_weight_and_date("max");
                int[] max_yValues = new int[max_per_date.Rows.Count];
                string[] max_xNames = new string[max_per_date.Rows.Count];

                for (int r = 0; r < max_per_date.Rows.Count; r++)
                {
                    DataRow max_row = max_per_date.Rows[r];
                    max_yValues[r] = Convert.ToInt32(max_row["weight"]);
                    max_xNames[r] = Convert.ToString(max_row["date"]);
                }

                if (ANEChart1.Series.IndexOf("max_per_date") == -1)
                {
                    ANEChart1.Series.Add("max_per_date");
                }
                // the max series
                ANEChart1.Series["max_per_date"].Points.DataBindXY(max_xNames, max_yValues);
                ANEChart1.Series["max_per_date"].ToolTip = "#VALY";
                ANEChart1.Series["max_per_date"].IsValueShownAsLabel = true;
                ANEChart1.Series["max_per_date"].Color = Color.Blue;

                ANEChart1.Series["max_per_date"].LegendText = "Max Weight";
            }
            // if this one isnt checked, delete if it already exists.
            else if (ANEChart1.Series.IndexOf("max_per_date") != -1)
            {
                ANEChart1.Series.RemoveAt(ANEChart1.Series.IndexOf("max_per_date"));
            }

            if (Min_value_CB.Checked == true)
            {
                // chart the min weight series
                DataTable min_per_date = select_extreme_weight_and_date("min");
                int[] min_yValues = new int[min_per_date.Rows.Count];
                string[] min_xNames = new string[min_per_date.Rows.Count];

                for (int r = 0; r < min_per_date.Rows.Count; r++)
                {
                    DataRow min_row = min_per_date.Rows[r];
                    min_yValues[r] = Convert.ToInt32(min_row["weight"]);
                    min_xNames[r] = Convert.ToString(min_row["date"]);
                }

                if (ANEChart1.Series.IndexOf("Min_per_date") == -1)
                {
                    ANEChart1.Series.Add("Min_per_date");
                }

                ANEChart1.Series["Min_per_date"].Points.DataBindXY(min_xNames, min_yValues);
                ANEChart1.Series["Min_per_date"].ToolTip = "#VALY";
                ANEChart1.Series["Min_per_date"].IsValueShownAsLabel = true;
                ANEChart1.Series["Min_per_date"].Color = Color.Green;

                ANEChart1.Series["Min_per_date"].LegendText = "Min Weight";
            }
            // if this one isnt checked, delete if it already exists.
            else if (ANEChart1.Series.IndexOf("Min_per_date") != -1)
            {
                ANEChart1.Series.RemoveAt(ANEChart1.Series.IndexOf("Min_per_date"));
            }

            // if we are going to build the max value
            if (Eff1rm_CB.Checked == true)
            {
                // chart the effective 1 rep maximum series
                string sql = "select epley_e1rm, strftime('%m/%d',date_exercised) as date from Exercise_logs where name ='"
                                                                   + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() +
                       ") group by date_exercised order by date_exercised";
                DataTable effective_1rm = Constants_class.db.GetDataTable(sql);
                    //helperfns.select_epley_eff1RM(ANEAnalysisListBox, "and (julianday(date('now')) -" + "julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString());//select_extreme_weight_and_date("min");
                int[] e1rm_yValues = new int[effective_1rm.Rows.Count];
                string[] e1rm_xNames = new string[effective_1rm.Rows.Count];

                for (int r = 0; r < effective_1rm.Rows.Count; r++)
                {
                    DataRow e1rm_row = effective_1rm.Rows[r];
                    e1rm_yValues[r] = Convert.ToInt32(e1rm_row["epley_e1rm"]);
                    e1rm_xNames[r] = Convert.ToString(e1rm_row["date"]);
                }

                if (ANEChart1.Series.IndexOf("epley_e1rm") == -1)
                {
                    ANEChart1.Series.Add("epley_e1rm");
                }

                ANEChart1.Series["epley_e1rm"].Points.DataBindXY(e1rm_xNames, e1rm_yValues);
                ANEChart1.Series["epley_e1rm"].ToolTip = "#VALY";
                ANEChart1.Series["epley_e1rm"].IsValueShownAsLabel = true;
                ANEChart1.Series["epley_e1rm"].Color = Color.Red;

                ANEChart1.Series["epley_e1rm"].LegendText = "Effective 1 Rep Max";                
            }
            // if this one isnt checked, delete if it already exists.
            else if (ANEChart1.Series.IndexOf("epley_e1rm") != -1)
            {
                ANEChart1.Series.RemoveAt(ANEChart1.Series.IndexOf("epley_e1rm"));
            }

            /*for (int r = 0; r < max_per_date.Rows.Count; r++)
            {
                DataRow max_row = max_per_date.Rows[r];
                max_yValues[r] = Convert.ToInt32(max_row["weight"]);
                max_xNames[r] = Convert.ToString(max_row["date"]);

                DataRow min_row = min_per_date.Rows[r];
                min_yValues[r] = Convert.ToInt32(min_row["weight"]);
                min_xNames[r] = Convert.ToString(min_row["date"]);

                DataRow e1rm_row = effective_1rm.Rows[r];
                e1rm_yValues[r] = Convert.ToInt32(e1rm_row["eff_one_rm"]);
                e1rm_xNames[r] = Convert.ToString(e1rm_row["date"]);

            }*/

            

            // the min series
            

            // the 1rm series
            
        }


        private void control_updater()
        {
            // Update the panel, including chart
                MaxWeightValueLabel.Text = Constants_class.db.ExecuteScalar("Select max(weight) from Exercise_logs_details where name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")");
                //select_extreme_weight("max","weight","");
                MinWeightValueLabel.Text = Constants_class.db.ExecuteScalar("Select min(weight) from Exercise_logs_details where name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "' and (julianday(date('now')) - julianday(date(date_exercised) ) < " + ANELastXDaysUD.Value.ToString() + ")");
                select_count();
                chart_updater();
        }

        private void ANEAnalysisListBox_SelectedValueChanged(object sender, EventArgs e)
        {
                control_updater();
                string max_date = Constants_class.db.ExecuteScalar("Select max(last_used) from Exercises where name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "'");
                ANELastUsedTextBox.Text = max_date;
                Difficulty_Value_Label.Text = Constants_class.db.ExecuteScalar("Select round(avg(difficulty),.1) from Exercise_logs where name ='" + ANEAnalysisListBox.SelectedValue.ToString() + "'");            
        }

        private void ANEAnalysisRange_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ANEAnalysisRange.Text)
            {
                case "Week":
                   ANELastXDaysUD.Value=7;
                    break;
                case "Month":
                   ANELastXDaysUD.Value = 30;
                    break;
                case "3 Months":
                    ANELastXDaysUD.Value = 90;
                    break;
                case "Year":
                    ANELastXDaysUD.Value = 365;
                    break;
                case "All-Time":
                    ANELastXDaysUD.Value = ANELastXDaysUD.Maximum;
                    break;
                default :
                    ANEAnalysisRange.SelectedItem = ANEAnalysisRange.Items[ANEAnalysisRange.Items.IndexOf("3 Months")];
                    //ANELastXDaysUD.Value = 90;
                    break;                      
             }     
       }
        // eventhandler that fires for any of the chart checkboxes (currently min, max, effective 1 rm)
        private void update_chart_checkboxes(object sender, EventArgs e)
        {
            control_updater();
        }        
    }
}
