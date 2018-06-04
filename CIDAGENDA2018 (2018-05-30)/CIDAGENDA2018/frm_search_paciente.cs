using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDAGENDA2018
{
    public partial class frm_search_paciente : Form
    {
        public frm_search_paciente()
        {
            InitializeComponent();
        }

        private void frm_search_paciente_Load(object sender, EventArgs e)
        {
            cs_sapbo sapo = new cs_sapbo();
            radGridView1.MasterTemplate.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.AllCells);
            if (cs_funciones.var_buscar == ",,,,,,")
            {
                radGridView1.DataSource = sapo.GET_PACIENTES();
            }
            else
            {
                radGridView1.DataSource = sapo.GET_PACIENTES_SEARCH(cs_funciones.var_buscar);
            }
            radGridView1.Refresh();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //frm_datos_paciente frm = new frm_datos_paciente();
            //frm.ShowDialog();
            //frm = null;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            cs_sapbo sapo = new cs_sapbo();
            radGridView1.MasterTemplate.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.AllCells);
            radGridView1.DataSource = sapo.GET_PACIENTES_SEARCH2(txt_buscar.Text);
            radGridView1.Refresh();
            sapo = null;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                if (radGridView1.Rows[i].IsSelected == true)
                {
                    cs_funciones.var_CardCode = (string)radGridView1.Rows[i].Cells["CardCode"].Value;
                }
            }
            this.Dispose();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                cs_funciones.var_buscar = "";
                this.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
