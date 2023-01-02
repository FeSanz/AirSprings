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
using S7.Net;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using Timer = System.Windows.Forms.Timer;
using System.IO;

namespace AirSprings
{
    public partial class AirSprings : Form
    {
        /*VisionSensorStore store1 = new VisionSensorStore();
        VisionSensorStore store2 = new VisionSensorStore();
        IVisionSensor camera1;
        IVisionSensor camera2;

        Size image_size1 = new Size(640, 480); //320, 240
        Size image_size2 = new Size(640, 480); //320, 240*/

        DataTable list = new DataTable();

        int trigger = 0;

        private Plc plc = null;
        Timer timerRead = new Timer();

        public AirSprings()
        {
            InitializeComponent();
            InitializeVisionSystem();
        }

        private void InitializeVisionSystem()
        {
            /*try
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
            camera1.ResultUpdated += ResultCamera1Event;
            //camera1.ImageAcquired += ImageCamera1Event;

            camera2.EventEnable = true;
            camera2.ResultUpdated += ResultCamera2Event;
            //camera2.ImageAcquired += ImageCamera2Event;

            CameraTimer.Start();*/

            plc = new Plc(CpuType.S71200, "192.168.10.60", 0, 1);
            plc.Open();

            if (plc.IsConnected)
            {
                MessageBox.Show("Conectado a PLC");
            }
            else
            {
                MessageBox.Show("No se establecio conexión al PLC");
            }

            ZPLPrinterTCP("IP");
            //CPCLPrinterTCP("IP");
            //DNSPrinter("PrintName");
            //GraphicsUtilPrinter("IP");

            timerRead.Interval = 1000;
            timerRead.Tick += new EventHandler(ReadPLC);
            timerRead.Start();
        }

        private void ResultCamera1Event(object sender, ToolResultUpdatedEventArgs e)
        {
            /*//if (e[0].Ok)
            if (e.TotalStatusResult)
            {
                TextCamera1.Text = "OK";
                TextCamera1.ForeColor = Color.LimeGreen;
            }
            else
            {
                TextCamera1.Text = "NoOK";
                TextCamera1.ForeColor = Color.Red;
            }*/
        }

        private void ImageCamera1Event(object sender, ImageAcquiredEventArgs e)
        {
            /*var picture1 = new Bitmap(image_size1.Width,
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

            //Validar se el contenedor de la imagen esta vacio y colocar frame
            if (Camera1PictureBox.Image != null && Camera2PictureBox.Image != null)
            {
                Camera1PictureBox.Image.Dispose();
            }

            Camera1PictureBox.Image = picture1;*/
        }

        private void ResultCamera2Event(object sender, ToolResultUpdatedEventArgs e)
        {
            /*//if (e[0].Ok)
            if (e.TotalStatusResult)
            {
                TextCamera2.Text = "OK";
                TextCamera2.ForeColor = Color.LimeGreen;
            }             
            else          
            {             
                TextCamera2.Text = "NoOK";
                TextCamera2.ForeColor = Color.Red;
            }*/
        }

        private void ImageCamera2Event(object sender, ImageAcquiredEventArgs e)
        {
            /*var picture2 = new Bitmap(image_size2.Width,
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
            if (Camera2PictureBox.Image != null)
            {
                Camera2PictureBox.Image.Dispose();
            }

            Camera2PictureBox.Image = picture2;*/
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
            DebugTextBox.Visible= true;
            DebugTextBox.Text = "++++";
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
            /*camera1.TickTack();
            camera2.TickTack();
            //StatusBarLabel.Text = camera.ActiveProgram.ProgramName;

            //Detectar errores de la camara
            if(camera1.Errors.Length > 0)
            {
                TitleCamara1.Text = "Error. " + camera1.Errors[0].Description;
                TitleCamara1.ForeColor = Color.Red;
                camera1.ClearError(camera1.Errors[0]); //limpiar errores
            }
            else
            {
                TitleCamara1.Text = "CAMARA I (" + camera1.ActiveProgram.ProgramName + ")";
                TitleCamara1.ForeColor = Color.Black;
            }

            if (camera2.Errors.Length > 0)
            {
                TitleCamara2.Text = "Error. " + camera2.Errors[0].Description;
                TitleCamara2.ForeColor = Color.Red;
                camera1.ClearError(camera1.Errors[0]); //limpiar errores
            }
            else
            {
                TitleCamara2.Text = "CAMARA II (" + camera2.ActiveProgram.ProgramName + ")";
                TitleCamara2.ForeColor = Color.Black;
            }*/
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            /*camera1.Trigger();
            camera2.Trigger();*/
        }

