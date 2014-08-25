using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Constants;
using ConsoleApplication1.WindowsFormsApplication3;

using System.IO;


// allow them to tag an image with a body measurement body part (pull from that same list)


namespace MyLife
{
    public partial class BodyMeasurements : Form
    {
        public BodyMeasurements()
        {
            InitializeComponent();
            update_images_list();   

            // this was actually commented out
            //SavedImagesCB.SelectedValueChanged +=new EventHandler(SavedImagesCB_SelectedValueChanged);

            int number_of_measures = init_current_measurements();   
            
            // if there are no body parts that have been added, initialize it with (4? 6?) blank ones to add ... do this later
            // put the loop thing into a function of itself to make this easier
        }

        #region measurements

        public void add_row_to_measurements_tlp(int body_part)
        {
            Label body_part_id_lbl = new Label();
            body_part_id_lbl.Name = "body_part_id" + body_part.ToString();
            body_part_id_lbl.Anchor = AnchorStyles.Top;
            Measurements_TLP.Controls.Add(body_part_id_lbl, 0, Measurements_TLP.RowCount);

            TextBox this_body_part = new TextBox();
            this_body_part.Name = "body_part" + body_part.ToString();
            //this_body_part.Size = new System.Drawing.Size(50, 20);
            this_body_part.ReadOnly = true;
            this_body_part.Anchor = AnchorStyles.Top;
            Measurements_TLP.Controls.Add(this_body_part, 1, Measurements_TLP.RowCount);

            NumericUpDown this_measurement_value = new NumericUpDown();
            this_measurement_value.Name = "measurement_value" + body_part.ToString();
            this_measurement_value.Anchor = AnchorStyles.Top;
            Measurements_TLP.Controls.Add(this_measurement_value, 2, Measurements_TLP.RowCount);

            DateTimePicker this_measure_logged_dt = new DateTimePicker();
            this_measure_logged_dt.Name = "date_measured" + body_part.ToString();
            this_measure_logged_dt.Anchor = AnchorStyles.Top;
            this_measure_logged_dt.Format = DateTimePickerFormat.Short;
            Measurements_TLP.Controls.Add(this_measure_logged_dt, 3, Measurements_TLP.RowCount);

            Measurements_TLP.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Measurements_TLP.RowCount = Measurements_TLP.RowStyles.Count;
        }
        // untested
        public int init_current_measurements()
        {            
            // Get the most up to date measurements currently in the db
            DataTable current_measurements = Constants_class.db.GetDataTable
               ("Select bm.body_part_id, bm.body_part, bm.measurement_value, bm.date_measured from " +
                "(select distinct body_part_id, max(date_measured) as max_date_measured from body_measurements group by body_part_id) mx inner join " +
                "body_measurements bm where mx.body_part_id = bm.body_part_id and mx.max_date_measured = bm.date_measured " +
                "order by bm.body_part_id");

            // not sure how this works, but the idea is to set body_part_id as the primary key of the table to help when we check
            // to see if anything has been updated before inserting rows into the db
            //current_measurements.PrimaryKey = new DataColumn[] { current_measurements.Columns["body_part_id"] };

            
            // If a new measurement has
            // been added, add another row to the table that is blank so they can add new body parts to measure.

            for (int body_part = 0; body_part < current_measurements.Rows.Count; body_part++)
            {                
                // add the new row of controls to Measurements_TLP
                add_row_to_measurements_tlp(body_part);

                // put the value in for the controls values
                Measurements_TLP.Controls["body_part_id" + body_part.ToString()].Text = current_measurements.Rows[body_part]["body_part_id"].ToString();
                Measurements_TLP.Controls["body_part" + body_part.ToString()].Text = current_measurements.Rows[body_part]["body_part"].ToString();
                ((NumericUpDown)Measurements_TLP.Controls["measurement_value" + body_part.ToString()]).Value = Convert.ToDecimal(current_measurements.Rows[body_part]["measurement_value"]);
                ((DateTimePicker)Measurements_TLP.Controls["date_measured" + body_part.ToString()]).Value = DateTime.ParseExact(current_measurements.Rows[body_part]["date_measured"].ToString(), "yyyyMMdd",
                      System.Globalization.CultureInfo.InvariantCulture);
            }
            return current_measurements.Rows.Count;
        }

