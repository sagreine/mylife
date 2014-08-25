using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SQLite;

namespace MyLife
{
    public partial class Flipbook : Form
    {
        private DataTable images_to_show;

        public Flipbook()
        {
            InitializeComponent();
            BodyPartList_CB.DataSource = Constants.Constants_class.db.GetDataTable("select distinct body_part from Images");
            
            // below line is meant to not select anything in the list of body parts. This might not work, or might not be necessary, or maybe is right just how it is
            // the idea is that we don't want to limit the Images right off the bat until they are ordered to be limited by the user
            BodyPartList_CB.SelectedIndex = -1;
            BodyPartList_CB.SelectedIndexChanged += new EventHandler(BodyPartList_CB_SelectedIndexChanged);
        }
        private void BodyPartList_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_images_to_pick_from();
        }

        private void update_images_to_pick_from()
        {
            images_CLB.DisplayMember = "date_taken";
            images_CLB.ValueMember = "images_id";
            images_to_show = Constants.Constants_class.db.GetDataTable("select images_id, description, date_taken from Images where body_part = '" + BodyPartList_CB.SelectedItem
                                     + "' order by date_taken desc");
            images_CLB.DataSource = images_to_show;
        }

        private void FlipPlayButton_Click(object sender, EventArgs e)
        {
            // 'Play' each item
            for (int i = 0; i < images_CLB.CheckedItems.Count; i++)
            {
             //   main_picture_box.Image = images_to_show.Select(i).["Image"];
            }
          SQLiteConnection cnn = new SQLiteConnection(Constants.Constants_class.db.dbConnection);
          cnn.Open();
          string sql = "select images_id, Image from Images where body_part = '" + BodyPartList_CB.SelectedItem + "' order by body_part, date_taken desc";
          SQLiteCommand myCommand = new SQLiteCommand(sql, cnn);
          SQLiteDataReader myDataReader = myCommand.ExecuteReader();


          /*string strcmd = "select mimage from movie where mname='" + MOvieCombo.SelectedItem.ToString() + "'";
             con = new SqlCeConnection(Connectionstring);
            SqlCeCommand cmd = new SqlCeCommand(strcmd, con);
            con.Open();
            
           * 
           * string[] strfn;
           * for( 1 to images_CLB.CheckedItems.Count)
            {
           * byte[] barrImg = (byte[])cmd.ExecuteScalar();
           * string strfn[i] = "image" + i.ToString();
            FileStream fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
            fs.Write(barrImg, 0, barrImg.Length);
            fs.Flush();
            fs.Close();
           * Thread.Sleep(DelayTime_UD.Value);
           * }
            main_picture_box.Image = Image.FromFile(strfn);*/

          //DataSet ds = new DataSet();
          

           byte[] imageBytes = null;
           while (myDataReader.Read())
           {
               imageBytes = (System.Byte[])myDataReader[0];
           }
           MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
           ms.Write(imageBytes, 0, imageBytes.Length);
           main_picture_box.Image = Image.FromStream(ms, true);
           main_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
 
           cnn.Close();
        }
    }
}