        bool pieza = false;
        private void ReadPLC(object sender, EventArgs e)
        {
            /*byte[] buffer = plc.ReadBytes(DataType.Input, 0, 0, 1);

            if(buffer[0].SelectBit(0).ToString() == "True" ||
                buffer[0].SelectBit(1).ToString() == "True" ||
                buffer[0].SelectBit(2).ToString() == "True")
            {
                camera1.Trigger();
                camera2.Trigger();
                TextResult0.Text = buffer[0].SelectBit(0).ToString();
                TextResult1.Text = buffer[0].SelectBit(1).ToString();
                TextResult2.Text = buffer[0].SelectBit(2).ToString();
            }*/
            byte[] marcas = plc.ReadBytes(DataType.Memory, 0, 100, 1);
            DebugTextBox.Text = marcas[0].ToString();
            if (marcas[0] == 7)
            {
                if (!pieza)
                {
                    pieza = true;
                    MessageBox.Show("Pieza Ok");
                }
            }
            else
            {
                pieza = false;
                DebugTextBox.Text = marcas[0].ToString();
            }
        }


        private void ZPLPrinterTCP(string IpAddress)
        {
            // Instanciar la conexión para el puerto ZPL TCP
            Connection PrinterConn = new TcpConnection(IpAddress, TcpConnection.DEFAULT_ZPL_TCP_PORT);

            try
            {
                PrinterConn.Open();
                string zplData = "^XA^FO20,20^A0N,25,25^FDThis is a ZPL test.^FS^XZ";
                PrinterConn.Write(Encoding.UTF8.GetBytes(zplData));
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                PrinterConn.Close();
            }
        }

        private void CPCLPrinterTCP(string IpAddress)
        {
            // Instanciar la conexión para el puerto TCP CPCL
            Connection PrinterConn = new TcpConnection(IpAddress, TcpConnection.DEFAULT_CPCL_TCP_PORT);

            try
            {
                PrinterConn.Open();

                string cpclData = "! 0 200 200 210 1\r\n"
                + "TEXT 4 0 30 40 This is a CPCL test.\r\n"
                + "FORM\r\n"
                + "PRINT\r\n";

                PrinterConn.Write(Encoding.UTF8.GetBytes(cpclData));
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                PrinterConn.Close();
            }
        }

        private void DNSPrinter(string dnsName)
        {
            Connection connection = new TcpConnection(dnsName, 9100);
            try
            {
                connection.Open();
                ZebraPrinter p = ZebraPrinterFactory.GetInstance(connection);
                p.PrintConfigurationLabel();
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ZebraPrinterLanguageUnknownException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void GraphicsUtilPrinter(string IpAddress)
        {
            Connection connection = new TcpConnection(IpAddress, TcpConnection.DEFAULT_ZPL_TCP_PORT);
            try
            {
                connection.Open();
                ZebraPrinter printer = ZebraPrinterFactory.GetInstance(connection);

                int x = 0;
                int y = 0;
                printer.PrintImage("/path/to/my/image/sample.jpg", x, y);
            }
            catch (ConnectionException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ZebraPrinterLanguageUnknownException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
