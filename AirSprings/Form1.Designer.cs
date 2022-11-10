using System.Drawing;

namespace AirSprings
{
    partial class AirSprings
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SpringsTabControl = new System.Windows.Forms.TabControl();
            this.Packing = new System.Windows.Forms.TabPage();
            this.TopLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CartonGroupBox = new System.Windows.Forms.GroupBox();
            this.CartonTextBox = new System.Windows.Forms.TextBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
            this.ListLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SpringsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpringsDataGrid = new System.Windows.Forms.DataGridView();
            this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.LoteGropuBox = new System.Windows.Forms.GroupBox();
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            this.ComponentsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Lote02Label = new System.Windows.Forms.Label();
            this.Lote02TextBox = new System.Windows.Forms.TextBox();
            this.Lote01TextBox = new System.Windows.Forms.TextBox();
            this.Lote01Label = new System.Windows.Forms.Label();
            this.BottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DeclineGrupBox = new System.Windows.Forms.GroupBox();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.DeclineTextBox = new System.Windows.Forms.TextBox();
            this.CameraTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpringsTabControl.SuspendLayout();
            this.Packing.SuspendLayout();
            this.TopLayoutPanel.SuspendLayout();
            this.OrdersLayoutPanel.SuspendLayout();
            this.CartonGroupBox.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ListLayoutPanel.SuspendLayout();
            this.SpringsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpringsDataGrid)).BeginInit();
            this.RightLayoutPanel.SuspendLayout();
            this.OperatorGroupBox.SuspendLayout();
            this.LoteGropuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.ComponentsLayoutPanel.SuspendLayout();
            this.BottomLayoutPanel.SuspendLayout();
            this.DeclineGrupBox.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpringsTabControl
            // 
            this.SpringsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpringsTabControl.Controls.Add(this.Packing);
            this.SpringsTabControl.Location = new System.Drawing.Point(12, 12);
            this.SpringsTabControl.Name = "SpringsTabControl";
            this.SpringsTabControl.SelectedIndex = 0;
            this.SpringsTabControl.Size = new System.Drawing.Size(1014, 677);
            this.SpringsTabControl.TabIndex = 0;
            // 
            // Packing
            // 
            this.Packing.Controls.Add(this.TopLayoutPanel);
            this.Packing.Controls.Add(this.DebugTextBox);
            this.Packing.Controls.Add(this.ListLayoutPanel);
            this.Packing.Controls.Add(this.BottomLayoutPanel);
            this.Packing.Location = new System.Drawing.Point(4, 22);
            this.Packing.Name = "Packing";
            this.Packing.Padding = new System.Windows.Forms.Padding(3);
            this.Packing.Size = new System.Drawing.Size(1006, 651);
            this.Packing.TabIndex = 0;
            this.Packing.Text = "Empaque Amortiguadores";
            this.Packing.UseVisualStyleBackColor = true;
            // 
            // TopLayoutPanel
            // 
            this.TopLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopLayoutPanel.ColumnCount = 2;
            this.TopLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87763F));
            this.TopLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.12237F));
            this.TopLayoutPanel.Controls.Add(this.OrdersLayoutPanel, 0, 0);
            this.TopLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TopLayoutPanel.Location = new System.Drawing.Point(3, 6);
            this.TopLayoutPanel.Name = "TopLayoutPanel";
            this.TopLayoutPanel.RowCount = 1;
            this.TopLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopLayoutPanel.Size = new System.Drawing.Size(997, 171);
            this.TopLayoutPanel.TabIndex = 4;
            // 
            // OrdersLayoutPanel
            // 
            this.OrdersLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersLayoutPanel.ColumnCount = 1;
            this.OrdersLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersLayoutPanel.Controls.Add(this.CartonGroupBox, 0, 1);
            this.OrdersLayoutPanel.Controls.Add(this.OrderGroupBox, 0, 0);
            this.OrdersLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OrdersLayoutPanel.Name = "OrdersLayoutPanel";
            this.OrdersLayoutPanel.RowCount = 2;
            this.OrdersLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersLayoutPanel.Size = new System.Drawing.Size(251, 165);
            this.OrdersLayoutPanel.TabIndex = 2;
            // 
            // CartonGroupBox
            // 
            this.CartonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartonGroupBox.Controls.Add(this.CartonTextBox);
            this.CartonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartonGroupBox.Location = new System.Drawing.Point(3, 85);
            this.CartonGroupBox.Name = "CartonGroupBox";
            this.CartonGroupBox.Size = new System.Drawing.Size(245, 77);
            this.CartonGroupBox.TabIndex = 1;
            this.CartonGroupBox.TabStop = false;
            this.CartonGroupBox.Text = "Carton  Number";
            // 
            // CartonTextBox
            // 
            this.CartonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartonTextBox.Location = new System.Drawing.Point(3, 22);
            this.CartonTextBox.Name = "CartonTextBox";
            this.CartonTextBox.Size = new System.Drawing.Size(239, 41);
            this.CartonTextBox.TabIndex = 0;
            this.CartonTextBox.Text = "00000000";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderGroupBox.Controls.Add(this.OrderTextBox);
            this.OrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(245, 76);
            this.OrderGroupBox.TabIndex = 0;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order Number";
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTextBox.Location = new System.Drawing.Point(3, 22);
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(239, 41);
            this.OrderTextBox.TabIndex = 0;
            this.OrderTextBox.Text = "00000000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.93221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.45455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 165);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carton Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Part Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pack Specification";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(463, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assembly Specification";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(463, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "2nd Label";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(90, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 41);
            this.label7.TabIndex = 6;
            this.label7.Text = "0000-0000";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(90, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(367, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "XXX0000000X Xsssss X000 Xssss Xss. Xsss";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(90, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 42);
            this.label9.TabIndex = 8;
            this.label9.Text = "XXXX0000";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(624, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 41);
            this.label10.TabIndex = 9;
            this.label10.Text = "XXXX0000";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(624, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = "True   XX0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(90, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 42);
            this.label11.TabIndex = 10;
            this.label11.Text = "00 de 00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugTextBox.Location = new System.Drawing.Point(3, 538);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ReadOnly = true;
            this.DebugTextBox.Size = new System.Drawing.Size(996, 20);
            this.DebugTextBox.TabIndex = 3;
            this.DebugTextBox.Visible = false;
            // 
            // ListLayoutPanel
            // 
            this.ListLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListLayoutPanel.ColumnCount = 2;
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.ListLayoutPanel.Controls.Add(this.SpringsGroupBox, 0, 0);
            this.ListLayoutPanel.Controls.Add(this.RightLayoutPanel, 1, 0);
            this.ListLayoutPanel.Location = new System.Drawing.Point(3, 183);
            this.ListLayoutPanel.Name = "ListLayoutPanel";
            this.ListLayoutPanel.RowCount = 1;
            this.ListLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListLayoutPanel.Size = new System.Drawing.Size(1000, 351);
            this.ListLayoutPanel.TabIndex = 2;
            // 
            // SpringsGroupBox
            // 
            this.SpringsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpringsGroupBox.Controls.Add(this.SpringsDataGrid);
            this.SpringsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SpringsGroupBox.Name = "SpringsGroupBox";
            this.SpringsGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SpringsGroupBox.Size = new System.Drawing.Size(734, 345);
            this.SpringsGroupBox.TabIndex = 0;
            this.SpringsGroupBox.TabStop = false;
            this.SpringsGroupBox.Text = "Spring List";
            // 
            // SpringsDataGrid
            // 
            this.SpringsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpringsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpringsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpringsDataGrid.Location = new System.Drawing.Point(7, 20);
            this.SpringsDataGrid.Name = "SpringsDataGrid";
            this.SpringsDataGrid.Size = new System.Drawing.Size(714, 319);
            this.SpringsDataGrid.TabIndex = 0;
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightLayoutPanel.ColumnCount = 1;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.Controls.Add(this.OperatorGroupBox, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.LoteGropuBox, 0, 0);
            this.RightLayoutPanel.Location = new System.Drawing.Point(743, 3);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 2;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.89855F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.10145F));
            this.RightLayoutPanel.Size = new System.Drawing.Size(254, 345);
            this.RightLayoutPanel.TabIndex = 1;
            // 
            // OperatorGroupBox
            // 
            this.OperatorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperatorGroupBox.Controls.Add(this.OperatorTextBox);
            this.OperatorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorGroupBox.Location = new System.Drawing.Point(3, 289);
            this.OperatorGroupBox.Name = "OperatorGroupBox";
            this.OperatorGroupBox.Size = new System.Drawing.Size(248, 53);
            this.OperatorGroupBox.TabIndex = 0;
            this.OperatorGroupBox.TabStop = false;
            this.OperatorGroupBox.Text = "Operador";
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OperatorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperatorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorTextBox.Location = new System.Drawing.Point(3, 17);
            this.OperatorTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.ReadOnly = true;
            this.OperatorTextBox.Size = new System.Drawing.Size(242, 23);
            this.OperatorTextBox.TabIndex = 0;
            this.OperatorTextBox.Text = "FELIPE ANTONIO SANCHEZ";
            this.OperatorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoteGropuBox
            // 
            this.LoteGropuBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoteGropuBox.Controls.Add(this.CameraPictureBox);
            this.LoteGropuBox.Controls.Add(this.ComponentsLayoutPanel);
            this.LoteGropuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoteGropuBox.Location = new System.Drawing.Point(3, 3);
            this.LoteGropuBox.Name = "LoteGropuBox";
            this.LoteGropuBox.Size = new System.Drawing.Size(248, 280);
            this.LoteGropuBox.TabIndex = 1;
            this.LoteGropuBox.TabStop = false;
            this.LoteGropuBox.Text = "No. Lote de Componentes";
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraPictureBox.Location = new System.Drawing.Point(3, 131);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(242, 146);
            this.CameraPictureBox.TabIndex = 1;
            this.CameraPictureBox.TabStop = false;
            // 
            // ComponentsLayoutPanel
            // 
            this.ComponentsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentsLayoutPanel.ColumnCount = 1;
            this.ComponentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComponentsLayoutPanel.Controls.Add(this.Lote02Label, 0, 2);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote02TextBox, 0, 3);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote01TextBox, 0, 1);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote01Label, 0, 0);
            this.ComponentsLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.ComponentsLayoutPanel.Name = "ComponentsLayoutPanel";
            this.ComponentsLayoutPanel.RowCount = 4;
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.94872F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.49573F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.18803F));
            this.ComponentsLayoutPanel.Size = new System.Drawing.Size(242, 117);
            this.ComponentsLayoutPanel.TabIndex = 0;
            // 
            // Lote02Label
            // 
            this.Lote02Label.AutoSize = true;
            this.Lote02Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lote02Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote02Label.Location = new System.Drawing.Point(3, 61);
            this.Lote02Label.Name = "Lote02Label";
            this.Lote02Label.Size = new System.Drawing.Size(236, 15);
            this.Lote02Label.TabIndex = 3;
            this.Lote02Label.Text = "XXXX0000XXX00XXX0 XX";
            // 
            // Lote02TextBox
            // 
            this.Lote02TextBox.BackColor = System.Drawing.Color.Lime;
            this.Lote02TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lote02TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote02TextBox.Location = new System.Drawing.Point(3, 79);
            this.Lote02TextBox.Name = "Lote02TextBox";
            this.Lote02TextBox.Size = new System.Drawing.Size(236, 26);
            this.Lote02TextBox.TabIndex = 1;
            this.Lote02TextBox.Text = "0000000000";
            // 
            // Lote01TextBox
            // 
            this.Lote01TextBox.BackColor = System.Drawing.Color.Lime;
            this.Lote01TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lote01TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote01TextBox.Location = new System.Drawing.Point(3, 24);
            this.Lote01TextBox.Name = "Lote01TextBox";
            this.Lote01TextBox.Size = new System.Drawing.Size(236, 26);
            this.Lote01TextBox.TabIndex = 0;
            this.Lote01TextBox.Text = "0000000000";
            // 
            // Lote01Label
            // 
            this.Lote01Label.AutoSize = true;
            this.Lote01Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lote01Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote01Label.Location = new System.Drawing.Point(3, 6);
            this.Lote01Label.Name = "Lote01Label";
            this.Lote01Label.Size = new System.Drawing.Size(236, 15);
            this.Lote01Label.TabIndex = 2;
            this.Lote01Label.Text = "XXXX0000XXX00XXX0 XX";
            // 
            // BottomLayoutPanel
            // 
            this.BottomLayoutPanel.ColumnCount = 5;
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BottomLayoutPanel.Controls.Add(this.LeaveButton, 4, 0);
            this.BottomLayoutPanel.Controls.Add(this.CleanButton, 3, 0);
            this.BottomLayoutPanel.Controls.Add(this.PrintButton, 2, 0);
            this.BottomLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.BottomLayoutPanel.Controls.Add(this.DeclineGrupBox, 0, 0);
            this.BottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLayoutPanel.Location = new System.Drawing.Point(3, 568);
            this.BottomLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BottomLayoutPanel.Name = "BottomLayoutPanel";
            this.BottomLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BottomLayoutPanel.RowCount = 1;
            this.BottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomLayoutPanel.Size = new System.Drawing.Size(1000, 80);
            this.BottomLayoutPanel.TabIndex = 1;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveButton.AutoSize = true;
            this.LeaveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LeaveButton.ForeColor = System.Drawing.Color.Red;
            this.LeaveButton.Location = new System.Drawing.Point(757, 4);
            this.LeaveButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(239, 72);
            this.LeaveButton.TabIndex = 0;
            this.LeaveButton.Text = "Salir";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanButton.AutoSize = true;
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CleanButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.CleanButton.Location = new System.Drawing.Point(608, 4);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(129, 72);
            this.CleanButton.TabIndex = 1;
            this.CleanButton.Text = "Limpiar Pantalla";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.AutoSize = true;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PrintButton.Location = new System.Drawing.Point(459, 4);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(129, 72);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Imprimir";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RemoveButton.Location = new System.Drawing.Point(310, 4);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(129, 72);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remover";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DeclineGrupBox
            // 
            this.DeclineGrupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeclineGrupBox.Controls.Add(this.DeclineButton);
            this.DeclineGrupBox.Controls.Add(this.DeclineTextBox);
            this.DeclineGrupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineGrupBox.Location = new System.Drawing.Point(4, 4);
            this.DeclineGrupBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DeclineGrupBox.Name = "DeclineGrupBox";
            this.DeclineGrupBox.Size = new System.Drawing.Size(286, 72);
            this.DeclineGrupBox.TabIndex = 4;
            this.DeclineGrupBox.TabStop = false;
            this.DeclineGrupBox.Text = "Rechazar";
            // 
            // DeclineButton
            // 
            this.DeclineButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeclineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineButton.Location = new System.Drawing.Point(3, 42);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(280, 27);
            this.DeclineButton.TabIndex = 1;
            this.DeclineButton.Text = "Rechazo";
            this.DeclineButton.UseVisualStyleBackColor = true;
            // 
            // DeclineTextBox
            // 
            this.DeclineTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeclineTextBox.Location = new System.Drawing.Point(3, 16);
            this.DeclineTextBox.Name = "DeclineTextBox";
            this.DeclineTextBox.ReadOnly = true;
            this.DeclineTextBox.Size = new System.Drawing.Size(280, 20);
            this.DeclineTextBox.TabIndex = 0;
            // 
            // CameraTimer
            // 
            this.CameraTimer.Interval = 20;
            this.CameraTimer.Tick += new System.EventHandler(this.CameraTimer_Tick);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 679);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1038, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(16, 17);
            this.StatusBarLabel.Text = "...";
            // 
            // AirSprings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 701);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.SpringsTabControl);
            this.Name = "AirSprings";
            this.Text = "AirSpring";
            this.Load += new System.EventHandler(this.AirSprings_Load);
            this.SpringsTabControl.ResumeLayout(false);
            this.Packing.ResumeLayout(false);
            this.Packing.PerformLayout();
            this.TopLayoutPanel.ResumeLayout(false);
            this.OrdersLayoutPanel.ResumeLayout(false);
            this.CartonGroupBox.ResumeLayout(false);
            this.CartonGroupBox.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ListLayoutPanel.ResumeLayout(false);
            this.SpringsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpringsDataGrid)).EndInit();
            this.RightLayoutPanel.ResumeLayout(false);
            this.OperatorGroupBox.ResumeLayout(false);
            this.OperatorGroupBox.PerformLayout();
            this.LoteGropuBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ComponentsLayoutPanel.ResumeLayout(false);
            this.ComponentsLayoutPanel.PerformLayout();
            this.BottomLayoutPanel.ResumeLayout(false);
            this.BottomLayoutPanel.PerformLayout();
            this.DeclineGrupBox.ResumeLayout(false);
            this.DeclineGrupBox.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl SpringsTabControl;
        private System.Windows.Forms.TabPage Packing;

        private System.Windows.Forms.TableLayoutPanel TopLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel OrdersLayoutPanel;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.GroupBox CartonGroupBox;
        private System.Windows.Forms.TextBox CartonTextBox;
        private System.Windows.Forms.TextBox OrderTextBox;

        private System.Windows.Forms.TableLayoutPanel ListLayoutPanel;
        private System.Windows.Forms.GroupBox SpringsGroupBox;
        private System.Windows.Forms.DataGridView SpringsDataGrid;    
        
        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;     
        private System.Windows.Forms.TableLayoutPanel ComponentsLayoutPanel;

        private System.Windows.Forms.GroupBox LoteGropuBox;
        private System.Windows.Forms.Label Lote01Label;
        private System.Windows.Forms.TextBox Lote01TextBox;
        private System.Windows.Forms.Label Lote02Label;
        private System.Windows.Forms.TextBox Lote02TextBox;
        private System.Windows.Forms.PictureBox CameraPictureBox;

        private System.Windows.Forms.GroupBox OperatorGroupBox;
        private System.Windows.Forms.TextBox OperatorTextBox;

        private System.Windows.Forms.TextBox DebugTextBox;
    
        private System.Windows.Forms.TableLayoutPanel BottomLayoutPanel;   
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox DeclineGrupBox;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.TextBox DeclineTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer CameraTimer;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
    }
}

