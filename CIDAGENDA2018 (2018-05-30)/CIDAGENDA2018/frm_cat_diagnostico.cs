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
    public partial class frm_cat_diagnostico : Form
    {
        private string _ItemCode = "";
        private bool _flag_nuevo = false;

        public frm_cat_diagnostico()
        {
            InitializeComponent();
        }

        private void frm_cat_diagnostico_Load(object sender, EventArgs e)
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

                radGridDiagnostico.DataSource = null;
                radGridDiagnostico.Refresh();

                txt_diagnosticoNew.Text = "";
                txt_diagnostico.Text = "";
                txt_diagnosticoNew.Focus();
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
                    if (txt_diagnosticoNew.Text != "")
                    {
                        cs_sapbo sapo = new cs_sapbo();
                        if (sapo.INSERT_DIAGNOSTICO(_ItemCode, txt_diagnosticoNew.Text, DateTime.Now.Date, DateTime.Now.Date, "Y", int.Parse(cs_funciones.session_id)) == true)
                        {
                            radGridDiagnostico.DataSource = sapo.GET_DIAGNOSTICO(_ItemCode);
                            radGridDiagnostico.Refresh();

                            _flag_nuevo = false;
                            panelNuevo.Visible = false;
                            panelEdit.Visible = true;
                            txt_diagnosticoNew.Text = "";
                            txt_diagnostico.Focus();

                            MessageBox.Show("Diagnóstico registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un problema al agregar la información. " + sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        sapo = null;
                    }
                    else
                    {
                        MessageBox.Show("El campo de Diagnóstico esta vacío.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (radGridDiagnostico.Rows.Count > 0)
                        {
                            for (int j = 0; j < radGridDiagnostico.Rows.Count; j++)
                            {
                                if (radGridDiagnostico.Rows[j].IsSelected == true)
                                {
                                    if (txt_diagnostico.Text != "")
                                    {
                                        cs_sapbo sapo = new cs_sapbo();
                                        if (sapo.UPDATE_DIAGNOSTICO(int.Parse(radGridDiagnostico.Rows[j].Cells["Code"].Value.ToString()), _ItemCode, txt_diagnostico.Text, DateTime.Now.Date, "Y", int.Parse(cs_funciones.session_id)) == true)
                                        {
                                            radGridDiagnostico.DataSource = sapo.GET_DIAGNOSTICO(_ItemCode);
                                            radGridDiagnostico.Refresh();
                                            _flag_nuevo = false;

                                            MessageBox.Show("Diagnóstico actualizado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ocurrió un problema al actualizar la información. " + sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        sapo = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo de Diagnóstico esta vacío.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un Diagnóstico.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txt_salas_SelectedIndexChanged(object sender, EventArgs e)
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
            txt_diagnosticoNew.Text = "";
            txt_diagnostico.Text = "";
            _ItemCode = "";
            txt_diagnostico.Focus();
        }

        private void radGridItems_SelectionChanged(object sender, EventArgs e)
        {
            txt_diagnostico.Text = "";
            for (int i = 0; i < radGridItems.Rows.Count; i++)
            {
                if (radGridItems.Rows[i].IsSelected == true)
                {
                    _ItemCode = radGridItems.Rows[i].Cells["ItemCode"].Value.ToString();

                    // valida que si esta en modo nuevo no muestre la información de la preparación del estudio.
                    if (panelNuevo.Visible == false)
                    {
                        cs_sapbo sapo = new cs_sapbo();
                        radGridDiagnostico.DataSource = sapo.GET_COMPLEMENTOS(_ItemCode);
                        radGridDiagnostico.Refresh();
                        sapo = null;
                    }
                }
            }
        }

        private void radGridDiagnostico_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < radGridDiagnostico.Rows.Count; i++)
            {
                if (radGridDiagnostico.Rows[i].IsSelected == true)
                {
                    txt_diagnostico.Text = radGridDiagnostico.Rows[i].Cells["Complemento"].Value.ToString();
                    break;
                }
            }
        }
    }
}