namespace CIDAGENDA2018.Recepcion
{
    partial class frmEditAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAppointment));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.salasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.SALASTableAdapter();
            this.citasTableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITASTableAdapter();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.schedulerDataDataSet = new CIDAGENDA2018.schedulerDataDataSet();
            this.panelScheduler = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelBarraAmarilla = new System.Windows.Forms.Panel();
            this.panelDayTop = new System.Windows.Forms.Panel();
            this.txt_doc_total = new System.Windows.Forms.TextBox();
            this.txt_DocEntry = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_medico = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_multicita = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_cardtype = new System.Windows.Forms.TextBox();
            this.txt_id_paciente = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido_paterno = new System.Windows.Forms.TextBox();
            this.txt_apellido_materno = new System.Windows.Forms.TextBox();
            this.btn_AgregarEstudio = new System.Windows.Forms.Button();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.radGridPrecios = new Telerik.WinControls.UI.RadGridView();
            this.txt_salas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instituciones = new System.Windows.Forms.ComboBox();
            this.txt_estudios = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fecha_naci = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPreparacion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listComplementos = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listDiagnostico = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_quitar_recursos = new System.Windows.Forms.Button();
            this.btn_anestesiologos = new System.Windows.Forms.Button();
            this.txt_Anestesiologo = new System.Windows.Forms.ComboBox();
            this.btn_ambulancia = new System.Windows.Forms.Button();
            this.radGridRecursos = new Telerik.WinControls.UI.RadGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.cita1TableAdapter1 = new CIDAGENDA2018.schedulerDataDataSetTableAdapters.CITA1TableAdapter();
            this.radGridEstudios = new Telerik.WinControls.UI.RadGridView();
            this.radGridRequisitos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
            this.panelScheduler.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelDayTop.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPrecios.MasterTemplate)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecursos.MasterTemplate)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridEstudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridEstudios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRequisitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRequisitos.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // salasTableAdapter1
            // 
            this.salasTableAdapter1.ClearBeforeFill = true;
            // 
            // citasTableAdapter1
            // 
            this.citasTableAdapter1.ClearBeforeFill = true;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "dddd dd MMMM yyyy";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1113, 77);
            this.radSchedulerNavigator1.TabIndex = 110;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // radScheduler1
            // 
            this.radScheduler1.AllowAppointmentCreateInline = false;
            this.radScheduler1.AllowAppointmentMove = false;
            this.radScheduler1.AllowAppointmentResize = false;
            this.radScheduler1.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow;
            this.radScheduler1.AutoScroll = true;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("es-MX");
            this.radScheduler1.DataSource = this.schedulerBindingDataSource1;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radScheduler1.HeaderFormat = "dddd dd MMMM yyyy";
            this.radScheduler1.Location = new System.Drawing.Point(0, 77);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2018, 4, 15, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2018, 4, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.ShowAllDayAppointmentStatus = true;
            this.radScheduler1.Size = new System.Drawing.Size(1113, 421);
            this.radScheduler1.TabIndex = 111;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ContextMenuOpening += new Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(this.radScheduler1_ContextMenuOpening);
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
            // panelScheduler
            // 
            this.panelScheduler.AutoScroll = true;
            this.panelScheduler.Controls.Add(this.radScheduler1);
            this.panelScheduler.Controls.Add(this.radSchedulerNavigator1);
            this.panelScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScheduler.Location = new System.Drawing.Point(0, 395);
            this.panelScheduler.Name = "panelScheduler";
            this.panelScheduler.Size = new System.Drawing.Size(1130, 300);
            this.panelScheduler.TabIndex = 913;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Guardar,
            this.toolStripSeparator1,
            this.btn_Salir,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 44);
            this.toolStrip1.TabIndex = 910;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(53, 41);
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(45, 41);
            this.btn_Salir.Text = "  Salir  ";
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
            this.toolStripButton1.Size = new System.Drawing.Size(63, 41);
            this.toolStripButton1.ToolTipText = "Unidad Radiologica IRM, S. de R.L. de C.V.";
            // 
            // panelBarraAmarilla
            // 
            this.panelBarraAmarilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panelBarraAmarilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraAmarilla.Location = new System.Drawing.Point(0, 0);
            this.panelBarraAmarilla.Name = "panelBarraAmarilla";
            this.panelBarraAmarilla.Size = new System.Drawing.Size(1130, 6);
            this.panelBarraAmarilla.TabIndex = 909;
            // 
            // panelDayTop
            // 
            this.panelDayTop.Controls.Add(this.txt_doc_total);
            this.panelDayTop.Controls.Add(this.txt_DocEntry);
            this.panelDayTop.Controls.Add(this.txt_fecha);
            this.panelDayTop.Controls.Add(this.txt_end);
            this.panelDayTop.Controls.Add(this.txt_start);
            this.panelDayTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDayTop.Location = new System.Drawing.Point(0, 50);
            this.panelDayTop.Name = "panelDayTop";
            this.panelDayTop.Size = new System.Drawing.Size(1130, 38);
            this.panelDayTop.TabIndex = 911;
            // 
            // txt_doc_total
            // 
            this.txt_doc_total.BackColor = System.Drawing.Color.LightBlue;
            this.txt_doc_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_doc_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_doc_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_total.Location = new System.Drawing.Point(878, 0);
            this.txt_doc_total.Multiline = true;
            this.txt_doc_total.Name = "txt_doc_total";
            this.txt_doc_total.ReadOnly = true;
            this.txt_doc_total.Size = new System.Drawing.Size(252, 38);
            this.txt_doc_total.TabIndex = 0;
            this.txt_doc_total.Text = "0.00";
            this.txt_doc_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_DocEntry
            // 
            this.txt_DocEntry.Location = new System.Drawing.Point(4, 6);
            this.txt_DocEntry.Name = "txt_DocEntry";
            this.txt_DocEntry.ReadOnly = true;
            this.txt_DocEntry.Size = new System.Drawing.Size(99, 20);
            this.txt_DocEntry.TabIndex = 0;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(109, 5);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(219, 20);
            this.txt_fecha.TabIndex = 1;
            this.txt_fecha.ValueChanged += new System.EventHandler(this.txt_fecha_ValueChanged);
            // 
            // txt_end
            // 
            this.txt_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_end.Location = new System.Drawing.Point(450, 5);
            this.txt_end.Name = "txt_end";
            this.txt_end.ReadOnly = true;
            this.txt_end.Size = new System.Drawing.Size(110, 20);
            this.txt_end.TabIndex = 4;
            // 
            // txt_start
            // 
            this.txt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_start.Location = new System.Drawing.Point(334, 5);
            this.txt_start.Name = "txt_start";
            this.txt_start.ReadOnly = true;
            this.txt_start.Size = new System.Drawing.Size(110, 20);
            this.txt_start.TabIndex = 3;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.radGridEstudios);
            this.panelGeneral.Controls.Add(this.tabControl1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 88);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1130, 307);
            this.panelGeneral.TabIndex = 912;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 150);
            this.tabControl1.TabIndex = 902;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_medico);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txt_multicita);
            this.tabPage1.Controls.Add(this.txt_edad);
            this.tabPage1.Controls.Add(this.txt_cardtype);
            this.tabPage1.Controls.Add(this.txt_id_paciente);
            this.tabPage1.Controls.Add(this.txt_celular);
            this.tabPage1.Controls.Add(this.txt_telefono);
            this.tabPage1.Controls.Add(this.txt_correo);
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.txt_apellido_paterno);
            this.tabPage1.Controls.Add(this.txt_apellido_materno);
            this.tabPage1.Controls.Add(this.btn_AgregarEstudio);
            this.tabPage1.Controls.Add(this.btn_BuscarPaciente);
            this.tabPage1.Controls.Add(this.radGridPrecios);
            this.tabPage1.Controls.Add(this.txt_salas);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_instituciones);
            this.tabPage1.Controls.Add(this.txt_estudios);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_sexo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_fecha_naci);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_medico
            // 
            this.txt_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medico.Location = new System.Drawing.Point(590, 76);
            this.txt_medico.Name = "txt_medico";
            this.txt_medico.Size = new System.Drawing.Size(268, 20);
            this.txt_medico.TabIndex = 119;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(542, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "Médico";
            // 
            // txt_multicita
            // 
            this.txt_multicita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_multicita.Location = new System.Drawing.Point(449, 91);
            this.txt_multicita.Name = "txt_multicita";
            this.txt_multicita.ReadOnly = true;
            this.txt_multicita.Size = new System.Drawing.Size(67, 20);
            this.txt_multicita.TabIndex = 118;
            this.txt_multicita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(105, 90);
            this.txt_edad.MaxLength = 3;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(36, 20);
            this.txt_edad.TabIndex = 4;
            // 
            // txt_cardtype
            // 
            this.txt_cardtype.Location = new System.Drawing.Point(354, 91);
            this.txt_cardtype.Name = "txt_cardtype";
            this.txt_cardtype.ReadOnly = true;
            this.txt_cardtype.Size = new System.Drawing.Size(45, 21);
            this.txt_cardtype.TabIndex = 116;
            // 
            // txt_id_paciente
            // 
            this.txt_id_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_paciente.Location = new System.Drawing.Point(105, 6);
            this.txt_id_paciente.Name = "txt_id_paciente";
            this.txt_id_paciente.ReadOnly = true;
            this.txt_id_paciente.Size = new System.Drawing.Size(162, 20);
            this.txt_id_paciente.TabIndex = 0;
            // 
            // txt_celular
            // 
            this.txt_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(354, 49);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(162, 20);
            this.txt_celular.TabIndex = 8;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(354, 28);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(162, 20);
            this.txt_telefono.TabIndex = 7;
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(354, 70);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(162, 20);
            this.txt_correo.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(105, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(162, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido_paterno
            // 
            this.txt_apellido_paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_paterno.Location = new System.Drawing.Point(105, 48);
            this.txt_apellido_paterno.Name = "txt_apellido_paterno";
            this.txt_apellido_paterno.Size = new System.Drawing.Size(162, 20);
            this.txt_apellido_paterno.TabIndex = 2;
            // 
            // txt_apellido_materno
            // 
            this.txt_apellido_materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_materno.Location = new System.Drawing.Point(105, 69);
            this.txt_apellido_materno.Name = "txt_apellido_materno";
            this.txt_apellido_materno.Size = new System.Drawing.Size(162, 20);
            this.txt_apellido_materno.TabIndex = 3;
            // 
            // btn_AgregarEstudio
            // 
            this.btn_AgregarEstudio.Location = new System.Drawing.Point(1013, 87);
            this.btn_AgregarEstudio.Name = "btn_AgregarEstudio";
            this.btn_AgregarEstudio.Size = new System.Drawing.Size(103, 28);
            this.btn_AgregarEstudio.TabIndex = 117;
            this.btn_AgregarEstudio.Text = "Agregar Estudio";
            this.btn_AgregarEstudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AgregarEstudio.UseVisualStyleBackColor = true;
            this.btn_AgregarEstudio.Visible = false;
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarPaciente.Image")));
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(269, 25);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(22, 23);
            this.btn_BuscarPaciente.TabIndex = 115;
            this.btn_BuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // radGridPrecios
            // 
            this.radGridPrecios.AutoScroll = true;
            this.radGridPrecios.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridPrecios.Location = new System.Drawing.Point(935, 4);
            // 
            // 
            // 
            this.radGridPrecios.MasterTemplate.AllowAddNewRow = false;
            this.radGridPrecios.MasterTemplate.AllowDeleteRow = false;
            this.radGridPrecios.MasterTemplate.AllowDragToGroup = false;
            this.radGridPrecios.MasterTemplate.AllowEditRow = false;
            this.radGridPrecios.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridPrecios.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridPrecios.Name = "radGridPrecios";
            this.radGridPrecios.ShowGroupPanel = false;
            this.radGridPrecios.Size = new System.Drawing.Size(179, 77);
            this.radGridPrecios.TabIndex = 14;
            this.radGridPrecios.Text = "radGridView2";
            this.radGridPrecios.Visible = false;
            // 
            // txt_salas
            // 
            this.txt_salas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salas.FormattingEnabled = true;
            this.txt_salas.Location = new System.Drawing.Point(590, 5);
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(268, 21);
            this.txt_salas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Sala";
            // 
            // txt_instituciones
            // 
            this.txt_instituciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instituciones.FormattingEnabled = true;
            this.txt_instituciones.Location = new System.Drawing.Point(590, 49);
            this.txt_instituciones.Name = "txt_instituciones";
            this.txt_instituciones.Size = new System.Drawing.Size(268, 21);
            this.txt_instituciones.TabIndex = 13;
            // 
            // txt_estudios
            // 
            this.txt_estudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estudios.FormattingEnabled = true;
            this.txt_estudios.Location = new System.Drawing.Point(590, 27);
            this.txt_estudios.Name = "txt_estudios";
            this.txt_estudios.Size = new System.Drawing.Size(268, 21);
            this.txt_estudios.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(542, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Estudio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(529, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Institución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "ID";
            // 
            // txt_sexo
            // 
            this.txt_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.Location = new System.Drawing.Point(354, 6);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(162, 21);
            this.txt_sexo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Sexo";
            // 
            // txt_fecha_naci
            // 
            this.txt_fecha_naci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_naci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_naci.Location = new System.Drawing.Point(147, 90);
            this.txt_fecha_naci.Name = "txt_fecha_naci";
            this.txt_fecha_naci.Size = new System.Drawing.Size(120, 20);
            this.txt_fecha_naci.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Edad/Fecha Naci..";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Apellido Materno";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txt_Observaciones);
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1122, 121);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Observaciones";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Location = new System.Drawing.Point(8, 3);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(1045, 110);
            this.txt_Observaciones.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listPreparacion);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preparación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listPreparacion
            // 
            this.listPreparacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPreparacion.FullRowSelect = true;
            this.listPreparacion.GridLines = true;
            this.listPreparacion.Location = new System.Drawing.Point(8, 6);
            this.listPreparacion.MultiSelect = false;
            this.listPreparacion.Name = "listPreparacion";
            this.listPreparacion.Size = new System.Drawing.Size(1045, 110);
            this.listPreparacion.TabIndex = 0;
            this.listPreparacion.UseCompatibleStateImageBehavior = false;
            this.listPreparacion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Preparación";
            this.columnHeader1.Width = 1000;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listComplementos);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1122, 121);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Complementos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listComplementos
            // 
            this.listComplementos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listComplementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listComplementos.FullRowSelect = true;
            this.listComplementos.GridLines = true;
            this.listComplementos.Location = new System.Drawing.Point(8, 6);
            this.listComplementos.MultiSelect = false;
            this.listComplementos.Name = "listComplementos";
            this.listComplementos.Size = new System.Drawing.Size(1045, 105);
            this.listComplementos.TabIndex = 1;
            this.listComplementos.UseCompatibleStateImageBehavior = false;
            this.listComplementos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Complemento";
            this.columnHeader2.Width = 1000;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listDiagnostico);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1122, 121);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Diagnóstico";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listDiagnostico
            // 
            this.listDiagnostico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDiagnostico.FullRowSelect = true;
            this.listDiagnostico.GridLines = true;
            this.listDiagnostico.Location = new System.Drawing.Point(8, 6);
            this.listDiagnostico.MultiSelect = false;
            this.listDiagnostico.Name = "listDiagnostico";
            this.listDiagnostico.Size = new System.Drawing.Size(1045, 104);
            this.listDiagnostico.TabIndex = 2;
            this.listDiagnostico.UseCompatibleStateImageBehavior = false;
            this.listDiagnostico.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Diagnóstico";
            this.columnHeader3.Width = 1000;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_quitar_recursos);
            this.tabPage4.Controls.Add(this.btn_anestesiologos);
            this.tabPage4.Controls.Add(this.txt_Anestesiologo);
            this.tabPage4.Controls.Add(this.btn_ambulancia);
            this.tabPage4.Controls.Add(this.radGridRecursos);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1122, 121);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Recursos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_quitar_recursos
            // 
            this.btn_quitar_recursos.Location = new System.Drawing.Point(699, 88);
            this.btn_quitar_recursos.Name = "btn_quitar_recursos";
            this.btn_quitar_recursos.Size = new System.Drawing.Size(101, 23);
            this.btn_quitar_recursos.TabIndex = 9;
            this.btn_quitar_recursos.Text = "Quitar Recurso";
            this.btn_quitar_recursos.UseVisualStyleBackColor = true;
            this.btn_quitar_recursos.Click += new System.EventHandler(this.btn_quitar_recursos_Click);
            // 
            // btn_anestesiologos
            // 
            this.btn_anestesiologos.Location = new System.Drawing.Point(185, 55);
            this.btn_anestesiologos.Name = "btn_anestesiologos";
            this.btn_anestesiologos.Size = new System.Drawing.Size(120, 23);
            this.btn_anestesiologos.TabIndex = 8;
            this.btn_anestesiologos.Text = "Anestesiólogo(a)";
            this.btn_anestesiologos.UseVisualStyleBackColor = true;
            this.btn_anestesiologos.Click += new System.EventHandler(this.btn_anestesiologos_Click);
            // 
            // txt_Anestesiologo
            // 
            this.txt_Anestesiologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Anestesiologo.FormattingEnabled = true;
            this.txt_Anestesiologo.Location = new System.Drawing.Point(17, 55);
            this.txt_Anestesiologo.Name = "txt_Anestesiologo";
            this.txt_Anestesiologo.Size = new System.Drawing.Size(162, 21);
            this.txt_Anestesiologo.TabIndex = 7;
            // 
            // btn_ambulancia
            // 
            this.btn_ambulancia.Location = new System.Drawing.Point(17, 13);
            this.btn_ambulancia.Name = "btn_ambulancia";
            this.btn_ambulancia.Size = new System.Drawing.Size(120, 23);
            this.btn_ambulancia.TabIndex = 3;
            this.btn_ambulancia.Text = "Ambulancia";
            this.btn_ambulancia.UseVisualStyleBackColor = true;
            this.btn_ambulancia.Click += new System.EventHandler(this.btn_ambulancia_Click);
            // 
            // radGridRecursos
            // 
            this.radGridRecursos.AutoScroll = true;
            this.radGridRecursos.Location = new System.Drawing.Point(311, 13);
            // 
            // 
            // 
            this.radGridRecursos.MasterTemplate.AllowAddNewRow = false;
            this.radGridRecursos.MasterTemplate.AllowDragToGroup = false;
            this.radGridRecursos.MasterTemplate.AllowEditRow = false;
            this.radGridRecursos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridRecursos.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridRecursos.Name = "radGridRecursos";
            this.radGridRecursos.ShowGroupPanel = false;
            this.radGridRecursos.Size = new System.Drawing.Size(382, 98);
            this.radGridRecursos.TabIndex = 2;
            this.radGridRecursos.Text = "radGridView2";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.radGridRequisitos);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1122, 121);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Requsitos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // cita1TableAdapter1
            // 
            this.cita1TableAdapter1.ClearBeforeFill = true;
            // 
            // radGridEstudios
            // 
            this.radGridEstudios.AutoScroll = true;
            this.radGridEstudios.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGridEstudios.Location = new System.Drawing.Point(0, 150);
            // 
            // 
            // 
            this.radGridEstudios.MasterTemplate.AllowAddNewRow = false;
            this.radGridEstudios.MasterTemplate.AllowDragToGroup = false;
            this.radGridEstudios.MasterTemplate.AllowEditRow = false;
            this.radGridEstudios.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridEstudios.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridEstudios.Name = "radGridEstudios";
            this.radGridEstudios.ShowGroupPanel = false;
            this.radGridEstudios.Size = new System.Drawing.Size(1130, 137);
            this.radGridEstudios.TabIndex = 903;
            this.radGridEstudios.Text = "radGridView2";
            // 
            // radGridRequisitos
            // 
            this.radGridRequisitos.AutoScroll = true;
            this.radGridRequisitos.Location = new System.Drawing.Point(8, 3);
            // 
            // 
            // 
            this.radGridRequisitos.MasterTemplate.AllowAddNewRow = false;
            this.radGridRequisitos.MasterTemplate.AllowDragToGroup = false;
            this.radGridRequisitos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridRequisitos.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.radGridRequisitos.Name = "radGridRequisitos";
            this.radGridRequisitos.ShowGroupPanel = false;
            this.radGridRequisitos.Size = new System.Drawing.Size(647, 112);
            this.radGridRequisitos.TabIndex = 904;
            this.radGridRequisitos.Text = "radGridView2";
            // 
            // frmEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1130, 695);
            this.Controls.Add(this.panelScheduler);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelDayTop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBarraAmarilla);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditAppointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditAppointment_FormClosed);
            this.Load += new System.EventHandler(this.frmEditAppointment_Load);
            this.Shown += new System.EventHandler(this.frmEditAppointment_Shown);
            this.SizeChanged += new System.EventHandler(this.frmEditAppointment_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            this.panelScheduler.ResumeLayout(false);
            this.panelScheduler.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDayTop.ResumeLayout(false);
            this.panelDayTop.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPrecios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPrecios)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecursos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecursos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridEstudios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridEstudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRequisitos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRequisitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private schedulerDataDataSetTableAdapters.SALASTableAdapter salasTableAdapter1;
        private schedulerDataDataSetTableAdapters.CITASTableAdapter citasTableAdapter1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private schedulerDataDataSet schedulerDataDataSet;
        private System.Windows.Forms.Panel panelScheduler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panelBarraAmarilla;
        private System.Windows.Forms.Panel panelDayTop;
        private System.Windows.Forms.TextBox txt_doc_total;
        private System.Windows.Forms.TextBox txt_DocEntry;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Panel panelGeneral;
        private schedulerDataDataSetTableAdapters.CITA1TableAdapter cita1TableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_multicita;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_cardtype;
        private System.Windows.Forms.TextBox txt_id_paciente;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido_paterno;
        private System.Windows.Forms.TextBox txt_apellido_materno;
        private System.Windows.Forms.Button btn_AgregarEstudio;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private Telerik.WinControls.UI.RadGridView radGridPrecios;
        private System.Windows.Forms.ComboBox txt_salas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_instituciones;
        private System.Windows.Forms.ComboBox txt_estudios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txt_fecha_naci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listPreparacion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listComplementos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView listDiagnostico;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_quitar_recursos;
        private System.Windows.Forms.Button btn_anestesiologos;
        private System.Windows.Forms.ComboBox txt_Anestesiologo;
        private System.Windows.Forms.Button btn_ambulancia;
        private Telerik.WinControls.UI.RadGridView radGridRecursos;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txt_medico;
        private System.Windows.Forms.Label label13;
        private Telerik.WinControls.UI.RadGridView radGridEstudios;
        private Telerik.WinControls.UI.RadGridView radGridRequisitos;
    }
}