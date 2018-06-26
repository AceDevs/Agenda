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
    public partial class frm_reservar : Form
    {
        public frm_reservar()
        {
            InitializeComponent();
        }

        public bool success = true;
        public int DocEntry { get; set; } = 0;

        public frm_reservar(int docEntry)
        {
            txt_motivo.Enabled = false;
            txt_salas.Enabled = false;
            dtp_fin.Enabled = false;
            dtp_inicio.Enabled = false;
            btnDelete.Visible = true;
            btnReservation.Enabled = true;
            cs_sapbo sapbo = new cs_sapbo();
            DataTable dt = sapbo.GET_Reservado(docEntry);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Ocurrió un problema al intentar abrir el espacio reservado: " + sapbo.MessageError);
                success = false;
                return;
            }
            txt_motivo.Text = dt.Rows[0]["Dscription"].ToString();
            txt_salas.SelectedValue = dt.Rows[0]["RoomCode"].ToString();
            dtp_inicio.Value = DateTime.Parse(dt.Rows[0]["Start"].ToString());
            dtp_fin.Value = DateTime.Parse(dt.Rows[0]["End"].ToString());
            DocEntry = docEntry;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_reservar_Load(object sender, EventArgs e)
        {
            cs_sapbo sapbo = new cs_sapbo();
            txt_salas.DataSource = sapbo.GET_SALAS_DDL(0);
            txt_salas.DisplayMember = "RoomName";
            txt_salas.ValueMember = "RoomCode";
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_motivo.Text))
            {
                MessageBox.Show("Favor de escribir el motivo por el cual se esta reservando la sala.");
                return;
            }
            if (txt_salas.SelectedIndex <= 0)
            {
                MessageBox.Show("Favor de seleccionar una sala.");
                return;
            }

            try
            {
                GenerarCita();
                MessageBox.Show("El espacio se genero correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al intentar generar el espacio: " + ex.Message);
            }
        }

        private bool GenerarCita()
        {
            cs_cita objCita = new cs_cita();
            cs_sapbo sapo = new cs_sapbo();

            objCita.Start = dtp_inicio.Value;
            objCita.End = dtp_fin.Value;
            objCita.DocStatus = "R";
            objCita.Description = "R";
            objCita.PatientCode = "RESERVADO";
            objCita.PatientName = "RESERVADO";

            if (sapo.INSERT_CITAS(objCita) == true)
            {
                objCita.LineNum = 0;
                objCita.TargetType = -1;
                objCita.DocEntry = sapo.NewDocEntry;
                objCita.AppointmentID = sapo.NewDocEntry;
                objCita.ResourceID = txt_salas.SelectedValue.ToString();
                objCita.RoomCode = txt_salas.SelectedValue.ToString();
                objCita.ItemCode = "";
                objCita.Dscription = txt_motivo.Text;
                objCita.Currency = "MXP";

                if (sapo.INSERT_CITA1(objCita) == true)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sapo.DELETE_CITAS_RESERVADO(sapo.NewDocEntry);
                }
            }
            else
            {
                MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            objCita = null;
            sapo = null;
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cs_sapbo sapbo = new cs_sapbo();
            if (DocEntry > 0)
            {
                sapbo.DELETE_CITAS_RESERVADO(DocEntry);
                MessageBox.Show("Se elimino el espacio reservado.");
                Close();
            }
            else
                MessageBox.Show("No se encuentra ningún espacio reservado asignado.");
        }
    }
}