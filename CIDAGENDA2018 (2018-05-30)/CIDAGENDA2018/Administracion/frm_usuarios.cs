using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDAGENDA2018.Administracion
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            cs_sapbo sapbo = new cs_sapbo();
            txt_UnidadNegocio.DataSource = sapbo.GET_UnidadNegocio();
            txt_UnidadNegocio.ValueMember = "PrcCode";
            txt_UnidadNegocio.DisplayMember = "PrcName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "")
            {
                MessageBox.Show("Favor de ingresar un usuario a buscar");
            }
            else
            {
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txt_Celular.Enabled = false;
            txt_Email.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Password.Enabled = false;
            txt_Phone1.Enabled = false;
            txt_Phone2.Enabled = false;
            txt_UnidadNegocio.Enabled = false;
            txt_UserName.Enabled = true;
            chk_Admin.Enabled = false;
            btnSearch.Visible = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_UnidadNegocio.SelectedIndex = 0;
            txt_Phone2.Text = "";
            txt_Phone1.Text = "";
            txt_Password.Text = "";
            txt_Nombre.Text = "";
            txt_Id.Text = "";
            txt_Email.Text = "";
            txt_Celular.Text = "";
            chk_Admin.Checked = false;
            btnSearch.Visible = false;
        }
    }
}