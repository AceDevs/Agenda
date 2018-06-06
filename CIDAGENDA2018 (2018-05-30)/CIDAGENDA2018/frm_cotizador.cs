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
    public partial class frm_cotizador : Form
    {
        public frm_cotizador()
        {
            InitializeComponent();
        }

        private void txt_salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs_sapbo sapbo = new cs_sapbo();
            txt_estudios.DataSource = sapbo.GET_ESTUDIOS_DDL((string)txt_salas.SelectedValue);
            txt_estudios.ValueMember = "ItemCode";
            txt_estudios.DisplayMember = "ItemName";
        }

        private void txt_instituciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.SelectedValue, (string)txt_salas.SelectedValue, (string)txt_instituciones.SelectedValue);
                rgvPrecios.Refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txt_estudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.SelectedValue, (string)txt_salas.SelectedValue);
                rgvPrecios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_cotizador_Load(object sender, EventArgs e)
        {
            cs_sapbo sapbo = new cs_sapbo();
            txt_salas.DataSource = sapbo.GET_SALAS_DDL(int.Parse(cs_funciones.session_location));
            txt_salas.ValueMember = "RoomCode";
            txt_salas.DisplayMember = "RoomName";

            txt_instituciones.DataSource = sapbo.GET_INSTITUCIONES_DDL();
            txt_instituciones.DisplayMember = "CardName";
            txt_instituciones.ValueMember = "CardCode";

            rgvListado.DataSource = new List<QuotingItem>();

            sapbo = null;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txt_estudios.SelectedIndex > -1)
            {
                ((List<QuotingItem>)rgvListado.DataSource).Add(new QuotingItem
                {
                    CodigoProducto = txt_estudios.SelectedValue.ToString(),
                    Producto = txt_estudios.SelectedText,
                    Sala = txt_salas.SelectedText,
                    Institucion = txt_instituciones.SelectedText,
                    Precio = (double)rgvPrecios.SelectedRows[0].Cells["Price"].Value
                });
            }
            txt_estudios.SelectedIndex = -1;
        }
    }
}