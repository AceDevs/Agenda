using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CIDAGENDA2018
{
    public partial class frm_cotizador : Form
    {
        private BindingList<QuotingItem> quotingItems = new BindingList<QuotingItem>();

        public frm_cotizador()
        {
            InitializeComponent();
        }

        private void txt_salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_salas.SelectedIndex > 0)
                {
                    cs_sapbo sapbo = new cs_sapbo();
                    txt_estudios.DataSource = sapbo.GET_ESTUDIOS_DDL((string)txt_salas.SelectedValue);
                    txt_estudios.ValueMember = "ItemCode";
                    txt_estudios.DisplayMember = "ItemName";
                }
                else
                {
                    txt_estudios.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_instituciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_instituciones.SelectedIndex > 0 && txt_estudios.SelectedIndex > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.SelectedValue.ToString(), txt_salas.SelectedValue.ToString(), txt_instituciones.SelectedValue.ToString());
                    rgvPrecios.Refresh();
                }
                else
                {
                    rgvPrecios.DataSource = null;
                    rgvPrecios.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_estudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_estudios.SelectedIndex > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (txt_instituciones.SelectedIndex > 0)
                        rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.SelectedValue.ToString(), txt_salas.SelectedValue.ToString(), txt_instituciones.SelectedValue.ToString());
                    else
                        rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.SelectedValue, (string)txt_salas.SelectedValue);
                    rgvPrecios.Refresh();
                }
                else
                {
                    rgvPrecios.DataSource = null;
                    rgvPrecios.Refresh();
                }
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

            rgvListado.DataSource = quotingItems;
            GridViewDecimalColumn decimalColumn = (GridViewDecimalColumn)rgvListado.Columns["Precio"];
            decimalColumn.FormatString = "{0:C}";
            quotingItems.ListChanged += QuotingItems_ListChanged;

            sapbo = null;
        }

        private void QuotingItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            txt_doc_total.Text = quotingItems.Sum(i => i.Precio).ToString("C");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txt_estudios.SelectedIndex > -1)
            {
                quotingItems.Add(new QuotingItem
                {
                    CodigoProducto = txt_estudios.SelectedValue.ToString(),
                    Producto = txt_estudios.Text,
                    Sala = txt_salas.Text,
                    Institucion = txt_instituciones.Text,
                    Precio = double.Parse(rgvPrecios.SelectedRows[0].Cells["Price"].Value.ToString())
                });
            }
            //rgvListado.DataSource = quotingItems;
            rgvListado.Refresh();
            txt_estudios.SelectedIndex = -1;
        }
    }
}