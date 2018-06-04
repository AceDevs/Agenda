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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            cs_funciones.session_id = "";
            cs_funciones.session_name = "";
            cs_funciones.session_type = "";
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Ingrese la información correcta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (sapo.Autentificar(txt_usuario.Text, txt_pass.Text) == true)
                    {
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No existe el usuario en el sistema o ingreso mal la información." + sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sapo = null;
                }
            }
            catch (Exception ex)
            {
                cs_funciones.session_id = "";
                cs_funciones.session_name = "";
                cs_funciones.session_type = "";
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btn_ingresar_Click(null, null);
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btn_ingresar_Click(null, null);
        }
    }
}