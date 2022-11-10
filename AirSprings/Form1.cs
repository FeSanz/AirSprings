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
using Keyence.IV2.Sdk;

namespace AirSprings
{
    public partial class AirSprings : Form
    {
        VisionSensorStore store = new VisionSensorStore();
        IVisionSensor camera;

        Size image_size = new Size(640, 480); //320, 240

        DataTable list = new DataTable();

        public AirSprings()
        {
            InitializeComponent();
            //InitializeVisionSystem();
        }

        private void InitializeVisionSystem()
        {
            try
            {
                byte[] IPAdressLocal = { 192, 168, 0, 23 }; // ip de la PC local
                IPAddress IPLocal = new IPAddress(IPAdressLocal);
                VisionSensorStore.StartPoint = IPLocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message.ToString());
            }

            byte[] IPAddressCamera = { 192, 168, 0, 23 }; // ip de la camara
            IPAddress IPCamera = new IPAddress(IPAddressCamera);
            camera = store.Create(IPCamera, 63000); //ip y puerto

            camera.EventEnable = true;
            camera.ResultUpdated += ResultCameraEvent;
            camera.ImageAcquired += ImageCameraEvent;

            CameraTimer.Start();
        }

        private void ResultCameraEvent(object sender, ToolResultUpdatedEventArgs e)
        {
            if (e.TotalStatusResult)
            {
                StatusBarLabel.Text = "Conexión establecida con la cámara";
                StatusBarLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                MessageBox.Show("No se pudo establecer conexion con la cámara");
            }
        }

        private void ImageCameraEvent(object sender, ImageAcquiredEventArgs e)
        {
            var picture = new Bitmap(image_size.Width,
                                    image_size.Height,
                                    PixelFormat.Format24bppRgb);
            BitmapData bitmapData = picture.LockBits(new Rectangle(Point.Empty, image_size),
                                                    ImageLockMode.WriteOnly,
                                                    PixelFormat.Format24bppRgb);
            //Asignar bits de datos a BITMAPDATA
            Marshal.Copy(e.LiveImage.ByteData, 0, bitmapData.Scan0, e.LiveImage.ByteData.Length);
            picture.UnlockBits(bitmapData);

            //Colocar marcadores en la captura
            using (Graphics target = Graphics.FromImage(picture))
            {
                target.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (byte i = 0; i < 16; i++)
                {
                    camera.DrawWindow(target, Color.Green, Color.Red, i);
                }
            }

            //Validar se el contenedor de la imagen esta vacio y colocar frame
            if (CameraPictureBox.Image != null)
            {
                CameraPictureBox.Image.Dispose();
            }

            CameraPictureBox.Image = picture;
        }

        private void AirSprings_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            list.Columns.Add("Spring", typeof(string));
            SpringsDataGrid.DataSource = list;
            SpringsDataGrid.ColumnHeadersVisible = false;
            SpringsDataGrid.RowHeadersVisible = false;
            SpringsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;

            System.Windows.Forms.Application.Exit();
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
            camera.TickTack();
            StatusBarLabel.Text = camera.ActiveProgram.ProgramName;

            //Detectar errores de la camara
            if(camera.Errors.Length > 0)
            {
                MessageBox.Show(camera.Errors[0].Description);
                camera.ClearError(camera.Errors[0]); //limpiar errores
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            camera.Trigger();
        }
    }
}
