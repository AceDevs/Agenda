namespace CIDAGENDA2018
{
    partial class frm_cat_diagnostico
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cat_diagnostico));
            this.panelNuevo = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diagnosticoNew = new System.Windows.Forms.TextBox();
            this.radGridItems = new Telerik.WinControls.UI.RadGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diagnostico = new System.Windows.Forms.TextBox();
            this.radGridDiagnostico = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salas = new System.Windows.Forms.ComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridItems.MasterTemplate)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDiagnostico.MasterTemplate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNuevo
            // 
            this.panelNuevo.Controls.Add(this.btn_cancelar);
            this.panelNuevo.Controls.Add(this.label1);
            this.panelNuevo.Controls.Add(this.txt_diagnosticoNew);
            this.panelNuevo.Location = new System.Drawing.Point(616, 72);
            this.panelNuevo.Name = "panelNuevo";
            this.panelNuevo.Size = new System.Drawing.Size(412, 264);
            this.panelNuevo.TabIndex = 928;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(328, 234);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 915;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 914;
            this.label1.Text = "Diagnóstico";
            // 
            // txt_diagnosticoNew
            // 
            this.txt_diagnosticoNew.Location = new System.Drawing.Point(9, 44);
            this.txt_diagnosticoNew.Multiline = true;
            this.txt_diagnosticoNew.Name = "txt_diagnosticoNew";
            this.txt_diagnosticoNew.Size = new System.Drawing.Size(394, 184);
            this.txt_diagnosticoNew.TabIndex = 913;
            // 
            // radGridItems
            // 
            this.radGridItems.Location = new System.Drawing.Point(12, 115);
            // 
            // 
            // 
            this.radGridItems.MasterTemplate.AllowAddNewRow = false;
            this.radGridItems.MasterTemplate.AllowColumnChooser = false;
            this.radGridItems.MasterTemplate.AllowDeleteRow = false;
            this.radGridItems.MasterTemplate.AllowDragToGroup = false;
            this.radGridItems.MasterTemplate.AllowEditRow = false;
            this.radGridItems.MasterTemplate.AllowRowResize = false;
            this.radGridItems.MasterTemplate.AllowSearchRow = true;
            this.radGridItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridItems.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridItems.Name = "radGridItems";
            this.radGridItems.ReadOnly = true;
            this.radGridItems.ShowGroupPanel = false;
            this.radGridItems.Size = new System.Drawing.Size(598, 474);
            this.radGridItems.TabIndex = 924;
            this.radGridItems.Text = "radGridView1";
            this.radGridItems.SelectionChanged += new System.EventHandler(this.radGridItems_SelectionChanged);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.txt_diagnostico);
            this.panelEdit.Controls.Add(this.radGridDiagnostico);
            this.panelEdit.Location = new System.Drawing.Point(617, 107);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(411, 440);
            this.panelEdit.TabIndex = 927;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 912;
            this.label3.Text = "Diagnóstico";
            // 
            // txt_diagnostico
            // 
            this.txt_diagnostico.Location = new System.Drawing.Point(8, 302);
            this.txt_diagnostico.Multiline = true;
            this.txt_diagnostico.Name = "txt_diagnostico";
            this.txt_diagnostico.Size = new System.Drawing.Size(394, 95);
            this.txt_diagnostico.TabIndex = 906;
            // 
            // radGridDiagnostico
            // 
            this.radGridDiagnostico.Location = new System.Drawing.Point(8, 9);
            // 
            // 
            // 
            this.radGridDiagnostico.MasterTemplate.AllowAddNewRow = false;
            this.radGridDiagnostico.MasterTemplate.AllowColumnChooser = false;
            this.radGridDiagnostico.MasterTemplate.AllowDeleteRow = false;
            this.radGridDiagnostico.MasterTemplate.AllowDragToGroup = false;
            this.radGridDiagnostico.MasterTemplate.AllowEditRow = false;
            this.radGridDiagnostico.MasterTemplate.AllowRowResize = false;
            this.radGridDiagnostico.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridDiagnostico.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridDiagnostico.Name = "radGridDiagnostico";
            this.radGridDiagnostico.ReadOnly = true;
            this.radGridDiagnostico.Size = new System.Drawing.Size(394, 258);
            this.radGridDiagnostico.TabIndex = 906;
            this.radGridDiagnostico.Text = "radGridView2";
            this.radGridDiagnostico.SelectionChanged += new System.EventHandler(this.radGridDiagnostico_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 6);
            this.panel1.TabIndex = 922;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(46, 51);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(53, 51);
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_Guardar,
            this.toolStripSeparator1,
            this.btn_Salir,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1040, 54);
            this.toolStrip1.TabIndex = 923;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(36, 51);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 926;
            this.label2.Text = "Sala";
            // 
            // txt_salas
            // 
            this.txt_salas.FormattingEnabled = true;
            this.txt_salas.Location = new System.Drawing.Point(46, 88);
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(301, 21);
            this.txt_salas.TabIndex = 925;
            this.txt_salas.SelectedIndexChanged += new System.EventHandler(this.txt_salas_SelectedIndexChanged);
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
            this.toolStripButton1.Size = new System.Drawing.Size(98, 51);
            this.toolStripButton1.ToolTipText = "Unidad Radiologica IRM, S. de R.L. de C.V.";
            // 
            // frm_cat_diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1040, 592);
            this.Controls.Add(this.panelNuevo);
            this.Controls.Add(this.radGridItems);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_salas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cat_diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnóstico";
            this.Load += new System.EventHandler(this.frm_cat_diagnostico_Load);
            this.panelNuevo.ResumeLayout(false);
            this.panelNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridItems)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDiagnostico.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDiagnostico)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diagnosticoNew;
        private Telerik.WinControls.UI.RadGridView radGridItems;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diagnostico;
        private Telerik.WinControls.UI.RadGridView radGridDiagnostico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_salas;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}