namespace CIDAGENDA2018
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.schedulerDataDataSet = new CIDAGENDA2018.schedulerDataDataSet();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.panelTool = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_forward_resource = new System.Windows.Forms.Button();
            this.btn_back_resource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_salas = new System.Windows.Forms.ComboBox();
            this.citasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITASTableAdapter();
            this.cita1TableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITA1TableAdapter();
            this.salasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.SALASTableAdapter();
            this.panelScheduler = new System.Windows.Forms.Panel();
            this.btn_IniciarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgendarCitas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRecepcion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_VerAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Complementos = new System.Windows.Forms.ToolStripButton();
            this.btn_Preparacion = new System.Windows.Forms.ToolStripButton();
            this.btn_Usuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Menu = new System.Windows.Forms.ToolStrip();
            this.btn_CerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.btn_Diagnostico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            this.panelTool.SuspendLayout();
            this.panelScheduler.SuspendLayout();
            this.toolStrip_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 6);
            this.panel1.TabIndex = 102;
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
            this.radScheduler1.Size = new System.Drawing.Size(1096, 248);
            this.radScheduler1.TabIndex = 109;
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
            this.radSchedulerNavigator1.DateFormat = "dddd dd MMMM yyyy";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 472, 78);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1096, 77);
            this.radSchedulerNavigator1.TabIndex = 0;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTool.Controls.Add(this.label2);
            this.panelTool.Controls.Add(this.btn_forward_resource);
            this.panelTool.Controls.Add(this.btn_back_resource);
            this.panelTool.Controls.Add(this.label1);
            this.panelTool.Controls.Add(this.txt_salas);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 58);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1096, 43);
            this.panelTool.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Navegar entre salas :";
            // 
            // btn_forward_resource
            // 
            this.btn_forward_resource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_forward_resource.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward_resource.Image")));
            this.btn_forward_resource.Location = new System.Drawing.Point(536, 3);
            this.btn_forward_resource.Name = "btn_forward_resource";
            this.btn_forward_resource.Size = new System.Drawing.Size(50, 35);
            this.btn_forward_resource.TabIndex = 31;
            this.btn_forward_resource.UseVisualStyleBackColor = false;
            this.btn_forward_resource.Click += new System.EventHandler(this.btn_forward_resource_Click);
            // 
            // btn_back_resource
            // 
            this.btn_back_resource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back_resource.Image = ((System.Drawing.Image)(resources.GetObject("btn_back_resource.Image")));
            this.btn_back_resource.Location = new System.Drawing.Point(480, 3);
            this.btn_back_resource.Name = "btn_back_resource";
            this.btn_back_resource.Size = new System.Drawing.Size(50, 35);
            this.btn_back_resource.TabIndex = 30;
            this.btn_back_resource.UseVisualStyleBackColor = false;
            this.btn_back_resource.Click += new System.EventHandler(this.btn_back_resource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mostrar Sala";
            // 
            // txt_salas
            // 
            this.txt_salas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_salas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_salas.FormattingEnabled = true;
            this.txt_salas.Location = new System.Drawing.Point(85, 10);
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(267, 21);
            this.txt_salas.TabIndex = 28;
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
            // panelScheduler
            // 
            this.panelScheduler.AutoScroll = true;
            this.panelScheduler.Controls.Add(this.radScheduler1);
            this.panelScheduler.Controls.Add(this.radSchedulerNavigator1);
            this.panelScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScheduler.Location = new System.Drawing.Point(0, 101);
            this.panelScheduler.Name = "panelScheduler";
            this.panelScheduler.Size = new System.Drawing.Size(1096, 325);
            this.panelScheduler.TabIndex = 110;
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_IniciarSesion.Image")));
            this.btn_IniciarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_IniciarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(74, 49);
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 52);
            // 
            // btnAgendarCitas
            // 
            this.btnAgendarCitas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendarCitas.Image")));
            this.btnAgendarCitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgendarCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgendarCitas.Name = "btnAgendarCitas";
            this.btnAgendarCitas.Size = new System.Drawing.Size(77, 49);
            this.btnAgendarCitas.Text = "Agendar Citas";
            this.btnAgendarCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgendarCitas.Click += new System.EventHandler(this.btnAgendarCitas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.Image = ((System.Drawing.Image)(resources.GetObject("btnRecepcion.Image")));
            this.btnRecepcion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRecepcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(63, 49);
            this.btnRecepcion.Text = "Recepción";
            this.btnRecepcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // btn_VerAgenda
            // 
            this.btn_VerAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btn_VerAgenda.Image")));
            this.btn_VerAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_VerAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_VerAgenda.Name = "btn_VerAgenda";
            this.btn_VerAgenda.Size = new System.Drawing.Size(67, 49);
            this.btn_VerAgenda.Text = "Ver Agenda";
            this.btn_VerAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_VerAgenda.Click += new System.EventHandler(this.btn_VerAgenda_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // btn_Complementos
            // 
            this.btn_Complementos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Complementos.Image")));
            this.btn_Complementos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Complementos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Complementos.Name = "btn_Complementos";
            this.btn_Complementos.Size = new System.Drawing.Size(80, 49);
            this.btn_Complementos.Text = "Complementos";
            this.btn_Complementos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Complementos.Click += new System.EventHandler(this.btn_Complementos_Click);
            // 
            // btn_Preparacion
            // 
            this.btn_Preparacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_Preparacion.Image")));
            this.btn_Preparacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Preparacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Preparacion.Name = "btn_Preparacion";
            this.btn_Preparacion.Size = new System.Drawing.Size(68, 49);
            this.btn_Preparacion.Text = "Preparación";
            this.btn_Preparacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Preparacion.Click += new System.EventHandler(this.btn_Preparacion_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.Image")));
            this.btn_Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Usuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(52, 49);
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(36, 49);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStrip_Menu
            // 
            this.toolStrip_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_IniciarSesion,
            this.btn_CerrarSesion,
            this.toolStripSeparator6,
            this.btnAgendarCitas,
            this.toolStripSeparator1,
            this.btnRecepcion,
            this.toolStripSeparator2,
            this.btn_VerAgenda,
            this.toolStripSeparator3,
            this.btn_Preparacion,
            this.btn_Complementos,
            this.btn_Diagnostico,
            this.toolStripSeparator7,
            this.btn_Salas,
            this.btn_Usuarios,
            this.toolStripSeparator5,
            this.btn_Salir,
            this.toolStripButton1});
            this.toolStrip_Menu.Location = new System.Drawing.Point(0, 6);
            this.toolStrip_Menu.Name = "toolStrip_Menu";
            this.toolStrip_Menu.Size = new System.Drawing.Size(1096, 52);
            this.toolStrip_Menu.TabIndex = 108;
            this.toolStrip_Menu.Text = "toolStrip1";
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_CerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(74, 49);
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_Diagnostico
            // 
            this.btn_Diagnostico.Image = ((System.Drawing.Image)(resources.GetObject("btn_Diagnostico.Image")));
            this.btn_Diagnostico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Diagnostico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Diagnostico.Name = "btn_Diagnostico";
            this.btn_Diagnostico.Size = new System.Drawing.Size(67, 49);
            this.btn_Diagnostico.Text = "Diagnóstico";
            this.btn_Diagnostico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Diagnostico.Click += new System.EventHandler(this.btn_Diagnostico_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 52);
            // 
            // btn_Salas
            // 
            this.btn_Salas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salas.Image")));
            this.btn_Salas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salas.Name = "btn_Salas";
            this.btn_Salas.Size = new System.Drawing.Size(37, 49);
            this.btn_Salas.Text = "Salas";
            this.btn_Salas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salas.Click += new System.EventHandler(this.btn_Salas_Click);
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
            this.toolStripButton1.Size = new System.Drawing.Size(63, 49);
            this.toolStripButton1.ToolTipText = "Unidad Radiologica IRM, S. de R.L. de C.V.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1096, 426);
            this.Controls.Add(this.panelScheduler);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.toolStrip_Menu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad Radiologica IRM, S. de R.L. de C.V.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.panelScheduler.ResumeLayout(false);
            this.panelScheduler.PerformLayout();
            this.toolStrip_Menu.ResumeLayout(false);
            this.toolStrip_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_salas;
        private System.Windows.Forms.Button btn_back_resource;
        private System.Windows.Forms.Button btn_forward_resource;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private schedulerDataDataSet schedulerDataDataSet;
        private schedulerDataDataSetTableAdapters.CITASTableAdapter citasTableAdapter1;
        private schedulerDataDataSetTableAdapters.CITA1TableAdapter cita1TableAdapter1;
        private schedulerDataDataSetTableAdapters.SALASTableAdapter salasTableAdapter1;
        private System.Windows.Forms.Panel panelScheduler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btn_IniciarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAgendarCitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRecepcion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_VerAgenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Complementos;
        private System.Windows.Forms.ToolStripButton btn_Preparacion;
        private System.Windows.Forms.ToolStripButton btn_Usuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStrip toolStrip_Menu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btn_Diagnostico;
        private System.Windows.Forms.ToolStripButton btn_Salas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_CerrarSesion;
    }
}

