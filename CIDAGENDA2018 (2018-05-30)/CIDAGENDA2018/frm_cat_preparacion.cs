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
    public partial class frm_cat_preparacion : Form
    {
        private string _ItemCode = "";
        private bool _flag_nuevo = false;

        public frm_cat_preparacion()
        {
            InitializeComponent();
        }

        private void frm_cat_preparacion_Load(object sender, EventArgs e)
        {
            panelNuevo.Visible = false;

            cs_sapbo sapo = new cs_sapbo();

            DataTable dt = sapo.GET_SALAS_DDL(int.Parse(cs_funciones.session_location));
            txt_salas.DataSource = dt;
            txt_salas.ValueMember = "RoomCode";
            txt_salas.DisplayMember = "RoomName";
            dt = null;

            sapo = null;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (radGridItems.Rows.Count > 0)
            {
                _flag_nuevo = true;
                panelNuevo.Visible = true;
                panelEdit.Visible = false;

                radGridPreparacion.DataSource = null;
                radGridPreparacion.Refresh();

                txt_preparacionNew.Text = "";
                txt_preparacion.Text = "";
                txt_preparacionNew.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estudio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (_flag_nuevo == true)
            {
                if (_ItemCode != "")
                {
                    if (txt_preparacionNew.Text != "")
                    {
                        cs_sapbo sapo = new cs_sapbo();
                        if (sapo.INSERT_PREPARACION(_ItemCode, txt_preparacionNew.Text, DateTime.Now.Date, DateTime.Now.Date, "Y", int.Parse(cs_funciones.session_id)) == true)
                        {
                            radGridPreparacion.DataSource = sapo.GET_PREPARACION(_ItemCode);
                            radGridPreparacion.Refresh();

                            _flag_nuevo = false;
                            panelNuevo.Visible = false;
                            panelEdit.Visible = true;
                            txt_preparacionNew.Text = "";
                            txt_preparacion.Focus();

                            MessageBox.Show("Preparación registrada correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un problema al agregar la información. " + sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        sapo = null;
                    }
                    else
                    {
                        MessageBox.Show("El campo de Preparación esta vacio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Estudio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (radGridItems.Rows.Count > 0)
                {
                    if (_ItemCode != "")
                    {
                        if (radGridPreparacion.Rows.Count > 0)
                        {
                            for (int j = 0; j < radGridPreparacion.Rows.Count; j++)
                            {
                                if (radGridPreparacion.Rows[j].IsSelected == true)
                                {
                                    if (txt_preparacion.Text != "")
                                    {
                                        cs_sapbo sapo = new cs_sapbo();
                                        if (sapo.UPDATE_PREPARACION(int.Parse(radGridPreparacion.Rows[j].Cells["Code"].Value.ToString()), _ItemCode, txt_preparacion.Text, DateTime.Now.Date, "Y", int.Parse(cs_funciones.session_id)) == true)
                                        {
                                            radGridPreparacion.DataSource = sapo.GET_PREPARACION(_ItemCode);
                                            radGridPreparacion.Refresh();
                                            _flag_nuevo = false;

                                            MessageBox.Show("Preparación actualizada correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ocurrio un problema al actualizar la información. " + sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        sapo = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo de Preparación esta vacio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar una Preparación.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Estudio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Estudio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void txt_sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_salas.Text != "")
            {
                cs_sapbo sapo = new cs_sapbo();
                radGridItems.DataSource = sapo.GET_ItemsOITM(txt_salas.SelectedValue.ToString(), 0);
                radGridItems.Refresh();
            }
            else
            {
                radGridItems.DataSource = null;
                radGridItems.Refresh();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            _flag_nuevo = false;
            panelNuevo.Visible = false;
            panelEdit.Visible = true;
            txt_preparacionNew.Text = "";
            txt_preparacion.Text = "";
            _ItemCode = "";
            txt_preparacion.Focus();
        }

        private void radGridItems_SelectionChanged(object sender, EventArgs e)
        {
            txt_preparacion.Text = "";
            for (int i = 0; i < radGridItems.Rows.Count; i++)
            {
                if (radGridItems.Rows[i].IsSelected == true)
                {
                    _ItemCode = radGridItems.Rows[i].Cells["ItemCode"].Value.ToString();

                    // valida que si esta en modo nuevo no muestre la informacion de la preparacion del estudio.
                    if (panelNuevo.Visible == false)
                    {
                        cs_sapbo sapo = new cs_sapbo();
                        radGridPreparacion.DataSource = sapo.GET_PREPARACION(_ItemCode);
                        radGridPreparacion.Refresh();
                        sapo = null;
                    }
                }
            }
        }

        private void radGridPreparacion_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < radGridPreparacion.Rows.Count; i++)
            {
                if (radGridPreparacion.Rows[i].IsSelected == true)
                {
                    txt_preparacion.Text = radGridPreparacion.Rows[i].Cells["Preparacion"].Value.ToString();
                    break;
                }
            }
        }
    }
}