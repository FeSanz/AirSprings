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
            this.IndicadorsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SpringsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpringsDataGrid = new System.Windows.Forms.DataGridView();
            this.TopLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CartonGroupBox = new System.Windows.Forms.GroupBox();
            this.CartonTextBox = new System.Windows.Forms.TextBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.TextD4 = new System.Windows.Forms.Label();
            this.TextD1 = new System.Windows.Forms.Label();
            this.TextD2 = new System.Windows.Forms.Label();
            this.TextD3 = new System.Windows.Forms.Label();
            this.SQLPartLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PackLabel = new System.Windows.Forms.Label();
            this.CartonLabel = new System.Windows.Forms.Label();
            this.TextD5 = new System.Windows.Forms.Label();
            this.AssamblyLabel = new System.Windows.Forms.Label();
            this.TextD6 = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.LoteGropuBox = new System.Windows.Forms.GroupBox();
            this.ComponentsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Lote02Label = new System.Windows.Forms.Label();
            this.Lote02TextBox = new System.Windows.Forms.TextBox();
            this.Lote01TextBox = new System.Windows.Forms.TextBox();
            this.Lote01Label = new System.Windows.Forms.Label();
            this.OperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SpringsTabControl.SuspendLayout();
            this.Packing.SuspendLayout();
            this.IndicadorsGroupBox.SuspendLayout();
            this.SpringsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpringsDataGrid)).BeginInit();
            this.TopLayoutPanel.SuspendLayout();
            this.OrdersLayoutPanel.SuspendLayout();
            this.CartonGroupBox.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.LayoutPanelData.SuspendLayout();
            this.LoteGropuBox.SuspendLayout();
            this.ComponentsLayoutPanel.SuspendLayout();
            this.OperatorGroupBox.SuspendLayout();
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
            this.Packing.Controls.Add(this.IndicadorsGroupBox);
            this.Packing.Controls.Add(this.SpringsGroupBox);
            this.Packing.Controls.Add(this.TopLayoutPanel);
            this.Packing.Controls.Add(this.LoteGropuBox);
            this.Packing.Controls.Add(this.OperatorGroupBox);
            this.Packing.Controls.Add(this.DebugTextBox);
            this.Packing.Controls.Add(this.BottomLayoutPanel);
            this.Packing.Location = new System.Drawing.Point(4, 22);
            this.Packing.Name = "Packing";
            this.Packing.Padding = new System.Windows.Forms.Padding(3);
            this.Packing.Size = new System.Drawing.Size(1006, 651);
            this.Packing.TabIndex = 0;
            this.Packing.Text = "Empaque Amortiguadores";
            this.Packing.UseVisualStyleBackColor = true;
            // 
            // IndicadorsGroupBox
            // 
            this.IndicadorsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IndicadorsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.IndicadorsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndicadorsGroupBox.Location = new System.Drawing.Point(700, 375);
            this.IndicadorsGroupBox.Name = "IndicadorsGroupBox";
            this.IndicadorsGroupBox.Size = new System.Drawing.Size(300, 83);
            this.IndicadorsGroupBox.TabIndex = 5;
            this.IndicadorsGroupBox.TabStop = false;
            this.IndicadorsGroupBox.Text = "Indicadores";
            this.IndicadorsGroupBox.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // SpringsGroupBox
            // 
            this.SpringsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpringsGroupBox.Controls.Add(this.SpringsDataGrid);
            this.SpringsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringsGroupBox.Location = new System.Drawing.Point(3, 201);
            this.SpringsGroupBox.Name = "SpringsGroupBox";
            this.SpringsGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SpringsGroupBox.Size = new System.Drawing.Size(688, 331);
            this.SpringsGroupBox.TabIndex = 4;
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
            this.SpringsDataGrid.Location = new System.Drawing.Point(6, 20);
            this.SpringsDataGrid.Name = "SpringsDataGrid";
            this.SpringsDataGrid.Size = new System.Drawing.Size(674, 305);
            this.SpringsDataGrid.TabIndex = 0;
            // 
            // TopLayoutPanel
            // 
            this.TopLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopLayoutPanel.ColumnCount = 2;
            this.TopLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96832F));
            this.TopLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.03168F));
            this.TopLayoutPanel.Controls.Add(this.OrdersLayoutPanel, 0, 0);
            this.TopLayoutPanel.Controls.Add(this.LayoutPanelData, 1, 0);
            this.TopLayoutPanel.Location = new System.Drawing.Point(3, 6);
            this.TopLayoutPanel.Name = "TopLayoutPanel";
            this.TopLayoutPanel.RowCount = 1;
            this.TopLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopLayoutPanel.Size = new System.Drawing.Size(994, 189);
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
            this.OrdersLayoutPanel.Size = new System.Drawing.Size(242, 183);
            this.OrdersLayoutPanel.TabIndex = 2;
            // 
            // CartonGroupBox
            // 
            this.CartonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartonGroupBox.Controls.Add(this.CartonTextBox);
            this.CartonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartonGroupBox.Location = new System.Drawing.Point(3, 94);
            this.CartonGroupBox.Name = "CartonGroupBox";
            this.CartonGroupBox.Size = new System.Drawing.Size(236, 86);
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
            this.CartonTextBox.Size = new System.Drawing.Size(230, 41);
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
            this.OrderGroupBox.Size = new System.Drawing.Size(236, 85);
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
            this.OrderTextBox.Size = new System.Drawing.Size(230, 41);
            this.OrderTextBox.TabIndex = 0;
            this.OrderTextBox.Text = "00000000";
            // 
            // LayoutPanelData
            // 
            this.LayoutPanelData.ColumnCount = 4;
            this.LayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51899F));
            this.LayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.48101F));
            this.LayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.LayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.LayoutPanelData.Controls.Add(this.TextD4, 0, 3);
            this.LayoutPanelData.Controls.Add(this.TextD1, 0, 0);
            this.LayoutPanelData.Controls.Add(this.TextD2, 0, 1);
            this.LayoutPanelData.Controls.Add(this.TextD3, 0, 2);
            this.LayoutPanelData.Controls.Add(this.SQLPartLabel, 1, 0);
            this.LayoutPanelData.Controls.Add(this.DescriptionLabel, 1, 1);
            this.LayoutPanelData.Controls.Add(this.PackLabel, 1, 2);
            this.LayoutPanelData.Controls.Add(this.CartonLabel, 1, 3);
            this.LayoutPanelData.Controls.Add(this.TextD5, 2, 0);
            this.LayoutPanelData.Controls.Add(this.AssamblyLabel, 3, 0);
            this.LayoutPanelData.Controls.Add(this.TextD6, 2, 1);
            this.LayoutPanelData.Controls.Add(this.LabelLabel, 3, 1);
            this.LayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelData.Location = new System.Drawing.Point(251, 3);
            this.LayoutPanelData.Name = "LayoutPanelData";
            this.LayoutPanelData.RowCount = 4;
            this.LayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.LayoutPanelData.Size = new System.Drawing.Size(740, 183);
            this.LayoutPanelData.TabIndex = 3;
            // 
            // TextD4
            // 
            this.TextD4.AutoSize = true;
            this.TextD4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD4.Location = new System.Drawing.Point(3, 135);
            this.TextD4.Name = "TextD4";
            this.TextD4.Size = new System.Drawing.Size(96, 48);
            this.TextD4.TabIndex = 5;
            this.TextD4.Text = "Carton Quantity";
            this.TextD4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextD1
            // 
            this.TextD1.AutoSize = true;
            this.TextD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD1.Location = new System.Drawing.Point(3, 0);
            this.TextD1.Name = "TextD1";
            this.TextD1.Size = new System.Drawing.Size(96, 45);
            this.TextD1.TabIndex = 0;
            this.TextD1.Text = "SQL Part Number";
            this.TextD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextD2
            // 
            this.TextD2.AutoSize = true;
            this.TextD2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD2.Location = new System.Drawing.Point(3, 45);
            this.TextD2.Name = "TextD2";
            this.TextD2.Size = new System.Drawing.Size(96, 45);
            this.TextD2.TabIndex = 1;
            this.TextD2.Text = "Description";
            this.TextD2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextD3
            // 
            this.TextD3.AutoSize = true;
            this.TextD3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD3.Location = new System.Drawing.Point(3, 90);
            this.TextD3.Name = "TextD3";
            this.TextD3.Size = new System.Drawing.Size(96, 45);
            this.TextD3.TabIndex = 2;
            this.TextD3.Text = "Pack Specification";
            this.TextD3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SQLPartLabel
            // 
            this.SQLPartLabel.AutoSize = true;
            this.SQLPartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.SQLPartLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SQLPartLabel.Location = new System.Drawing.Point(105, 0);
            this.SQLPartLabel.Name = "SQLPartLabel";
            this.SQLPartLabel.Size = new System.Drawing.Size(366, 45);
            this.SQLPartLabel.TabIndex = 6;
            this.SQLPartLabel.Text = "0000-0000";
            this.SQLPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescriptionLabel.Location = new System.Drawing.Point(105, 45);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(366, 45);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "XXX0000000X Xsssss X000 Xssss Xss. Xsss";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PackLabel
            // 
            this.PackLabel.AutoSize = true;
            this.PackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.PackLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PackLabel.Location = new System.Drawing.Point(105, 90);
            this.PackLabel.Name = "PackLabel";
            this.PackLabel.Size = new System.Drawing.Size(366, 45);
            this.PackLabel.TabIndex = 8;
            this.PackLabel.Text = "XXXX0000";
            this.PackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartonLabel
            // 
            this.CartonLabel.AutoSize = true;
            this.CartonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CartonLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CartonLabel.Location = new System.Drawing.Point(105, 135);
            this.CartonLabel.Name = "CartonLabel";
            this.CartonLabel.Size = new System.Drawing.Size(366, 48);
            this.CartonLabel.TabIndex = 10;
            this.CartonLabel.Text = "00 de 00";
            this.CartonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextD5
            // 
            this.TextD5.AutoSize = true;
            this.TextD5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD5.Location = new System.Drawing.Point(477, 0);
            this.TextD5.Name = "TextD5";
            this.TextD5.Size = new System.Drawing.Size(107, 45);
            this.TextD5.TabIndex = 3;
            this.TextD5.Text = "Assembly Specification";
            this.TextD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AssamblyLabel
            // 
            this.AssamblyLabel.AutoSize = true;
            this.AssamblyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssamblyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.AssamblyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AssamblyLabel.Location = new System.Drawing.Point(590, 0);
            this.AssamblyLabel.Name = "AssamblyLabel";
            this.AssamblyLabel.Size = new System.Drawing.Size(147, 45);
            this.AssamblyLabel.TabIndex = 9;
            this.AssamblyLabel.Text = "XXXX0000";
            this.AssamblyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextD6
            // 
            this.TextD6.AutoSize = true;
            this.TextD6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextD6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextD6.Location = new System.Drawing.Point(477, 45);
            this.TextD6.Name = "TextD6";
            this.TextD6.Size = new System.Drawing.Size(107, 45);
            this.TextD6.TabIndex = 4;
            this.TextD6.Text = "2nd Label";
            this.TextD6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LabelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLabel.Location = new System.Drawing.Point(590, 45);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(147, 45);
            this.LabelLabel.TabIndex = 11;
            this.LabelLabel.Text = "True   XX0";
            this.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoteGropuBox
            // 
            this.LoteGropuBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoteGropuBox.Controls.Add(this.ComponentsLayoutPanel);
            this.LoteGropuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoteGropuBox.Location = new System.Drawing.Point(700, 206);
            this.LoteGropuBox.Name = "LoteGropuBox";
            this.LoteGropuBox.Size = new System.Drawing.Size(303, 148);
            this.LoteGropuBox.TabIndex = 1;
            this.LoteGropuBox.TabStop = false;
            this.LoteGropuBox.Text = "No. Lote de Componentes";
            // 
            // ComponentsLayoutPanel
            // 
            this.ComponentsLayoutPanel.ColumnCount = 1;
            this.ComponentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComponentsLayoutPanel.Controls.Add(this.Lote02Label, 0, 2);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote02TextBox, 0, 3);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote01TextBox, 0, 1);
            this.ComponentsLayoutPanel.Controls.Add(this.Lote01Label, 0, 0);
            this.ComponentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentsLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.ComponentsLayoutPanel.Name = "ComponentsLayoutPanel";
            this.ComponentsLayoutPanel.RowCount = 4;
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.94872F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.49573F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.ComponentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.18803F));
            this.ComponentsLayoutPanel.Size = new System.Drawing.Size(297, 129);
            this.ComponentsLayoutPanel.TabIndex = 0;
            // 
            // Lote02Label
            // 
            this.Lote02Label.AutoSize = true;
            this.Lote02Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lote02Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote02Label.Location = new System.Drawing.Point(3, 69);
            this.Lote02Label.Name = "Lote02Label";
            this.Lote02Label.Size = new System.Drawing.Size(291, 15);
            this.Lote02Label.TabIndex = 3;
            this.Lote02Label.Text = "XXXX0000XXX00XXX0 XX";
            // 
            // Lote02TextBox
            // 
            this.Lote02TextBox.BackColor = System.Drawing.Color.Lime;
            this.Lote02TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lote02TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote02TextBox.Location = new System.Drawing.Point(3, 87);
            this.Lote02TextBox.Name = "Lote02TextBox";
            this.Lote02TextBox.Size = new System.Drawing.Size(291, 26);
            this.Lote02TextBox.TabIndex = 1;
            this.Lote02TextBox.Text = "0000000000";
            // 
            // Lote01TextBox
            // 
            this.Lote01TextBox.BackColor = System.Drawing.Color.Lime;
            this.Lote01TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lote01TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote01TextBox.Location = new System.Drawing.Point(3, 26);
            this.Lote01TextBox.Name = "Lote01TextBox";
            this.Lote01TextBox.Size = new System.Drawing.Size(291, 26);
            this.Lote01TextBox.TabIndex = 0;
            this.Lote01TextBox.Text = "0000000000";
            // 
            // Lote01Label
            // 
            this.Lote01Label.AutoSize = true;
            this.Lote01Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lote01Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lote01Label.Location = new System.Drawing.Point(3, 8);
            this.Lote01Label.Name = "Lote01Label";
            this.Lote01Label.Size = new System.Drawing.Size(291, 15);
            this.Lote01Label.TabIndex = 2;
            this.Lote01Label.Text = "XXXX0000XXX00XXX0 XX";
            // 
            // OperatorGroupBox
            // 
            this.OperatorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OperatorGroupBox.Controls.Add(this.OperatorTextBox);
            this.OperatorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorGroupBox.Location = new System.Drawing.Point(694, 489);
            this.OperatorGroupBox.Name = "OperatorGroupBox";
            this.OperatorGroupBox.Size = new System.Drawing.Size(306, 43);
            this.OperatorGroupBox.TabIndex = 0;
            this.OperatorGroupBox.TabStop = false;
            this.OperatorGroupBox.Text = "Operador";
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OperatorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperatorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorTextBox.Location = new System.Drawing.Point(3, 17);
            this.OperatorTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.ReadOnly = true;
            this.OperatorTextBox.Size = new System.Drawing.Size(300, 21);
            this.OperatorTextBox.TabIndex = 0;
            this.OperatorTextBox.Text = "FELIPE ANTONIO SANCHEZ";
            this.OperatorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // BottomLayoutPanel
            // 
            this.BottomLayoutPanel.ColumnCount = 5;
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.45691F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43287F));
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
            this.RemoveButton.Location = new System.Drawing.Point(295, 4);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 72);
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
            this.DeclineGrupBox.Size = new System.Drawing.Size(271, 72);
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
            this.DeclineButton.Size = new System.Drawing.Size(265, 27);
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
            this.DeclineTextBox.Size = new System.Drawing.Size(265, 20);
            this.DeclineTextBox.TabIndex = 0;
            // 
            // CameraTimer
            // 
            this.CameraTimer.Interval = 500;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.IndicadorsGroupBox.ResumeLayout(false);
            this.SpringsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpringsDataGrid)).EndInit();
            this.TopLayoutPanel.ResumeLayout(false);
            this.OrdersLayoutPanel.ResumeLayout(false);
            this.CartonGroupBox.ResumeLayout(false);
            this.CartonGroupBox.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.LayoutPanelData.ResumeLayout(false);
            this.LayoutPanelData.PerformLayout();
            this.LoteGropuBox.ResumeLayout(false);
            this.ComponentsLayoutPanel.ResumeLayout(false);
            this.ComponentsLayoutPanel.PerformLayout();
            this.OperatorGroupBox.ResumeLayout(false);
            this.OperatorGroupBox.PerformLayout();
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

        //AREA DE ORDENES Y DESCRIPCIONES
        private System.Windows.Forms.TableLayoutPanel TopLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel OrdersLayoutPanel;
        //ORDENES
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.GroupBox CartonGroupBox;
        private System.Windows.Forms.TextBox CartonTextBox;
        private System.Windows.Forms.TextBox OrderTextBox;
        //DESCRIPCION
        private System.Windows.Forms.TableLayoutPanel LayoutPanelData;
        private System.Windows.Forms.Label TextD1;
        private System.Windows.Forms.Label TextD4;
        private System.Windows.Forms.Label TextD2;
        private System.Windows.Forms.Label TextD3;
        private System.Windows.Forms.Label TextD6;
        private System.Windows.Forms.Label AssamblyLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label SQLPartLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PackLabel;
        private System.Windows.Forms.Label CartonLabel;

        //AREA DE LOTES
        private System.Windows.Forms.TableLayoutPanel ComponentsLayoutPanel;
        private System.Windows.Forms.GroupBox LoteGropuBox;
        private System.Windows.Forms.Label Lote01Label;
        private System.Windows.Forms.TextBox Lote01TextBox;
        private System.Windows.Forms.Label Lote02Label;
        private System.Windows.Forms.TextBox Lote02TextBox;

        //AREA DE OPERADOR
        private System.Windows.Forms.GroupBox OperatorGroupBox;
        private System.Windows.Forms.TextBox OperatorTextBox;

        private System.Windows.Forms.TextBox DebugTextBox;
    
        //AREA DE BOTONES BOTTOM
        private System.Windows.Forms.TableLayoutPanel BottomLayoutPanel;   
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox DeclineGrupBox;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.TextBox DeclineTextBox;

        //EXTRAS
        private System.Windows.Forms.Timer CameraTimer;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.GroupBox SpringsGroupBox;
        private System.Windows.Forms.DataGridView SpringsDataGrid;
        private System.Windows.Forms.Label TextD5;
        private System.Windows.Forms.GroupBox IndicadorsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

