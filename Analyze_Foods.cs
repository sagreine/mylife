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
    public partial class Analyze_Foods : Form
    {        
        public Analyze_Foods()
        {
            InitializeComponent();
            
            DataTable dt = Constants_class.db.GetDataTable("SELECT DISTINCT Name from Food_logs order by Name");
            List<string> _items2 = new List<string>();            
            foreach (DataRow dr in dt.Rows)
            {
                string blergh = Convert.ToString(dr[0]);
                _items2.Add(blergh);
            }
            AnalysisListBox.DataSource = _items2;                                                
        }

        private void AnalysisListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string max_date = Constants_class.db.ExecuteScalar("Select max(last_used) from Foods where name ='" + AnalysisListBox.SelectedValue.ToString() + "'");
            ANFLastUsedTextBox.Text = max_date;
            ANFTimesEatenUD.Value = Convert.ToInt32(Constants_class.db.ExecuteScalar("Select count(*) from Food_logs where name ='" + AnalysisListBox.SelectedValue.ToString() + "'"));
            ANFAvgTasteUD.Value = Convert.ToDecimal(Constants_class.db.ExecuteScalar("Select avg(Taste_rating) from Food_logs where name ='" + AnalysisListBox.SelectedValue.ToString() + "'"));
        }
    }
}
