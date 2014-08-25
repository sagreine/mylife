using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

using ConsoleApplication1.WindowsFormsApplication3;


// webcam!
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;

///////////////////////////////////////////////
// For webcam programming : ///////////////////
///////////////////////////////////////////////
// directshow
// http://directshownet.sourceforge.net/faq.html

// OR

// expression studio / expression blend / expression encoder
// http://www.microsoft.com/expression/eng/
////////////////////////////////////////////////


// hmm. next step appears to be draw a mostly transparent form above the imagebox that would hold the template in a transparent way...


namespace MyLife
{


    // code stolen from http://stackoverflow.com/questions/4503210/draw-semi-transparent-overlay-image-all-over-the-windows-form-having-some-contro
    // this is code to have a transparent overlaying form -- to display the templates

    // need to make these with a white background for this to work correctly
    class Plexiglass : Form
    {
        // this is the control that is covered by the form. blah pointers where is you
        Control covered_control;

        // originally parameter was a form. could leave it as a form, but set plexiglass location to control location?
        public Plexiglass(PictureBox tocover, Image img)
        {
            covered_control = tocover;
            this.ForeColor = Color.White;
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.BackgroundImage = img;
            this.Opacity = 0.40;      // Tweak as desired
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScaleMode = AutoScaleMode.None;
            this.Location =  tocover.PointToScreen(Point.Empty); //tocover.Controls["ImagePB"].PointToScreen(Point.Empty);
            this.ClientSize = tocover.ClientSize;
            tocover.Parent.LocationChanged += Cover_LocationChanged;
            tocover.Parent.ClientSizeChanged += Cover_ClientSizeChanged;
            this.Show(tocover);
            tocover.Focus();
            // Disable Aero transitions, the plexiglass gets too visible - I don't know what this means
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int value = 1;
                DwmSetWindowAttribute(tocover.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
            }
        }
        private void Cover_LocationChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass follows the owner
            this.Location = covered_control.PointToScreen(Point.Empty);
        }
        private void Cover_ClientSizeChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass keeps the owner covered
            this.ClientSize = covered_control.ClientSize;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Restore owner
            this.Owner.LocationChanged -= Cover_LocationChanged;
            this.Owner.ClientSizeChanged -= Cover_ClientSizeChanged;
            if (!this.Owner.IsDisposed && Environment.OSVersion.Version.Major >= 6)
            {
                int value = 1;
                DwmSetWindowAttribute(this.Owner.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
            }
            base.OnFormClosing(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            // Always keep the owner activated instead
            this.BeginInvoke(new Action(() => this.Owner.Activate()));
        }
        
        // i dont know what this part does at all to be honest.....
        private const int DWMWA_TRANSITIONS_FORCEDISABLED = 3;
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int value, int attrLen);

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Plexiglass
            // 
            this.ClientSize = new System.Drawing.Size(645, 350);
            this.Name = "Plexiglass";
            this.ResumeLayout(false);

        }
    }

    public partial class WebcamImageTaker : Form
    {
        // this is code stolen from another codeproject. I haven't looked into how/why it works. What it does is allow you to put a transparent image into a panel
        // hypothetically we would then be placing this somewhat transparent image on top of our previewpane for the webcam

        /*public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }*/

        Plexiglass template_transparent;
        //////////////////////////////////////////////////////////
        // much was copied from http://www.codeproject.com/Articles/202464/How-to-use-a-WebCam-in-C-with-the-NET-Framework-4?fid=1629539&fr=121&df=10000&mpp=10&noise=1&prof=True&sort=Position&view=Quick&spc=Relaxed#xx0xx
        //////////////////////////////////////////////////////////
        /// <summary>
        /// Creates job for capture of live source
        /// </summary>
        private LiveJob _job;

        /// <summary>
        /// Device for live source
        /// </summary>
        private LiveDeviceSource _deviceSource;

        // used if we allow videos
        private bool _bStartedRecording = false;
        //
        
        // put this here so we can optionally choose to save it or not, etc. This is quite inefficient though (mmmm, pointers)
        private Bitmap image;

        public WebcamImageTaker()
        {
            InitializeComponent();            
        }
        private void startup ()
        {
            //TemplateOutlinesCB.DataSource = ;
            TemplateOutlinesCB.SelectedValueChanged += new EventHandler(TemplateOutlinesCB_SelectedValueChanged);   
        }
        private void TemplateOutlinesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            // maybe set the BackColor to transparent, or that might not work 
            // will likely have to combine transparency and opacity (so that the overlay doesn't completely cover up the thing you see - or maybe that is fine?
            // if you cover up the template but the underlying image has no template in it that would be the ideal setup actually.
            // another thing is that the template isn't going to fit everyone, or may change over time for a person. that is probably a second level concern

            // http://msdn.microsoft.com/en-us/library/vstudio/ms743320(v=vs.100).aspx

            // imageBrush(image source) seems ideal here for the overlay.... kind of. would have to think about how to do background vs. foreground and what we want
            // to show up with what opacity. If we could make the template show up with 75% opacity or something that would be perfect - so they can still see
            // the image from the cam underneath the template

            // realistically we wouldn't do that in this function directly most likely but rather put this in another fucntion
        }


        private void TakePictureBtn_Click(object sender, EventArgs e)
        {
            // remvoe the template from the image when we save it - do we want to keep it in our preview/review though, so we can see how close to the template we are?
            // i have no idea if this is a good idea or not. We don't want to continually create new ones over and over again without deleting them though.
            if (template_transparent.BackgroundImage != null)
            {
                template_transparent.Dispose();
            }

            // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
            //using (Bitmap bitmap = new Bitmap(ImagePB.Width, ImagePB.Height))
            Bitmap bitmap = new Bitmap(ImagePB.Width, ImagePB.Height);
            //{
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Get the paramters to call g.CopyFromScreen and get the image
                    Rectangle rectanglePanelVideoPreview = ImagePB.Bounds;
                    Point sourcePoints = ImagePB.PointToScreen(new Point(ImagePB.ClientRectangle.X, ImagePB.ClientRectangle.Y));
                    g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);                    
                }

                // here we would save the image to the db, or maybe we would save the image to the Graphics g local variable in this class
                // so that we could later save it into the database if we wanted to. Should we show a preview to the user somewhere? Pop it up?

                image = bitmap;
                // save the image to a file
                //string strGrabFileName = String.Format("C:\\Snapshots\\Snapshot_{0:yyyyMMdd_hhmmss}.jpg", DateTime.Now);                
                //bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            //}
            StopJob();
            ImagePB.Image = image;
        }
        // allows video files to be created, wmv
        /*private void btnStartStopRecording_Click(object sender, EventArgs e)
        {
            // Is it Recoring ?
            if (_bStartedRecording)
            {
                // Yes
                // Stops encoding
                _job.StopEncoding();
                btnStartStopRecording.Text = "Start Recording";
                toolStripStatusLabel1.Text = "";
                _bStartedRecording = false;
            }
            else
            {
                // Sets up publishing format for file archival type
                FileArchivePublishFormat fileOut = new FileArchivePublishFormat();

                // Sets file path and name
                fileOut.OutputFileName = String.Format("C:\\WebCam{0:yyyyMMdd_hhmmss}.wmv", DateTime.Now);

                // Adds the format to the job. You can add additional formats as well such as
                // Publishing streams or broadcasting from a port
                _job.PublishFormats.Add(fileOut);

                // Start encoding
                _job.StartEncoding();

                btnStartStopRecording.Text = "Stop Recording";
                toolStripStatusLabel1.Text = fileOut.OutputFileName;
                _bStartedRecording = true;
            }
        }*/



        void StopJob()
        {
            // Has the Job already been created ?
            if (_job != null)
            {
                // Yes
                // Is it capturing ?
                //if (_job.IsCapturing)

                // remove as we won't allow videos right now
                //if (_bStartedRecording)
                //{
                    // Yes
                    // Stop Capturing
                  //  btnStartStopRecording.PerformClick();
                //}

                _job.StopEncoding();

                if (_job.DeviceSources.Count() != 0) // added this line and don't know if that is appropriate. this might leak memory or be otherwise stupid
                {// added this line and don't know if that is appropriate

                    // Remove the Device Source and destroy the job
                    _job.RemoveDeviceSource(_deviceSource);

                    // Destroy the device source
                    _deviceSource.PreviewWindow = null;
                    _deviceSource = null;

                }// added this line and don't know if that is appropriate

            }
        }

        private void WebcamImageTaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopJob();
        }

        private void WebcamImageTaker_Load(object sender, EventArgs e)
        {
            this.Text += " - ver. " + Application.ProductVersion;

            lstVideoDevices.ClearSelected();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                lstVideoDevices.Items.Add(edv.Name);
            }
            //lblVideoDeviceSelectedForPreview.Text = "";

            lstAudioDevices.ClearSelected();
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                lstAudioDevices.Items.Add(eda.Name);
            }
            
            // load a sample template into the imagebox
            //Bitmap tmplt = new Bitmap("C:\\Snapshots\\sample_template.png");
            //tmplt.
            //ImagePB.BackgroundImage.
            //TextureBrush br = new Brush;
            
            //ImagePB.BackgroundImage = ChangeOpacity(tmplt, .1F);            
        }
        
        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;

            //lblVideoDeviceSelectedForPreview.Text = "";
            //lblAudioDeviceSelectedForPreview.Text = "";

            if (lstVideoDevices.SelectedIndex < 0 || lstAudioDevices.SelectedIndex < 0)
            {
                MessageBox.Show("No Video and Audio capture devices have been selected.\nSelect an audio and video devices from the listboxes and try again.", "Warning");
                return;
            }

            // Get the selected video device            
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, lstVideoDevices.SelectedItem.ToString()) == 0)
                {
                    video = edv;
                    //lblVideoDeviceSelectedForPreview.Text = edv.Name;
                    break;
                }
            }

            // Get the selected audio device            
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (String.Compare(eda.Name, lstAudioDevices.SelectedItem.ToString()) == 0)
                {
                    audio = eda;
                    //lblAudioDeviceSelectedForPreview.Text = eda.Name;
                    break;
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            EncoderDevice video = null;
            EncoderDevice audio = null;

            GetSelectedVideoAndAudioDevices(out video, out audio);
            StopJob();

            if (video == null)
            {
                return;
            }

            // Starts new job for preview window
            _job = new LiveJob();

            // Checks for a/v devices
            if (video != null && audio != null)
            {
                // Create a new device source. We use the first audio and video devices on the system
                _deviceSource = _job.AddDeviceSource(video, audio);
                  
                // Setup the video resolution and frame rate of the video device
                // NOTE: Of course, the resolution and frame rate you specify must be supported by the device!
                // NOTE2: May be not all video devices support this call, and so it just doesn't work, as if you don't call it (no error is raised)
                // NOTE3: As a workaround, if the .PickBestVideoFormat method doesn't work, you could force the resolution in the 
                //        following instructions (called few lines belows): 'panelVideoPreview.Size=' and '_job.OutputFormat.VideoProfile.Size=' 
                //        to be the one you choosed (640, 480).
                _deviceSource.PickBestVideoFormat(new Size(640, 480), 15);

                // Get the properties of the device video
                SourceProperties sp = _deviceSource.SourcePropertiesSnapshot();

                // Resize the preview panel to match the video device resolution set
                ImagePB.Size = new Size(sp.Size.Width, sp.Size.Height);

                // Setup the output video resolution file as the preview
                _job.OutputFormat.VideoProfile.Size = new Size(sp.Size.Width, sp.Size.Height);

                // Display the video device properties set
                // toolStripStatusLabel1.Text = sp.Size.Width.ToString() + "x" + sp.Size.Height.ToString() + "  " + sp.FrameRate.ToString() + " fps";

                // Sets preview window to winform panel hosted by xaml window
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(ImagePB, ImagePB.Handle));
                                
                // Make this source the active one
                _job.ActivateSource(_deviceSource);

                // btnStartStopRecording.Enabled = true;
                TakePictureBtn.Enabled = true;

                /*Form tmplt_F = new Form();
                tmplt_F.Location = ImagePB.Location;
                //tmplt_F.StartPosition = ImagePB.Location;
                tmplt_F.Location = ImagePB.PointToClient(Point.Empty);
                tmplt_F.Size = ImagePB.Size;
                tmplt_F.Opacity = .2;
                tmplt_F.BackgroundImage = new Bitmap("C:\\Snapshots\\sample_template.png");
                tmplt_F.Show();
                tmplt_F.ShowInTaskbar = false;
                //tmplt_F.MainMenuStrip = null;
                //tmplt_F.Menu = null;
                tmplt_F.ShowIcon = false;
                tmplt_F.FormBorderStyle = FormBorderStyle.None;
                tmplt_F.ControlBox = false;*/
                template_transparent = new Plexiglass(ImagePB, new Bitmap("C:\\Snapshots\\sample_template.png"));

                // this doesn't work. tried to put the template-y thing on top of the preview screen is hard.

                // load a sample template into the imagebox
                //Bitmap tmplt = new Bitmap("C:\\Snapshots\\sample_template.png");
                
                ///tmplt.
                ///ImagePB.BackgroundImage.
                ///TextureBrush br = new Brush;

                //PictureBox pb = new PictureBox();
                //pb.Size = new Size(sp.Size.Width, sp.Size.Height);
                //pb.Location = ImagePB.Location;
                //pb.BackgroundImage = tmplt;
                //pb.Location = new System.Drawing.Point(0, 0);
                //this.Controls.Add(pb);

//                System.Threading.Thread.Sleep(5000);              

                //Button btn = new Button();
                //btn.Location = new System.Drawing.Point(0, 0);
                //this.Controls.Add(btn);                

                //toolStripStatusLabel1.Text = "Preview activated";
            }
            else
            {
                // Gives error message as no audio and/or video devices found
                MessageBox.Show("No Video/Audio capture devices have been found.", "Warning");                
            }
        }

        private void SavePictureBtn_Click(object sender, EventArgs e)
        {
            // ideally we would put the same description text box etc. on here. Or, maybe just put this whole thing onto the measurements and images page?
            // why is it a separate page anyway?
            //helperfns.insert_image_to_db(ImageDescriptionTB.Text, DateImageTakenDTP.Value.ToString("yyyyMMdd"), BodyPart_CB.Text, pictureBox);
            // insert image into the database. It is currently a bitmap
        }

    }
}
