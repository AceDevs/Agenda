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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_estudios = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.txt_salas = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rgvPrecios = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_SectorSalud = new System.Windows.Forms.TextBox();
            this.txt_Aseguradora = new System.Windows.Forms.TextBox();
            this.txt_VentaMostrador = new System.Windows.Forms.TextBox();
            this.rgvListado = new Telerik.WinControls.UI.RadGridView();
            this.num_porcentaje = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraAmarilla
            // 
            this.panelBarraAmarilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(19)))));
            this.panelBarraAmarilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraAmarilla.Location = new System.Drawing.Point(0, 0);
            this.panelBarraAmarilla.Name = "panelBarraAmarilla";
            this.panelBarraAmarilla.Size = new System.Drawing.Size(594, 6);
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
            this.toolStrip1.Size = new System.Drawing.Size(594, 44);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.num_porcentaje);
            this.panel1.Controls.Add(this.txt_estudios);
            this.panel1.Controls.Add(this.txt_salas);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rgvPrecios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 148);
            this.panel1.TabIndex = 910;
            // 
            // txt_estudios
            // 
            this.txt_estudios.Location = new System.Drawing.Point(310, 30);
            this.txt_estudios.Name = "txt_estudios";
            this.txt_estudios.Size = new System.Drawing.Size(268, 26);
            this.txt_estudios.TabIndex = 121;
            this.txt_estudios.SelectionChanged += new Telerik.WinControls.UI.SelectionChangedEventHandler(this.txt_estudios_SelectionChanged);
            // 
            // txt_salas
            // 
            this.txt_salas.Location = new System.Drawing.Point(310, 3);
            this.txt_salas.MaxDropDownItemCount = 10;
            this.txt_salas.Name = "txt_salas";
            this.txt_salas.Size = new System.Drawing.Size(268, 26);
            this.txt_salas.TabIndex = 121;
            this.txt_salas.SelectionChanged += new Telerik.WinControls.UI.SelectionChangedEventHandler(this.txt_salas_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(460, 62);
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
            this.rgvPrecios.Location = new System.Drawing.Point(584, 0);
            // 
            // 
            // 
            this.rgvPrecios.MasterTemplate.AllowAddNewRow = false;
            this.rgvPrecios.MasterTemplate.AllowColumnReorder = false;
            this.rgvPrecios.MasterTemplate.AllowDeleteRow = false;
            this.rgvPrecios.MasterTemplate.AllowDragToGroup = false;
            this.rgvPrecios.MasterTemplate.AllowEditRow = false;
            this.rgvPrecios.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvPrecios.MasterTemplate.EnableSorting = false;
            this.rgvPrecios.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvPrecios.Name = "rgvPrecios";
            this.rgvPrecios.ReadOnly = true;
            this.rgvPrecios.ShowGroupPanel = false;
            this.rgvPrecios.Size = new System.Drawing.Size(10, 148);
            this.rgvPrecios.TabIndex = 119;
            this.rgvPrecios.Text = "radGridView1";
            this.rgvPrecios.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Sala";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 116;
            this.label12.Text = "Estudio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 252);
            this.panel2.TabIndex = 911;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.rgvListado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 252);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 60);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(594, 30);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(53, 5, 54, 5);
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sector Salud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(54, 5, 54, 5);
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aseguradora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(42, 5, 42, 5);
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Venta Mostrador";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_SectorSalud);
            this.panel5.Controls.Add(this.txt_Aseguradora);
            this.panel5.Controls.Add(this.txt_VentaMostrador);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 30);
            this.panel5.TabIndex = 0;
            // 
            // txt_SectorSalud
            // 
            this.txt_SectorSalud.BackColor = System.Drawing.Color.LightBlue;
            this.txt_SectorSalud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SectorSalud.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_SectorSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SectorSalud.Location = new System.Drawing.Point(3, 0);
            this.txt_SectorSalud.Multiline = true;
            this.txt_SectorSalud.Name = "txt_SectorSalud";
            this.txt_SectorSalud.ReadOnly = true;
            this.txt_SectorSalud.Size = new System.Drawing.Size(197, 30);
            this.txt_SectorSalud.TabIndex = 3;
            this.txt_SectorSalud.Text = "0.00";
            this.txt_SectorSalud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Aseguradora
            // 
            this.txt_Aseguradora.BackColor = System.Drawing.Color.LightBlue;
            this.txt_Aseguradora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Aseguradora.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_Aseguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Aseguradora.Location = new System.Drawing.Point(200, 0);
            this.txt_Aseguradora.Multiline = true;
            this.txt_Aseguradora.Name = "txt_Aseguradora";
            this.txt_Aseguradora.ReadOnly = true;
            this.txt_Aseguradora.Size = new System.Drawing.Size(197, 30);
            this.txt_Aseguradora.TabIndex = 2;
            this.txt_Aseguradora.Text = "0.00";
            this.txt_Aseguradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_VentaMostrador
            // 
            this.txt_VentaMostrador.BackColor = System.Drawing.Color.LightBlue;
            this.txt_VentaMostrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_VentaMostrador.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_VentaMostrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VentaMostrador.Location = new System.Drawing.Point(397, 0);
            this.txt_VentaMostrador.Multiline = true;
            this.txt_VentaMostrador.Name = "txt_VentaMostrador";
            this.txt_VentaMostrador.ReadOnly = true;
            this.txt_VentaMostrador.Size = new System.Drawing.Size(197, 30);
            this.txt_VentaMostrador.TabIndex = 1;
            this.txt_VentaMostrador.Text = "0.00";
            this.txt_VentaMostrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rgvListado
            // 
            this.rgvListado.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.rgvListado.Size = new System.Drawing.Size(594, 184);
            this.rgvListado.TabIndex = 0;
            this.rgvListado.Text = "radGridView1";
            // 
            // num_porcentaje
            // 
            this.num_porcentaje.Location = new System.Drawing.Point(12, 120);
            this.num_porcentaje.Name = "num_porcentaje";
            this.num_porcentaje.Size = new System.Drawing.Size(120, 20);
            this.num_porcentaje.TabIndex = 122;
            this.num_porcentaje.ValueChanged += new System.EventHandler(this.num_porcentaje_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Descuento";
            // 
            // frm_cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBarraAmarilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cotizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizador - Unidad Radiologica IRM, S. de R.L. de C.V.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_cotizador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPrecios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraAmarilla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView rgvPrecios;
        private System.Windows.Forms.Button btnAdd;
        private Telerik.WinControls.UI.RadGridView rgvListado;
        private Telerik.WinControls.UI.RadAutoCompleteBox txt_estudios;
        private Telerik.WinControls.UI.RadAutoCompleteBox txt_salas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_SectorSalud;
        private System.Windows.Forms.TextBox txt_Aseguradora;
        private System.Windows.Forms.TextBox txt_VentaMostrador;
        private System.Windows.Forms.NumericUpDown num_porcentaje;
        private System.Windows.Forms.Label label5;
    }
}