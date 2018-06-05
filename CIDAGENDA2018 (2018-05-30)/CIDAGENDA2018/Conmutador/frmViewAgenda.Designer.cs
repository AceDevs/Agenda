namespace CIDAGENDA2018.Conmutador
{
    partial class frmViewAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAgenda));
            this.panelScheduler = new System.Windows.Forms.Panel();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.schedulerDataDataSet = new CIDAGENDA2018.schedulerDataDataSet();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.btn_forward_resource = new System.Windows.Forms.Button();
            this.btn_back_resource = new System.Windows.Forms.Button();
            this.panelBarraAmarilla = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_unidad_negocio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_salas = new System.Windows.Forms.ComboBox();
            this.citasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITASTableAdapter();
            this.cita1TableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITA1TableAdapter();
            this.salasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.SALASTableAdapter();
            this.panelScheduler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScheduler
            // 
            this.panelScheduler.AutoScroll = true;
            this.panelScheduler.Controls.Add(this.radScheduler1);
            this.panelScheduler.Controls.Add(this.radSchedulerNavigator1);
            this.panelScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScheduler.Location = new System.Drawing.Point(0, 109);
            this.panelScheduler.Name = "panelScheduler";
            this.panelScheduler.Size = new System.Drawing.Size(1039, 565);
            this.panelScheduler.TabIndex = 0;
            // 
            // radScheduler1
            // 
            this.radScheduler1.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow;
            this.radScheduler1.AutoScroll = true;
            this.radScheduler1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("es-MX");
            this.radScheduler1.DataSource = this.schedulerBindingDataSource1;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.HeaderFormat = "dddd dd MMMM yyyy";
            this.radScheduler1.Location = new System.Drawing.Point(0, 77);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2018, 4, 15, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2018, 4, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            // 
            // 
            // 
            this.radScheduler1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 77, 500, 500);
            this.radScheduler1.ShowAllDayAppointmentStatus = true;
            this.radScheduler1.Size = new System.Drawing.Size(1039, 488);
            this.radScheduler1.TabIndex = 111;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.AppointmentDropping += new System.EventHandler<Telerik.WinControls.UI.AppointmentMovingEventArgs>(this.radScheduler1_AppointmentDropping);
            this.radScheduler1.AppointmentResizeEnd += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentResizeEnd);
            this.radScheduler1.ContextMenuOpening += new Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(this.radScheduler1_ContextMenuOpening);
            this.radScheduler1.AppointmentFormatting += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentFormatting);
            this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
            this.radScheduler1.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(this.radScheduler1_ToolTipTextNeeded);
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.DataMember = "CITAS";
            this.schedulerBindingDataSource1.EventProvider.DataSource = this.schedulerDataDataSet;
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.DataMember = "SALAS";
            this.schedulerBindingDataSource1.ResourceProvider.DataSource = this.schedulerDataDataSet;
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // schedulerDataDataSet
            // 
            this.schedulerDataDataSet.DataSetName = "schedulerDataDataSet";
            this.schedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radSchedulerNavigator1.Controls.Add(this.btn_forward_resource);
            this.radSchedulerNavigator1.Controls.Add(this.btn_back_resource);
            this.radSchedulerNavigator1.DateFormat = "dddd dd MMMM yyyy";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 472, 78);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1039, 77);
            this.radSchedulerNavigator1.TabIndex = 110;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // btn_forward_resource
            // 
            this.btn_forward_resource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_forward_resource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward_resource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btn_forward_resource.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward_resource.Image")));
            this.btn_forward_resource.Location = new System.Drawing.Point(467, 0);
            this.btn_forward_resource.Name = "btn_forward_resource";
            this.btn_forward_resource.Size = new System.Drawing.Size(50, 32);
            this.btn_forward_resource.TabIndex = 36;
            this.btn_forward_resource.UseVisualStyleBackColor = false;
            this.btn_forward_resource.Click += new System.EventHandler(this.btn_forward_resource_Click);
            // 
            // btn_back_resource
            // 
            this.btn_back_resource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            this.btn_back_resource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_resource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btn_back_resource.Image = ((System.Drawing.Image)(resources.GetObject("btn_back_resource.Image")));
            this.btn_back_resource.Location = new System.Drawing.Point(411, 0);
            this.btn_back_resource.Name = "btn_back_resource";
            this.btn_back_resource.Size = new System.Drawing.Size(50, 32);
            this.btn_back_resource.TabIndex = 35;
            this.btn_back_resource.UseVisualStyleBackColor = false;
            this.btn_back_resource.Click += new System.EventHandler(this.btn_back_resource_Click);
            // 
            // panelBarraAmarilla
            // 
            this.panelBarraAmarilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panelBarraAmarilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraAmarilla.Location = new System.Drawing.Point(0, 0);
            this.panelBarraAmarilla.Name = "panelBarraAmarilla";
            this.panelBarraAmarilla.Size = new System.Drawing.Size(1039, 6);
            this.panelBarraAmarilla.TabIndex = 103;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salir,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1039, 44);
            this.toolStrip1.TabIndex = 904;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(33, 41);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 41);
            this.toolStripButton1.ToolTipText = "Unidad Radiologica IRM, S. de R.L. de C.V.";
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.txt_unidad_negocio);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.txt_salas);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 50);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1039, 59);
            this.panelGeneral.TabIndex = 905;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Unidad de Negocio";
            // 
            // txt_unidad_negocio
            // 
            this.txt_unidad_negocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_unidad_negocio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_unidad_negocio.FormattingEnabled = true;
            this.txt_unidad_negocio.Location = new System.Drawing.Point(115, 8);
            this.txt_unidad_negocio.Name = "txt_unidad_negocio";
            this.txt_unidad_negocio.Size = new System.Drawing.Size(213, 21);
            this.txt_unidad_negocio.TabIndex = 38;
            this.txt_unidad_negocio.SelectedIndexChanged += new System.EventHandler(this.txt_unidad_negocio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mostrar Sala";
            // 
            // txt_salas
            // 
            this.txt_salas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_salas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_salas.Location = new System.Drawing.Point(115, 28);
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(213, 21);
            this.txt_salas.TabIndex = 33;
            this.txt_salas.SelectedIndexChanged += new System.EventHandler(this.txt_salas_SelectedIndexChanged);
            // 
            // citasTableAdapter1
            // 
            this.citasTableAdapter1.ClearBeforeFill = true;
            // 
            // cita1TableAdapter1
            // 
            this.cita1TableAdapter1.ClearBeforeFill = true;
            // 
            // salasTableAdapter1
            // 
            this.salasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmViewAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1039, 674);
            this.Controls.Add(this.panelScheduler);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBarraAmarilla);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewAgenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewAgenda_Load);
            this.Shown += new System.EventHandler(this.frmViewAgenda_Shown);
            this.ResizeEnd += new System.EventHandler(this.frmViewAgenda_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmViewAgenda_SizeChanged);
            this.panelScheduler.ResumeLayout(false);
            this.panelScheduler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelScheduler;
        private System.Windows.Forms.Panel panelBarraAmarilla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panelGeneral;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private schedulerDataDataSet schedulerDataDataSet;
        private schedulerDataDataSetTableAdapters.CITASTableAdapter citasTableAdapter1;
        private schedulerDataDataSetTableAdapters.CITA1TableAdapter cita1TableAdapter1;
        private schedulerDataDataSetTableAdapters.SALASTableAdapter salasTableAdapter1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private System.Windows.Forms.Button btn_forward_resource;
        private System.Windows.Forms.Button btn_back_resource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_salas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_unidad_negocio;
    }
}