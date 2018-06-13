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
                cs_sapbo sapbo = new cs_sapbo();
                if (txt_salas.Items.Count > 0 && (string)txt_salas.Items[0].Value != "")
                {
                    txt_estudios.AutoCompleteDataSource = sapbo.GET_ESTUDIOS_DDL((string)txt_salas.Items[0].Value);
                    txt_estudios.AutoCompleteValueMember = "ItemCode";
                    txt_estudios.AutoCompleteDisplayMember = "ItemName";
                }
                else
                {
                    txt_estudios.AutoCompleteDataSource = sapbo.GET_ESTUDIOS_DDL("");
                    txt_estudios.AutoCompleteValueMember = "ItemCode";
                    txt_estudios.AutoCompleteDisplayMember = "ItemName";
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
                if (txt_instituciones.Items.Count > 0 && txt_estudios.Items.Count > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (txt_salas.Items.Count > 0)
                        rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_salas.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString());
                    else
                        rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString(), true);
                }
                else
                    rgvPrecios.DataSource = null;
                rgvPrecios.Refresh();
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
                if (txt_estudios.Items.Count > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (txt_salas.Items.Count > 0)
                    {
                        if (txt_instituciones.Items.Count > 0)
                            rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_salas.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString());
                        else
                            rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.Items[0].Value, (string)txt_salas.Items[0].Value);
                    }
                    else
                    {
                        if (txt_instituciones.Items.Count > 0)
                            rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString(), true);
                        else
                            rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.Items[0].Value);
                    }
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
            txt_salas.AutoCompleteDataSource = sapbo.GET_SALAS_DDL(int.Parse(cs_funciones.session_location));
            txt_salas.AutoCompleteValueMember = "RoomCode";
            txt_salas.AutoCompleteDisplayMember = "RoomName";

            txt_instituciones.AutoCompleteDataSource = sapbo.GET_INSTITUCIONES_DDL();
            txt_instituciones.AutoCompleteDisplayMember = "CardName";
            txt_instituciones.AutoCompleteValueMember = "CardCode";

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
            if (txt_estudios.Items.Count > -1 && rgvPrecios.SelectedRows.Count > 0)
            {
                quotingItems.Add(new QuotingItem
                {
                    CodigoProducto = txt_estudios.Items[0].Value.ToString(),
                    Producto = txt_estudios.Text,
                    Sala = txt_salas.Text,
                    Institucion = txt_instituciones.Text,
                    Precio = double.Parse(rgvPrecios.SelectedRows[0].Cells["Price"].Value.ToString())
                });
                rgvListado.Refresh();
                txt_estudios.Clear();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún elemento.", "Seleccione un elemento.", MessageBoxButtons.OK);
            }
        }

        private void txt_salas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cs_sapbo sapbo = new cs_sapbo();
                if (txt_salas.Items.Count > 0 && (string)txt_salas.Items[0].Value != "")
                {
                    txt_estudios.AutoCompleteDataSource = sapbo.GET_ESTUDIOS_DDL((string)txt_salas.Items[0].Value);
                    txt_estudios.AutoCompleteValueMember = "ItemCode";
                    txt_estudios.AutoCompleteDisplayMember = "ItemName";
                }
                else
                {
                    txt_estudios.AutoCompleteDataSource = sapbo.GET_ESTUDIOS_DDL("");
                    txt_estudios.AutoCompleteValueMember = "ItemCode";
                    txt_estudios.AutoCompleteDisplayMember = "ItemName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_estudios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (txt_estudios.Items.Count > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (txt_salas.Items.Count > 0)
                    {
                        if (txt_instituciones.Items.Count > 0)
                            rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_salas.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString());
                        else
                            rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.Items[0].Value, (string)txt_salas.Items[0].Value);
                    }
                    else
                    {
                        if (txt_instituciones.Items.Count > 0)
                            rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString(), true);
                        else
                            rgvPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.Items[0].Value);
                    }
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

        private void txt_instituciones_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_instituciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (txt_instituciones.Items.Count > 0 && txt_estudios.Items.Count > 0)
                {
                    cs_sapbo sapo = new cs_sapbo();
                    if (txt_salas.Items.Count > 0)
                        rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_salas.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString());
                    else
                        rgvPrecios.DataSource = sapo.GET_PRECIOS(txt_estudios.Items[0].Value.ToString(), txt_instituciones.Items[0].Value.ToString(), true);
                }
                else
                    rgvPrecios.DataSource = null;
                rgvPrecios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}