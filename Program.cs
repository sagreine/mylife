using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApplication2;
using MyLife;
using Constants;
using System.Drawing;


using System.IO;

namespace ConsoleApplication1
{
    namespace WindowsFormsApplication3
    {

        // not currently used though.
        public interface Iloggable
        {
            void Log();
            void Read_Log();
            void Delete_Log(string tablename, string id_var_in_table, int id);
            void Edit_Log();
            //string item_name;
            string Add_table_to_db_sql(string item_name, Dictionary<string, string> fields_and_constraints);
            void Remove_table_from_db();
        }
        public abstract class Loggable_item : Iloggable
        {
            // this query needs to be parameterized. especially this.
            public string Add_table_to_db_sql(string item_name, Dictionary<string,string> fields_and_constraints)
            {
                string sql = "CREATE TABLE " + item_name + "(";

                for (int i = 0; i < fields_and_constraints.Keys.Count; i++)
                {
                    sql += fields_and_constraints.Keys.ElementAt(i).ToString() + fields_and_constraints.Values.ElementAt(i).ToString();

                    // if we are adding not the last field, put a comma
                    if (i < fields_and_constraints.Keys.Count - 1)
                    {
                         sql += ",";
                    }

                }
                // put a close parenthetical and return the sql;
                return sql + ")";                
            }
            public abstract void Delete_Log(string tablename, string id_var_in_table, int id);//{}//;
            public abstract void Read_Log();//{}//;
            public abstract void Edit_Log();//{}//;
            public abstract void Log();//{}//;
            public abstract void Remove_table_from_db();//{}//;
        }


        public static class helperfns
        {

            public static void sort_dt_by_date()
            {

            }

            public static void sort_dt_by_alpha()
            {

            }
            public static string listBox_DragDrop(object sender, DragEventArgs e)
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    string str = (string)e.Data.GetData(
                        DataFormats.StringFormat);
                    return str;
                }
                else
                {
                    return "FAILED";
                }
            }

