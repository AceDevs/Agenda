namespace CIDAGENDA2018
{
    partial class frm_cotizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cotizador));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelBarraAmarilla = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelDayTop = new System.Windows.Forms.Panel();
            this.txt_doc_total = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rgvPrecios = new Telerik.WinControls.UI.RadGridView();
            this.txt_salas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instituciones = new System.Windows.Forms.ComboBox();
            this.txt_estudios = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rgvListado = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1.SuspendLayout();
            this.panelDayTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraAmarilla
            // 
            this.panelBarraAmarilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panelBarraAmarilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraAmarilla.Location = new System.Drawing.Point(0, 0);
            this.panelBarraAmarilla.Name = "panelBarraAmarilla";
            this.panelBarraAmarilla.Size = new System.Drawing.Size(671, 6);
            this.panelBarraAmarilla.TabIndex = 907;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salir,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 44);
            this.toolStrip1.TabIndex = 908;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 41);
            this.btn_Salir.Text = "   Salir   ";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // panelDayTop
            // 
            this.panelDayTop.Controls.Add(this.txt_doc_total);
            this.panelDayTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDayTop.Location = new System.Drawing.Point(0, 50);
            this.panelDayTop.Name = "panelDayTop";
            this.panelDayTop.Size = new System.Drawing.Size(671, 33);
            this.panelDayTop.TabIndex = 909;
            // 
            // txt_doc_total
            // 
            this.txt_doc_total.BackColor = System.Drawing.Color.LightBlue;
            this.txt_doc_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_doc_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_doc_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_total.Location = new System.Drawing.Point(419, 0);
            this.txt_doc_total.Multiline = true;
            this.txt_doc_total.Name = "txt_doc_total";
            this.txt_doc_total.ReadOnly = true;
            this.txt_doc_total.Size = new System.Drawing.Size(252, 33);
            this.txt_doc_total.TabIndex = 0;
            this.txt_doc_total.Text = "0.00";
            this.txt_doc_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rgvPrecios);
            this.panel1.Controls.Add(this.txt_salas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_instituciones);
            this.panel1.Controls.Add(this.txt_estudios);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 130);
            this.panel1.TabIndex = 910;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 28);
            this.btnAdd.TabIndex = 120;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rgvPrecios
            // 
            this.rgvPrecios.Dock = System.Windows.Forms.DockStyle.Right;
            this.rgvPrecios.Location = new System.Drawing.Point(347, 0);
            // 
            // 
            // 
            this.rgvPrecios.MasterTemplate.AllowAddNewRow = false;
            this.rgvPrecios.MasterTemplate.AllowColumnReorder = false;
            this.rgvPrecios.MasterTemplate.AllowDeleteRow = false;
            this.rgvPrecios.MasterTemplate.AllowDragToGroup = false;
            this.rgvPrecios.MasterTemplate.AllowEditRow = false;
            this.rgvPrecios.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvPrecios.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvPrecios.Name = "rgvPrecios";
            this.rgvPrecios.ReadOnly = true;
            this.rgvPrecios.ShowGroupPanel = false;
            this.rgvPrecios.Size = new System.Drawing.Size(324, 130);
            this.rgvPrecios.TabIndex = 119;
            this.rgvPrecios.Text = "radGridView1";
            // 
            // txt_salas
            // 
            this.txt_salas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_salas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_salas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salas.FormattingEnabled = true;
            this.txt_salas.Location = new System.Drawing.Point(70, 11);
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(268, 21);
            this.txt_salas.TabIndex = 113;
            this.txt_salas.SelectedIndexChanged += new System.EventHandler(this.txt_salas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Sala";
            // 
            // txt_instituciones
            // 
            this.txt_instituciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_instituciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_instituciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instituciones.FormattingEnabled = true;
            this.txt_instituciones.Location = new System.Drawing.Point(70, 55);
            this.txt_instituciones.Name = "txt_instituciones";
            this.txt_instituciones.Size = new System.Drawing.Size(268, 21);
            this.txt_instituciones.TabIndex = 115;
            this.txt_instituciones.SelectedIndexChanged += new System.EventHandler(this.txt_instituciones_SelectedIndexChanged);
            // 
            // txt_estudios
            // 
            this.txt_estudios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_estudios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_estudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estudios.FormattingEnabled = true;
            this.txt_estudios.Location = new System.Drawing.Point(70, 33);
            this.txt_estudios.Name = "txt_estudios";
            this.txt_estudios.Size = new System.Drawing.Size(268, 21);
            this.txt_estudios.TabIndex = 114;
            this.txt_estudios.SelectedIndexChanged += new System.EventHandler(this.txt_estudios_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Estudio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Institución";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rgvListado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 237);
            this.panel2.TabIndex = 911;
            // 
            // rgvListado
            // 
            this.rgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvListado.Location = new System.Drawing.Point(0, 0);
            this.rgvListado.Margin = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.rgvListado.MasterTemplate.AllowAddNewRow = false;
            this.rgvListado.MasterTemplate.AllowColumnReorder = false;
            this.rgvListado.MasterTemplate.AllowEditRow = false;
            this.rgvListado.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvListado.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvListado.Name = "rgvListado";
            this.rgvListado.Padding = new System.Windows.Forms.Padding(5);
            this.rgvListado.ShowGroupPanel = false;
            this.rgvListado.Size = new System.Drawing.Size(671, 237);
            this.rgvListado.TabIndex = 0;
            this.rgvListado.Text = "radGridView1";
            // 
            // frm_cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDayTop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBarraAmarilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cotizador";
            this.Text = "Cotizador - Unidad Radiologica IRM, S. de R.L. de C.V.";
            this.Load += new System.EventHandler(this.frm_cotizador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDayTop.ResumeLayout(false);
            this.panelDayTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraAmarilla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelDayTop;
        private System.Windows.Forms.TextBox txt_doc_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txt_salas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_instituciones;
        private System.Windows.Forms.ComboBox txt_estudios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView rgvPrecios;
        private System.Windows.Forms.Button btnAdd;
        private Telerik.WinControls.UI.RadGridView rgvListado;
    }
}