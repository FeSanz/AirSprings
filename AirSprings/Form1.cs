using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Keyence.IV2.Sdk;

namespace AirSprings
{
    public partial class AirSprings : Form
    {
        VisionSensorStore store1 = new VisionSensorStore();
        VisionSensorStore store2 = new VisionSensorStore();
        IVisionSensor camera1;
        IVisionSensor camera2;

        Size image_size1 = new Size(640, 480); //320, 240
        Size image_size2 = new Size(640, 480); //320, 240

        DataTable list = new DataTable();

        public AirSprings()
        {
            InitializeComponent();
            InitializeVisionSystem();
        }

        private void InitializeVisionSystem()
        {
            try
            {
                byte[] IPAdressLocal = { 192, 168, 10, 49 }; // ip de la PC local
                IPAddress IPLocal = new IPAddress(IPAdressLocal);
                VisionSensorStore.StartPoint = IPLocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message.ToString());
            }

            byte[] IPAddressCamera1 = { 192, 168, 10, 51 }; // ip de la camara 1
            IPAddress IPCamera1 = new IPAddress(IPAddressCamera1);
            camera1 = store1.Create(IPCamera1, 63000); //ip y puerto

            byte[] IPAddressCamera2 = { 192, 168, 10, 52 }; // ip de la camara 2
            IPAddress IPCamera2 = new IPAddress(IPAddressCamera2);
            camera2 = store2.Create(IPCamera2, 63000); //ip y puerto

            camera1.EventEnable = true;
            camera1.ResultUpdated += ResultCameraEvent;
            camera1.ImageAcquired += ImageCameraEvent;

            camera2.EventEnable = true;
            camera2.ResultUpdated += ResultCameraEvent;
            camera2.ImageAcquired += ImageCameraEvent;

            CameraTimer.Start();
        }

        private void ResultCameraEvent(object sender, ToolResultUpdatedEventArgs e)
        {
            //if (e.TotalStatusResult)
            if (e[0].Ok)
            {
                StatusBarLabel.Text = "OK";
                StatusBarLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                StatusBarLabel.Text = "NoOK";
                StatusBarLabel.ForeColor = Color.Red;
            }
        }

        private void ImageCameraEvent(object sender, ImageAcquiredEventArgs e)
        {
            var picture1 = new Bitmap(image_size1.Width,
                                    image_size1.Height,
                                    PixelFormat.Format24bppRgb);

            BitmapData bitmapData1 = picture1.LockBits(new Rectangle(Point.Empty, image_size1),
                                                ImageLockMode.WriteOnly,
                                                PixelFormat.Format24bppRgb);
            //Asignar bits de datos a BITMAPDATA
            Marshal.Copy(e.LiveImage.ByteData, 0, bitmapData1.Scan0, e.LiveImage.ByteData.Length);
            picture1.UnlockBits(bitmapData1);

            //Colocar marcadores en la captura
            using (Graphics target1 = Graphics.FromImage(picture1))
            {
                target1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (byte i = 0; i < 16; i++)
                {
                    camera1.DrawWindow(target1, Color.Green, Color.Red, i);
                }
            }

            /****************************************************************************/
            var picture2 = new Bitmap(image_size2.Width,
                        image_size2.Height,
                        PixelFormat.Format24bppRgb);

            BitmapData bitmapData2 = picture2.LockBits(new Rectangle(Point.Empty, image_size2),
                                                   ImageLockMode.WriteOnly,
                                                   PixelFormat.Format24bppRgb);
            //Asignar bits de datos a BITMAPDATA
            Marshal.Copy(e.LiveImage.ByteData, 0, bitmapData2.Scan0, e.LiveImage.ByteData.Length);
            picture2.UnlockBits(bitmapData2);

            //Colocar marcadores en la captura
            using (Graphics target2 = Graphics.FromImage(picture2))
            {
                target2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (byte i = 0; i < 16; i++)
                {
                    camera1.DrawWindow(target2, Color.Green, Color.Red, i);
                }
            }

            //Validar se el contenedor de la imagen esta vacio y colocar frame
            if (Camera1PictureBox.Image != null && Camera2PictureBox.Image != null)
            {
                Camera1PictureBox.Image.Dispose();
                Camera2PictureBox.Image.Dispose();
            }

            Camera1PictureBox.Image = picture1;
            Camera2PictureBox.Image = picture2;
        }

        private void AirSprings_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = true;

            list.Columns.Add("Spring", typeof(string));
            SpringsDataGrid.DataSource = list;
            SpringsDataGrid.ColumnHeadersVisible = false;
            SpringsDataGrid.RowHeadersVisible = false;
            SpringsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;

            /*Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();*/
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;

            Application.Exit();
        }

       
        private void PrintButton_Click(object sender, EventArgs e)
        {
            /*String codeBar = OrderTextBox.Text;

            int row = SpringsDataGrid.Rows.Add();

            SpringsDataGrid.Rows[row].Cells[0].Value = codeBar;*/

            list.Rows.Add(OrderTextBox.Text);
            SpringsDataGrid.DataSource = list;
        }

        private void CameraTimer_Tick(object sender, EventArgs e)
        {
            camera1.TickTack();
            camera2.TickTack();
            //StatusBarLabel.Text = camera.ActiveProgram.ProgramName;

            //Detectar errores de la camara
            if(camera1.Errors.Length > 0 || camera2.Errors.Length > 0)
            {
                MessageBox.Show(camera1.Errors[0].Description);
                camera1.ClearError(camera1.Errors[0]); //limpiar errores
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            camera1.Trigger();
            camera2.Trigger();
        }

        private void ThreadTask()
        {
            int stp;
            int newval;
            Random rnd = new Random();

            while (true)
            {
               /* stp = ProgressBarThread.Step * rnd.Next(-1, 2);
                newval = ProgressBarThread.Value + stp;
                if (newval > ProgressBarThread.Maximum)
                    newval = ProgressBarThread.Maximum;
                else if (newval < ProgressBarThread.Minimum)
                    newval = ProgressBarThread.Minimum;
                ProgressBarThread.Value = newval;
                Thread.Sleep(100);*/
            }
        }
    }
}