            public static void enter_tb_clear_ifstring(object sender, EventArgs e, TextBox textbox, string if_value_is_this)
            {
                if (textbox.Text == if_value_is_this)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                    textbox.Font = new Font(textbox.Font, FontStyle.Regular);                    
                }
            }

            public static void Mousedown_LB_make_drag_outable(object sender, MouseEventArgs e, ListBox listbox, Form form)
            {                               
                    int index = listbox.IndexFromPoint(e.X, e.Y);
                    if (index == -1 || listbox.Items.Count == 0 || listbox.Items[index] == null)
                        return;
                    string s = listbox.Items[index].ToString();
                    DragDropEffects dde1 = form.DoDragDrop(s, DragDropEffects.Copy);                
            }

            public static void enable_listbox(object sender, EventArgs e)
            {                
                ListBox listbox = (ListBox)sender;
                listbox.Enabled = true;
                listbox.BackColor = Color.White;
            }
            // this will be going away soon, once build_workout_days is updated to be sensible
            public static void enable_listbox(object sender, EventArgs e, ListBox listbox)
            {                
                listbox.Enabled = true;
                listbox.BackColor = Color.White;
            }

            public static void disable_listbox(object sender, EventArgs e, ListBox day_listbox)
            {
                day_listbox.Enabled = false;
                day_listbox.BackColor = SystemColors.InactiveCaption;
            }
            public static void RecursiveClearControls(Control.ControlCollection cc)
            {
                foreach (Control ctrl in cc)
                {
                    TextBox tb = ctrl as TextBox;
                    if (tb != null)
                        tb.Clear();
                    else
                        RecursiveClearControls(ctrl.Controls);
                    if (ctrl is CheckBox)
                    {

                        ((CheckBox)ctrl).Checked = false;
                    }

                    if (ctrl is RadioButton)
                    {
                        ((RadioButton)ctrl).Checked = false;
                    }
                    if (ctrl is ListBox)
                    {
                        ((ListBox)ctrl).Items.Clear();
                        ((ListBox)ctrl).DataSource = null;
                    }
                    if (ctrl is NumericUpDown)
                    {
                        ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                    }
                }
            }

            // this (obviously) isnt the right way to do this at all - use default search engine or something.
            public static void GoogleItButtonGo(TextBox textbox)                
            {
                string finalstring = "http://www.google.com/search?query=";
                finalstring = finalstring + textbox.Text;
                System.Diagnostics.Process.Start(finalstring);
                //string searchString = textbox.Text;
            }

            // need to do validation here or when this is called. also this is stupid



            public static void combo_box_name_initializer(string table, ComboBox comboBox, /* string first_entry,*/
                               string Update_or_distinct, EventHandler event_handler, string idvar, int num_items_returned )
            {                

                 
                //  This needs to be redone so the blank space is at the top of the lis (or not at all)
                /// concerns - the num_items_returned returned items won't be sorted by date last used if we sort by exercise_id or something.
                ///  
                ///  
                ///  
                ///  

                string ret = "ERROR";
                if (Update_or_distinct == "DISTINCT")
                {
                    ret = "SELECT distinct name, " + idvar + " from " + table + " order by date(Last_used) DESC LIMIT " + num_items_returned;
                }
                else if (Update_or_distinct == "UPDATE")
                {
                    string pre_ret = "SELECT name, " + idvar + " from " + table + " where name like ";
                    ret = pre_ret + "'" + "%" + comboBox.Text + "%" + "' order by date(Last_used) DESC LIMIT " + num_items_returned;
                }

                // get the name to display and the idvar
                
                DataTable dt1 = Constants_class.db.GetDataTable(ret);
                                
                // add what has been typed into our combobox so far as an item - we want this to be at the top here.
                dt1.Rows.Add(comboBox.Text, -10);

                //string current = comboBox.Text;

                //dt1.Rows.Add(dt1.Rows[0]);
                /*
                DataRow dr = dt1.NewRow();

                dr["name"] = dt1.Rows[0]["name"]; 
                dr[idvar] = dt1.Rows[0][idvar];
                
                dt1.Rows[0]["name"] = comboBox.Text;
                dt1.Rows[0][idvar] = -100;
                */


                /*DataView dv = dt1.DefaultView;
                dv.Sort = "occr desc";
                DataTable sortedDT = dv.ToTable();*/

                //dt1.Rows.Add(dr);

//                comboBox.TextChanged -= new EventHandler(event_handler);

                comboBox.DataSource = null;
                comboBox.DataSource = dt1;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = idvar;
                // select the item that represents what we're typing into the box. TIS.
                comboBox.SelectedValue = -10;


                comboBox.SelectionStart = comboBox.Text.Length;
                comboBox.SelectionLength = 0;
                comboBox.DropDownStyle = ComboBoxStyle.Simple;
                comboBox.Size = new System.Drawing.Size(121, 146);
                comboBox.BringToFront();


                /* string ret = "ERROR";
                 if (Update_or_distinct == "DISTINCT")
                 {
                     ret = "SELECT distinct name from " + table + " order by date(Last_used) DESC LIMIT 5";
                 }
                 else if (Update_or_distinct == "UPDATE")
                 {
                     string pre_ret = "SELECT name from " + table + " where name like ";
                     ret = pre_ret + "'" + "%" + comboBox.Text + "%" + "'";
                 }
                 DataTable dt = Constants_class.db.GetDataTable(ret);

                 List<string> _items2 = new List<string>();
                 _items2.Add(first_entry);
                 foreach (DataRow dr in dt.Rows)
                 {
                     string blergh = Convert.ToString(dr[0]);
                     _items2.Add(blergh);
                 }
                 comboBox.TextChanged -= new EventHandler(event_handler);
                 comboBox.DataSource = _items2;
                 if (Update_or_distinct == "UPDATE")
                 {
                     // this has to go down here, because setting datasource of the combo box triggers the leave event......
                     comboBox.SelectionStart = comboBox.Text.Length;
                     comboBox.SelectionLength = 0;
                     comboBox.DropDownStyle = ComboBoxStyle.Simple;
                     comboBox.Size = new System.Drawing.Size(121, 146);
                     comboBox.BringToFront();
                 }
                 

                 */
                //comboBox.TextChanged += new EventHandler(event_handler);
            }

            public static void combo_box_shrinker(ComboBox comboBox)
            {
                comboBox.Size = new System.Drawing.Size(121, 21);
            }

            public static List<string> simple_listbox_populater_distinct(string variable, string order_by_var, string table)
            {
               DataTable dt = Constants_class.db.GetDataTable("SELECT DISTINCT " + variable + " from " + table + " order by " + order_by_var);
               List<string> _items2 = new List<string>();
               foreach (DataRow dr in dt.Rows)
               {
                   string blergh = Convert.ToString(dr[0]);
                   _items2.Add(blergh);                   
               }               
               return _items2;
            }

            public static string get_Max_value(string variable, string table)
            {
                string max_int = Constants_class.db.ExecuteScalar("Select max("+ variable + " )from " +table);
                if (max_int == "") { max_int = "1"; }
                else
                {
                    max_int = Convert.ToString(Convert.ToInt32(max_int) + 1);
                }
                return max_int;
            }

            public static void delete_from_combobox (object sender)
            {
                ComboBox combobox = (ComboBox)sender;
                combobox.Items.Remove(combobox.SelectedItem);
            }
            // generic keydown event handler for delete or backspace. could supergeneralize but yeah..............
            public static void keydown_delete_CBorLB(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    if (sender.GetType() == typeof(ComboBox))
                    {
                       delete_from_combobox(sender); 
                    }
                    else if (sender.GetType() == typeof(ListBox))
                    {
                        delete_from_listbox(sender); 
                    }

                }                    
            }
            public static void delete_from_listbox(object sender)
            {
                ListBox combobox = (ListBox)sender;
                combobox.Items.Remove(combobox.SelectedItem);
            }

            // probably should handle formatting of the input date string in this function?
            public static void insert_image_to_db(string image_description, string date_taken, string body_part, PictureBox picturebox)
            {
                SQLiteConnection cnn = new SQLiteConnection(Constants.Constants_class.db.dbConnection);
                cnn.Open();
                SQLiteCommand command = cnn.CreateCommand();
                command.CommandText = String.Format("INSERT INTO Images" +
                   "(Description, Date_Taken, Date_Uploaded, body_part, Image) VALUES" +
                    "(@0, '{1}', '{2}', '{3}',  @1)",
                image_description, date_taken, DateTime.Now.ToString("yyyyMMdd"), body_part);
                SQLiteParameter description_p = new SQLiteParameter("@0");
                SQLiteParameter image_p = new SQLiteParameter("@1", System.Data.DbType.Binary);
                description_p.Value = image_description;
                command.Parameters.Add(description_p);

                byte[] rawDoc = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert Image to byte[]
                    picturebox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    rawDoc = ms.ToArray();
                }

                image_p.Value = rawDoc;
                command.Parameters.Add(image_p);
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static class calculations
        {
            public static double epley_e1rm(double weight, int reps)
            {
                return Math.Round(weight * reps / 30 + weight,1);
            }
        }

        public class SQLiteDatabase
        {

            public String dbConnection;

            ///        

            ///     Default Constructor for SQLiteDatabase Class.       

            ///    

            ///        

            public SQLiteDatabase()
            {

                // Original line:

                dbConnection = "Data Source=MyNewDb.sqlite";

                //            dbConnection = "Data Source=C:\\Users\\sgreiner\\Desktop\\MyNewDb.sqlite";

            }

            ///         ///    

            ///         Single Param Constructor for specifying the DB file.         ///      

            ///         /// The File containing the DB        

            public SQLiteDatabase(String inputFile)
            {

                dbConnection = String.Format("Data Source={0}", inputFile);

            }

            ///         ///     Single Param Constructor for specifying advanced connection options.         ///         ///

            ///         A dictionary containing all desired options and their values       

            public SQLiteDatabase(Dictionary<string, string> connectionOpts)
            {

                String str = "";

                foreach (KeyValuePair<string, string> row in connectionOpts)
                {

                    str += String.Format("{0}={1}; ", row.Key, row.Value);

                }

                str = str.Trim().Substring(0, str.Length - 1);

                dbConnection = str;

            }

            ///         ///     Allows the programmer to run a query against the Database.         ///         ///

            ///         The SQL to run         /// A DataTable containing the result set.        

            public DataTable GetDataTable(string sql)
            {

                DataTable dt = new DataTable();

                try
                {

                    SQLiteConnection cnn = new SQLiteConnection(dbConnection);

                    cnn.Open();

                    SQLiteCommand mycommand = new SQLiteCommand(cnn);

                    mycommand.CommandText = sql;

                    SQLiteDataReader reader = mycommand.ExecuteReader();

                    dt.Load(reader);

                    reader.Close();

                    cnn.Close();

                }

                catch (Exception e)
                {

                    throw new Exception(e.Message);

                }

                return dt;

            }

            ///         ///     Allows the programmer to interact with the database for purposes other than a query.         ///        

            // The SQL to be run.         /// An Integer containing the number of rows updated.        

            public int ExecuteNonQuery(string sql)
            {

                SQLiteConnection cnn = new SQLiteConnection(dbConnection);

                cnn.Open();

                SQLiteCommand mycommand = new SQLiteCommand(cnn);

                mycommand.CommandText = sql;

                int rowsUpdated = mycommand.ExecuteNonQuery();

                cnn.Close();

                return rowsUpdated;

            }

            ///         ///     Allows the programmer to retrieve single items from the DB.         ///        

            /// The query to run.         /// A string.       

            public string ExecuteScalar(string sql)
            {

                SQLiteConnection cnn = new SQLiteConnection(dbConnection);

                cnn.Open();

                SQLiteCommand mycommand = new SQLiteCommand(cnn);

                mycommand.CommandText = sql;

                object value = mycommand.ExecuteScalar();

                cnn.Close();

                if (value != null)
                {

                    return value.ToString();

                }

                return "";

            }

            ///         ///     Allows the programmer to easily update rows in the DB.         ///        

            /// The table to update.         /// A dictionary containing Column names and their new values.        

            /// The where clause for the update statement.         /// A boolean true or false to signify success or failure.       

            public bool Update(String tableName, Dictionary<string, string> data, String where)
            {

                String vals = "";

                Boolean returnCode = true;

                if (data.Count >= 1)
                {

                    foreach (KeyValuePair<string, string> val in data)
                    {

                        vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());

                    } vals = vals.Substring(0, vals.Length - 1);

                }

                try
                {

                    this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));

                }

                catch
                {

                    returnCode = false;

                }

                return returnCode;

            }

            ///         ///     Allows the programmer to easily delete rows from the DB.         ///       

            ///         /// The table from which to delete.         /// The where clause for the delete.       

            ///         /// A boolean true or false to signify success or failure.        

            public bool Delete(String tableName, String where)
            {

                Boolean returnCode = true;

                try
                {

                    this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));

                }

                catch (Exception )
                {

                    //MessageBox.Show(fail.Message);

                    returnCode = false;

                }

                return returnCode;

            }

            ///         ///     Allows the programmer to easily insert into the DB         ///        

            /// The table into which we insert the data.       

            /// /// A dictionary containing the column names and data for the insert.       

            /// /// A boolean true or false to signify success or failure.       
            /// 

            public bool bulk_insert(String tableName, DataTable data, bool confirmation_box)
            {

                // need a way to have a distinct dictionary setup for every row to be inserted...                

                String values = "";

                Boolean returnCode = true;

                // add the first item to the query
                
                string sql_columns = "(";
                string sql_first_row_values = "";
                string sql_values = "";
                

                // add the rest of the items to the query
                for (int i = 0; i < data.Rows.Count; i++)
                {                    
                    values = "";
                    for (int c = 0; c < data.Columns.Count; c++)
                    {
                        // for all but the last column ( we don't want a comma after the last value)
                        if (c < data.Columns.Count - 1)
                        {
                            // add a quoted value and a comma after it
                            values += String.Format(" '{0}',", data.Rows[i][c].ToString());
                            if (i == 0)
                            {
                                // for the first row, we wan't to create a list of the columns
                                sql_columns += String.Format(" '{0}',", data.Columns[c].ColumnName);
                            }
                        }
                        
                        // we dont want to have a comma at the end of the last value or column we add, so for the last value do this
                        else
                        {
                            values += String.Format(" '{0}'", data.Rows[i][c].ToString());
                            if (i == 0)
                            {
                                sql_columns += String.Format(" '{0}'", data.Columns[c].ColumnName);
                            }
                        }

                        // in the first row, get all of the quoted column names into a comma separated list
                    }
                    // the first time through we add them this way
                        if (i == 0)
                        {
                            sql_first_row_values += String.Format("{0}", values);
                        }
                        else
                        {
                            sql_values += String.Format("union select {0}", values);
                        }                                                              
                }

                string sql = "INSERT INTO " + tableName + sql_columns + ") SELECT " + sql_first_row_values + sql_values;

                try
                {
                    Constants_class.db.ExecuteNonQuery(sql);
                    if (confirmation_box == true)
                    {
                        MessageBox.Show("Added!");
                    }

                }

                catch (Exception fail)
                {

                    MessageBox.Show(fail.Message);
                    returnCode = false;
                }

                return returnCode;
            }

            public bool Insert(String tableName, Dictionary<string, string> data, bool confirmation_box)
            {

                String columns = "";

                String values = "";

                Boolean returnCode = true;

                foreach (KeyValuePair<string, string> val in data)
                {

                    columns += String.Format(" {0},", val.Key.ToString());

                    values += String.Format(" '{0}',", val.Value);

                }

                columns = columns.Substring(0, columns.Length - 1);

                values = values.Substring(0, values.Length - 1);


                try
                {

                    this.ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
                    if (confirmation_box == true) 
                    {
                       MessageBox.Show("Added!");
                    }

                }

                catch (Exception fail)
                {

                    MessageBox.Show(fail.Message);

                    returnCode = false;

                }

                return returnCode;

            }

            ///         ///     Allows the programmer to easily delete all data from the DB.         ///      

            ///         /// A boolean true or false to signify success or failure.       

            public bool ClearDB()
            {

                DataTable tables;
                try
                {

                    tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");

                    foreach (DataRow table in tables.Rows)
                    {

                        this.ClearTable(table["NAME"].ToString());

                    }

                    return true;

                }

                catch
                {

                    return false;

                }

            }

            ///         ///     Allows the user to easily clear all data from a specific table.         ///        

            ///         /// The name of the table to clear.         /// A boolean true or false to signify success or failure.       

            public bool ClearTable(String table)
            {                
                try
                {

                    this.ExecuteNonQuery(String.Format("delete from {0};", table));

                    return true;

                }

                catch
                {

                    return false;

                }

            }

            

            /// <summary>        /// The main entry point for the application.       

            /// </summary>      
            /// 

            /*public void most_recent_updater (string log_table, string final_table, string date_var, string name)
            {
                string ret = "SELECT max(date(" + date_var + ")) as max_date, " + name +" as name from " + log_table + " group by " + name;
                DataTable max_dates = db.GetDataTable(ret);
                Dictionary<String, string> data = new Dictionary<String, string>();

                foreach (DataRow dr in max_dates.Rows)
                {
                    string max_date = Convert.ToString(dr["max_date"]);
                    string name_logs = Convert.ToString(dr["name"]);
                    data.Add(date_var,max_date);    
                    //data.Add(name);
                    db.Update(final_table,data, "where "+ name + " = " + name_logs);
                }            
            }*/


            // allows the drag and drop to work. in partnership with using system.thread on homepage.cs
            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new Form1());
                /*Dictionary<String, string> update_historical_exercises = new Dictionary<String, string>();
                update_historical_exercises.Add("epley_e1rm", "30");
                Constants_class.db.Update("exercises", update_historical_exercises, "1=1");*/
                

                /*
                 AddFood addFood = new AddFood();
                if (addFood.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Exit(); 
                }
                  */

            }

        }

    }

}