        // this checks to see if any field in the measurements thing has been updated, and if it has to include it to update query
        // in the db. Pretty sucky, cuz it has to query once for every record it wants to update due to SQL syntax (AFAIK)
        private Dictionary<string,string> upsert_measurements(string body_part_name, decimal measurement_value, int date_measured)
        {
           Dictionary<string,string> this_row = new Dictionary<string,string>();
           this_row.Add("body_part",body_part_name);
           this_row.Add("measurement_value",Convert.ToString(measurement_value));
           this_row.Add("date_measured",Convert.ToString(date_measured));
           //DateTime Today = new DateTime();
           //Today = DateTime.Today;
           this_row.Add("date_logged",Convert.ToString(int.Parse((DateTime.Today).ToString("yyyyMMdd"))));
           return this_row;
        }
        // could replace the whole table, or create a temp table and a left join based on that temp table or something but then
        // making the date_uploaded field update only if it is in the temp table...
        private void UpdateMeasurementsButton_Click(object sender, EventArgs e)
        {
            // first check that anything has been updated 
            // could do this using event driven actions on the individual rows of the table grid...

            // Get what is in the db right now, so we can compare it to what is in the db
            DataTable current_measurements = Constants_class.db.GetDataTable
               ("Select bm.body_part_id, bm.body_part, bm.measurement_value, bm.date_measured from " +
                "(select body_part_id, max(date_measured) as max_date_measured from body_measurements group by body_part_id) mx inner join " +
                "body_measurements bm where mx.body_part_id = bm.body_part_id and mx.max_date_measured = bm.date_measured " +
                "order by bm.body_part_id");
            
            current_measurements.PrimaryKey = new DataColumn[] { current_measurements.Columns["body_part_id"] };

            // Compare this to what is in the items now
            //foreach (var given_week in this.Measurements_TLP.Controls.OfType<Label>())
            //{

            //}

            // make an empty copy of the current_measurements table, as this will serve as the template to insert rows
            DataTable to_insert = new DataTable();
            to_insert = current_measurements.Copy();
            to_insert.Clear();

            // remove all of the rows of to_insert
            for (int i = to_insert.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = to_insert.Rows[i];
                if (row.RowState == DataRowState.Deleted) { to_insert.Rows.RemoveAt(i); }
            }


            // start at 1 so we don't process the labels. (pukes)
            for (int body_part = 1; body_part < Measurements_TLP.RowCount; body_part++)
            {                
                string body_part_name = Measurements_TLP.GetControlFromPosition(1, body_part).Text;
                decimal measurement_value = ((NumericUpDown)Measurements_TLP.GetControlFromPosition(2, body_part)).Value;
                // get integer from datetime. This is pretty stupid overall
                int date_measured = int.Parse(((DateTimePicker)Measurements_TLP.GetControlFromPosition(3, body_part)).Value.ToString("yyyyMMdd"));//.Value;                    
                Dictionary<string,string> this_row = new Dictionary<string,string>();

                // if this body_part already existed (why not just do that............. check if the unique ID in tablelayoutpanel col 0 is in the
                // table we get from the db
                // this way we check against previous records to see if any of the data has changed, so we don't insert if not necessary
                if (body_part > current_measurements.Rows.Count)
                {
                    string key = Measurements_TLP.GetControlFromPosition(0, body_part).Text;
                    Int32 num_key = Convert.ToInt32(key);
                    DataRow dr = current_measurements.Rows.Find(num_key);
                    if (body_part_name != dr["body_part"].ToString() ||
                        measurement_value != Convert.ToDecimal(dr["measurement_value"].ToString()) ||
                        date_measured != Convert.ToInt32(dr["date_measured"].ToString()))
                    {
                        Constants_class.db.Insert("Body_Measurements",
                                 upsert_measurements(body_part_name, measurement_value, date_measured), false);
                    }
                }
                // if this is a new control.... check to make sure the measurement name is not null before entering it into the db
                else
                {
                    Constants_class.db.Insert("Body_Measurements",
                             upsert_measurements(body_part_name,measurement_value,date_measured), false);
                }
             }
         }                    

        #endregion

