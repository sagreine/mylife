// Demo how to embed an R Graphics Window in a .NET Application
// Used R.NET to start and run R.dll. http://rdotnet.codeplex.com/
// Uses Dino  Esposito's Hook to embed the Graph Window
// http://msdn.microsoft.com/en-us/magazine/cc188920.aspx
// Dieter Menne, Menne Biomed Consulting Tübingen, dieter menne at menne-biomed de
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using Microsoft.Win32;
using ConsoleApplication1.WindowsFormsApplication3;
using MyLife;
using Constants;
using ConsoleApplication1;

namespace RDotNet
{
    public class RGraphForm 
    {


        /*public RGraphForm()
        {
            string aig = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            InitializeComponent();
            REngine.SetDllDirectory(GetRPath());
            REngine.CreateInstance(aig);
            engine = REngine.GetInstanceFromID(aig);

            // use this in creating a general graph to go on the homepage (only loaded once)//
            //cbt = new RGraphAppHook { GraphControl = panel1 };
            //cbt.Install();
            //engine.EagerEvaluate("plot(rnorm(100))");
            //cbt.Uninstall();
        }*/



        /*private void Form1FormClosed(object sender, FormClosedEventArgs e)
        {
            if (engine != null)
                engine.Close();
        }
        */

        

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataTable table = Constants.Constants_class.db.GetDataTable("Select * from Foods");
            //if (table.Columns.GetType() == Double);
            //Type a = table.Columns.GetType();
            //var varl = new List<string>();
            //string [,] arr = new string[table.Rows.Count,table.Columns.Count];
            string [] arr2 = new string [table.Rows.Count];            

            string list = "a0";
            string[] tabs = Enumerable.Repeat("A", table.Rows.Count).ToArray();
            CharacterVector nvColnull = engine.CreateCharacterVector(tabs);
            */

            // test code to actually get it working. doesn't work yet though //
           /* engine.SetSymbol("a", nvColnull); 
            
            engine.EagerEvaluate("a=data.frame(a)");
            engine.EagerEvaluate("b=a[with(a, order(a, a)), ]");
             
            DataFrame result = engine.EagerEvaluate("a").AsDataFrame();
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();           
            for (int hi = 0; hi < table.Rows.Count; hi++)
            {
                //string abc = Convert.ToString(result[hi, 0]);
                //string abc2 = result[hi, 1];
                sb.Append(Convert.ToString(result[hi,0]));
            }

            string result1 = Convert.ToString(sb);
            MessageBox.Show(result1);*/
            ////////



            /*
            // Actual code 
            engine.EagerEvaluate("a0 <- c(0,1,2)");
            for (int i = 0; i < table.Columns.Count; i++) // Loop over the rows.
            {
                for (int j = 0; j < table.Rows.Count; j++) // Loop over the items.
                {
                    var a = table.Rows[j][i];
                    arr2[j] = Convert.ToString(table.Rows[j][i]);
                }
                CharacterVector nvCol1= engine.CreateCharacterVector(arr2);
                list = list + ",arr"+i;
                engine.SetSymbol("arr" + i, nvCol1);               
            }
            string script = "df <- data.frame(" + list + ")";
            engine.EagerEvaluate(script);
           
           // DataFrame dataset = engine.EagerEvaluate("df").AsDataFrame();
            */
        }
    }
}