        #region images
        // bring an image into the pane to view
        private void SelectImageButton_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.gif, *.bmp, *.jpg, *.img)| *.jpg;*.bmp;*.gif;*.img";            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = dialog.FileName;
                SaveImageButton.Enabled = true;
            }
        }

        // save image into the db
        private void SaveImageButton_Click(object sender, EventArgs e)
        {

            // if there is no description throw an error. Obviously this is stupid.
            if (string.IsNullOrEmpty(ImageDescriptionTB.Text) == true)
            {
                MessageBox.Show("Please enter description of photo in box below");
                return;
            }

            helperfns.insert_image_to_db(ImageDescriptionTB.Text, DateImageTakenDTP.Value.ToString("yyyyMMdd"), BodyPart_CB.Text, pictureBox);

            // update the images list of available images
            update_images_list();

            /*SQLiteConnection cnn = new SQLiteConnection(Constants.Constants_class.db.dbConnection);
            cnn.Open();
            SQLiteCommand command =  cnn.CreateCommand();
            command.CommandText = String.Format("INSERT INTO Images" +
               "(Description, Date_Taken, Date_Uploaded, body_part, Image) VALUES" +
                "(@0, '{1}', '{2}', '{3}',  @1)",
            ImageDescriptionTB.Text, DateImageTakenDTP.Value.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"), BodyPart_CB.Text);
            SQLiteParameter description_p = new SQLiteParameter("@0");
            SQLiteParameter image_p = new SQLiteParameter("@1", System.Data.DbType.Binary);
            description_p.Value = ImageDescriptionTB.Text;
            command.Parameters.Add(description_p);*/
 
           /*byte[] rawDoc = null;
             using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                rawDoc = ms.ToArray();                
            }

           image_p.Value = rawDoc;
           command.Parameters.Add(image_p);
           command.ExecuteNonQuery();
           cnn.Close();*/

            // potentially another way to do this
            /*////////////////////////////////////////////////
            Image image = null;
            using (FileStream stream = File.Open(oif.FileName, FileMode.Open))
             {
               BinaryReader br = new BinaryReader(stream);
               byte[] data = br.ReadBytes(5242880);
               image = new Image(oif.FileName, data, 5242880);
             }
             /////////////////////////////////////////////////*/

        }
        public void getImage(string dbTable, string idvariable, string idval, string imagevariable) 
        {
          
          //When you retrieve the BLOB, get it from SQliteDataReader this way:
          SQLiteConnection cnn = new SQLiteConnection(Constants.Constants_class.db.dbConnection);
          cnn.Open();
          string sql = "select " + imagevariable + " from " + dbTable + " where " + idvariable + " = " + idval;
          SQLiteCommand myCommand = new SQLiteCommand(sql, cnn);
          SQLiteDataReader myDataReader = myCommand.ExecuteReader();

           byte[] imageBytes = null;
           while (myDataReader.Read())
           {
               imageBytes = (System.Byte[])myDataReader[imagevariable];
           }
           MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
           ms.Write(imageBytes, 0, imageBytes.Length);
           pictureBox.Image = Image.FromStream(ms, true);
           pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
 
           cnn.Close();
        } 
        // get the list of saved images from the db
        public void update_images_list()
        {
            // why doesnt this remove the event handler from the event...
            SavedImagesCB.SelectedValueChanged -= new EventHandler(SavedImagesCB_SelectedValueChanged);            
            
            SavedImagesCB.DataSource = null;
            SavedImagesCB.ValueMember = "images_id";
            SavedImagesCB.DisplayMember = "description";
            SavedImagesCB.DataSource =  Constants.Constants_class.db.GetDataTable(
                "select images_id, description, date_taken, date_uploaded from Images order by date_uploaded desc");

            SavedImagesCB.SelectedValueChanged += new EventHandler(SavedImagesCB_SelectedValueChanged);

            DataTable abc = Constants.Constants_class.db.GetDataTable("select * from Images");

            // do this using one query numbnuts
            // update the list of body parts that have been uploaded so far
            //BodyPart_CB.DataSource = Constants.Constants_class.db.GetDataTable("select distinct body_part from Images order by body_part desc");

            // do we want to put the most recently added to the db image in here? This would make it easier for when we add images via the webcam
        }

        private void SavedImagesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            getImage("Images", "Images_id", SavedImagesCB.SelectedValue.ToString(),"Image");
        }
        #endregion 

        private void AddBodyPartButton_Click(object sender, EventArgs e)
        {
            // add a new row of controls... it might be necessary to do a RowCount + 1 instead of RowCount...
            add_row_to_measurements_tlp(Measurements_TLP.RowCount);
        }

        private void FlipbookButton_Click(object sender, EventArgs e)
        {            
            Flipbook flipbook = new Flipbook();
            flipbook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebcamImageTaker wct = new WebcamImageTaker();
            wct.ShowDialog();
            // do we need to check if the dialogresult is ok? It seems they could take multiple pictures and then x-out or something.
            if (DialogResult == DialogResult.OK)
            {
                // here we would put it into the database, load it into the pane, update the list of images, etc.
                update_images_list();
            }            
        }


    }
}
