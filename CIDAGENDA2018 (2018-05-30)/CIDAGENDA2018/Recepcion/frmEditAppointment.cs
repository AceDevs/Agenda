using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CIDAGENDA2018.Recepcion
{
    public partial class frmEditAppointment : Form
    {
        private bool flag_FillSala = false;
        private bool flag_FillEstudio = false;
        private bool flag_FillInstitu = false;
        private bool flag_StatusSavedCita = false;

        private ErrorProvider errorProvider;

        public frmEditAppointment()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        private double GetPrecio()
        {
            try
            {
                double resul = 0;

                for (int i = 0; i < radGridPrecios.Rows.Count; i++)
                {
                    if (radGridPrecios.Rows[i].IsSelected == true)
                    {
                        resul = Convert.ToDouble(radGridPrecios.Rows[i].Cells["Price"].Value);
                        break;
                    }
                }

                return resul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private double GetLineTotal()
        {
            try
            {
                double resul = 0;

                for (int i = 0; i < radGridEstudios.Rows.Count; i++)
                {
                    resul += Convert.ToDouble(radGridEstudios.Rows[i].Cells["LineTotal"].Value);
                }

                return resul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void InsertPaciente()
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                cs_pacientes paciente = new cs_pacientes();

                paciente.CardCode = "";
                paciente.CardName = txt_nombre.Text + " " + txt_apellido_paterno.Text + " " + txt_apellido_materno.Text;
                paciente.FirstName = txt_nombre.Text;
                paciente.FirstSurname = txt_apellido_paterno.Text;
                paciente.SecondSurname = txt_apellido_materno.Text;
                if (txt_edad.Text != "") { paciente.Age = int.Parse(txt_edad.Text); } else { paciente.Age = 0; }
                paciente.Birthday = txt_fecha_naci.Value.Date;
                paciente.Sex = txt_sexo.Text;
                paciente.Phone1 = txt_telefono.Text;
                paciente.Cellular = txt_celular.Text;
                paciente.E_Mail = txt_correo.Text;

                paciente = null;
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeComponents()
        {
            try
            {
                txt_sexo.Items.Add("");
                txt_sexo.Items.Add("MASCULINO");
                txt_sexo.Items.Add("FEMENINO");
                txt_sexo.Items.Add("INDEFINIDO");

                cs_sapbo sapo = new cs_sapbo();

                DataTable dt = sapo.GET_SALAS_DDL(int.Parse(cs_funciones.session_location));
                txt_salas.DataSource = dt;
                txt_salas.ValueMember = "RoomCode";
                txt_salas.DisplayMember = "RoomName";
                dt = null;
                txt_salas.Enabled = false;

                txt_estudios.DataSource = sapo.GET_ESTUDIOS_DDL(cs_reservar.ResourceId);
                txt_estudios.ValueMember = "ItemCode";
                txt_estudios.DisplayMember = "ItemName";

                txt_instituciones.DataSource = sapo.GET_INSTITUCIONES_DDL();
                txt_instituciones.ValueMember = "CardCode";
                txt_instituciones.DisplayMember = "CardName";

                txt_Anestesiologo.DataSource = sapo.GET_ANESTESIOLOGOS_DDL();
                txt_Anestesiologo.ValueMember = "Code";
                txt_Anestesiologo.DisplayMember = "CardName";

                flag_FillSala = true;
                flag_FillEstudio = true;
                flag_FillInstitu = true;
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRadScheduler()
        {
            try
            {
                this.radScheduler1.Height = this.panelScheduler.Height;

                SchedulerDayView dayView = this.radScheduler1.GetDayView();
                dayView.DayCount = 1;
                dayView.RangeFactor = ScaleRange.HalfHour;
                dayView.RulerScaleSize = 15;
                dayView.RulerStartScale = 6;
                dayView.RulerEndScale = 22;
                dayView.RulerFormatStrings = new RulerFormatStrings("hh", "tt", "", "");

                dayView.WorkTime = new TimeInterval(new TimeSpan(6, 0, 0), new TimeSpan(22, 0, 0));
                dayView.WorkWeekStart = DayOfWeek.Monday;
                dayView.WorkWeekEnd = DayOfWeek.Sunday;
                dayView.GroupSeparatorWidth = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRadSchedulerDataBinding()
        {
            try
            {
                // fill all three tables
                citasTableAdapter1.Fill(this.schedulerDataDataSet.CITAS);
                salasTableAdapter1.Fill(this.schedulerDataDataSet.SALAS);
                cita1TableAdapter1.Fill(this.schedulerDataDataSet.CITA1);

                AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
                appointmentMappingInfo.Start = "Start";
                appointmentMappingInfo.End = "End";
                appointmentMappingInfo.Summary = "PatientName";
                appointmentMappingInfo.Description = "DocStatus";
                appointmentMappingInfo.Location = "Location";
                appointmentMappingInfo.BackgroundId = "BackgroundID";
                appointmentMappingInfo.StatusId = "StatusID";
                appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
                appointmentMappingInfo.UniqueId = "DocEntry";
                appointmentMappingInfo.Visible = "Visible";
                appointmentMappingInfo.ResourceId = "ResourceID";
                appointmentMappingInfo.Resources = "FK_CITA1_CITAS";
                this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
                schedulerBindingDataSource1.EventProvider.DataSource = schedulerDataDataSet.CITAS;

                ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
                resourceMappingInfo.Id = "RoomCode";
                resourceMappingInfo.Name = "RoomName";
                this.schedulerBindingDataSource1.ResourceProvider.Mapping = appointmentMappingInfo;
                schedulerBindingDataSource1.ResourceProvider.DataSource = schedulerDataDataSet.SALAS;

                // assign mapped binding data source
                this.radScheduler1.DataSource = schedulerBindingDataSource1;

                schedulerBindingDataSource1.Rebind();
                //radScheduler1.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeRadSchedulerResource()
        {
            try
            {
                radScheduler1.Resources.Clear();
                Resource sala;
                sala = new Resource((string)txt_salas.SelectedValue, txt_salas.Text);
                sala.Color = Color.White;
                radScheduler1.Resources.Add(sala);
                radScheduler1.GroupType = GroupType.Resource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRadSchedulerResources()
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                DataTable dtresource = sapo.GET_SALAS(int.Parse(txt_DocEntry.Text), 1);
                if (dtresource.Rows.Count > 0)
                {
                    this.radScheduler1.Resources.Clear();
                    Resource resourse;
                    for (int i = 0; i < dtresource.Rows.Count; i++)
                    {
                        resourse = new Resource(dtresource.Rows[i]["RoomCode"].ToString(), dtresource.Rows[i]["RoomName"].ToString());
                        resourse.Color = Color.White;
                        this.radScheduler1.Resources.Add(resourse);
                    }
                }
                this.radScheduler1.GroupType = GroupType.Resource;
                this.radScheduler1.ActiveView.ResourcesPerView = dtresource.Rows.Count;

                dtresource = null;
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool AppointmentValidations(AppointmentMovingEventArgs e)
        {
            try
            {
                bool resul = false;

                if (e.Appointment.Description == "N")
                {
                    // validar que una cita no se pueda mover de una sala a otra sala en la misma unidad
                    if (e.NewResourceId.KeyValue.ToString() != e.Appointment.ResourceId.KeyValue.ToString())
                    {
                        MessageBox.Show("No se permite mover la cita a una sala donde el estudio no pertenece.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cs_sapbo sapo = new cs_sapbo();
                        // validar que una cita no se pueda mover en un horario que ya esta ocupado por otra cita
                        if (sapo.GET_CITAS(e.NewDate.Date, e.NewDate, e.NewResourceId.KeyValue.ToString()).Rows.Count > 0)
                        {
                            MessageBox.Show("No se permite mover la cita en este horario. Ya existe una cita registrada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            resul = true;
                        }
                        sapo = null;
                    }
                }
                return resul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void AppointmentUpdate()
        {
            try
            {
                if (txt_nombre.Text == "" || txt_apellido_paterno.Text == "" || txt_apellido_materno.Text == "" || txt_sexo.Text == "" || txt_medico.Text == "")
                {
                    MessageBox.Show("Debe de capturar todos la información de los datos del paciente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cs_sapbo sapo = new cs_sapbo();
                    cs_cita cita = new cs_cita();

                    cita.DocEntry = int.Parse(txt_DocEntry.Text);

                    cita.Start = Convert.ToDateTime(txt_start.Text);
                    int _duracion = sapo.GET_ESTUDIO_Duration((string)txt_estudios.SelectedValue);
                    cita.End = Convert.ToDateTime(txt_start.Text).AddMinutes(_duracion);
                    cita.AppointmentID = int.Parse(txt_DocEntry.Text);
                    cita.ResourceID = (string)txt_salas.SelectedValue;

                    cita.DocNum = int.Parse(txt_DocEntry.Text);
                    cita.CANCELED = "N";
                    cita.DocStatus = "N";
                    cita.DocDate = DateTime.Now.Date;
                    cita.NumAtCard = "";

                    cita.PatientCode = txt_id_paciente.Text;
                    cita.PatientName = txt_nombre.Text + " " + txt_apellido_paterno.Text + " " + txt_apellido_materno.Text;
                    cita.PatientType = txt_cardtype.Text;
                    cita.InstitutionCode = (string)txt_instituciones.SelectedValue;
                    cita.InstitutionName = txt_instituciones.Text;
                    cita.DependencyCode = "";
                    cita.DependencyName = "";
                    cita.DoctorCode = "-1";
                    cita.DoctorName = txt_medico.Text;
                    cita.VatSum = 0;
                    cita.DiscPrcnt = 0;
                    cita.DocCur = "MXP";
                    cita.DocTotal = this.GetLineTotal();
                    cita.PaidToDate = 0;
                    cita.Comments = txt_Observaciones.Text;
                    cita.MultiCita = "N";
                    cita.Series = 0;
                    cita.CreateDate = DateTime.Now.Date;
                    cita.UpdateDate = DateTime.Now.Date;
                    cita.UserSign = 1;
                    cita.VersionNum = "9.2";
                    cita.Summary = "";
                    cita.RecurrenceRule = "";
                    cita.MasterEventID = 0;
                    cita.Location = "";
                    cita.Description = "N";
                    cita.BackgroundID = 2;
                    cita.StatusID = 4;
                    cita.ParentID = 0;
                    cita.Email = "";
                    cita.Visible = 1;

                    if (sapo.UPDATE_CITAS(cita) == false)
                    {
                        MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txt_doc_total.Text = this.GetLineTotal().ToString("C");

                    cita = null;
                    sapo = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEditAppointment_Load(object sender, EventArgs e)
        {
            this.Text = "Editar - " + cs_funciones.CompanyName;
        }

        private void frmEditAppointment_Shown(object sender, EventArgs e)
        {
            try
            {
                this.InitializeComponents();

                if (cs_reservar.Start.ToString() != "")
                {
                    txt_start.Text = cs_reservar.Start.ToString();
                    txt_end.Text = cs_reservar.End.ToString();
                    txt_DocEntry.Text = cs_reservar.NewDocEntry.ToString();
                    txt_salas.SelectedValue = cs_reservar.ResourceId;

                    txt_fecha.Value = cs_reservar.Start.Date;
                    radScheduler1.FocusedDate = txt_fecha.Value;

                    // ===========================================================

                    cs_sapbo sapo = new cs_sapbo();
                    DataTable dtCita = sapo.GET_dtCITAS(int.Parse(txt_DocEntry.Text));
                    if (dtCita.Rows.Count > 0)
                    {
                        txt_salas.SelectedValue = dtCita.Rows[0]["RoomCode"].ToString();

                        txt_id_paciente.Text = dtCita.Rows[0]["CardCode"].ToString();
                        txt_nombre.Text = dtCita.Rows[0]["FirstName"].ToString();
                        txt_apellido_paterno.Text = dtCita.Rows[0]["FirstSurname"].ToString();
                        txt_apellido_materno.Text = dtCita.Rows[0]["SecondSurname"].ToString();
                        txt_fecha_naci.Value = Convert.ToDateTime(dtCita.Rows[0]["Birthday"].ToString());
                        txt_sexo.Text = dtCita.Rows[0]["Sex"].ToString();
                        txt_edad.Text = dtCita.Rows[0]["Age"].ToString();
                        txt_telefono.Text = dtCita.Rows[0]["Phone1"].ToString();
                        txt_celular.Text = dtCita.Rows[0]["Cellular"].ToString();
                        txt_correo.Text = dtCita.Rows[0]["E_Mail"].ToString();
                        //txt_Observaciones.Text = dtCita.Rows[0]["Comments"].ToString();
                        //if (dtCita.Rows[0]["MultiCita"].ToString() == "Y") { cbox_multicita.Checked = true; } else { cbox_multicita.Checked = false; }
                        //txt_doc_total.Text = Convert.ToDouble(dtCita.Rows[0]["DocTotal"].ToString()).ToString("C");

                        txt_estudios.SelectedValue = dtCita.Rows[0]["ItemCode"].ToString();
                        txt_instituciones.SelectedValue = dtCita.Rows[0]["InstitutionCode"].ToString();

                        for (int i = 0; i < dtCita.Rows.Count; i++)
                        {
                        }

                        radGridEstudios.DataSource = sapo.GET_CITAS(int.Parse(txt_DocEntry.Text));
                        radGridEstudios.Refresh();

                        radGridRequisitos.DataSource = sapo.GET_CITAREQUISITOS(int.Parse(txt_DocEntry.Text));
                        radGridRequisitos.Refresh();

                        radGridRecursos.DataSource = sapo.GET_CITARECURSOS(int.Parse(txt_DocEntry.Text));
                        radGridRecursos.Refresh();

                        txt_doc_total.Text = this.GetLineTotal().ToString("C");
                    }
                    dtCita = null;
                    sapo = null;

                    //============================================================
                }
                else
                {
                    radScheduler1.FocusedDate = DateTime.Now.Date;
                }
                this.InitializeRadScheduler();
                this.InitializeRadSchedulerDataBinding();
                this.InitializeRadSchedulerResource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEditAppointment_SizeChanged(object sender, EventArgs e)
        {
            this.panelScheduler.Height = this.Height;
            this.radScheduler1.Height = this.Height;
        }

        private void frmEditAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //if (flag_StatusSavedCita == false)
                //{
                //    cs_sapbo sapo = new cs_sapbo();
                //    sapo.DELETE_CITAS_RESERVADO(int.Parse(txt_DocEntry.Text));
                //    sapo.DELETE_CITA1_RESERVADO(int.Parse(txt_DocEntry.Text));
                //    sapo = null;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {
            radScheduler1.FocusedDate = txt_fecha.Value;
        }

        private void btn_BuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                cs_funciones.var_buscar = txt_nombre.Text + "," + txt_apellido_paterno.Text + "," + txt_apellido_materno.Text +
                "," + txt_sexo.Text + "," + txt_telefono.Text + "," + txt_celular.Text + "," + txt_correo.Text;

                var frm = new frm_search_paciente();
                frm.ShowDialog();
                frm = null;

                cs_sapbo sapo = new cs_sapbo();
                DataTable dt = sapo.GET_PACIENTES(cs_funciones.var_CardCode);
                if (dt.Rows.Count > 0)
                {
                    txt_cardtype.Text = dt.Rows[0]["CardType"].ToString();
                    txt_id_paciente.Text = dt.Rows[0]["CardCode"].ToString();
                    txt_nombre.Text = dt.Rows[0]["FirstName"].ToString();
                    txt_apellido_paterno.Text = dt.Rows[0]["FirstSurname"].ToString();
                    txt_apellido_materno.Text = dt.Rows[0]["SecondSurname"].ToString();
                    txt_fecha_naci.Value = Convert.ToDateTime(dt.Rows[0]["Birthday"].ToString());
                    txt_edad.Text = dt.Rows[0]["Age"].ToString();
                    txt_sexo.Text = dt.Rows[0]["Sex"].ToString();
                    txt_telefono.Text = dt.Rows[0]["Phone1"].ToString();
                    txt_celular.Text = dt.Rows[0]["Cellular"].ToString();
                    txt_correo.Text = dt.Rows[0]["E_Mail"].ToString();
                }
                dt = null;
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag_FillSala == false) { return; }

                cs_sapbo sapo = new cs_sapbo();
                txt_estudios.DataSource = sapo.GET_ESTUDIOS_DDL((string)txt_salas.SelectedValue);
                txt_estudios.ValueMember = "ItemCode";
                txt_estudios.DisplayMember = "ItemName";

                sapo = null;
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
                if (flag_FillEstudio == false) { return; }

                cs_sapbo sapo = new cs_sapbo();
                radGridPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.SelectedValue, (string)txt_salas.SelectedValue);
                radGridPrecios.Refresh();

                DataTable dt = sapo.GET_PREPARACION((string)txt_estudios.SelectedValue);
                listPreparacion.Clear();
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listPreparacion.Items.Add(dt.Rows[i]["Preparacion"].ToString());
                    }
                }
                dt = sapo.GET_COMPLEMENTOS((string)txt_estudios.SelectedValue);
                listComplementos.Clear();
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listComplementos.Items.Add(dt.Rows[i]["Complemento"].ToString());
                    }
                }
                dt = sapo.GET_DIAGNOSTICO((string)txt_estudios.SelectedValue);
                listDiagnostico.Clear();
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listDiagnostico.Items.Add(dt.Rows[i]["Diagnostico"].ToString());
                    }
                }
                sapo = null;
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
                if (flag_FillInstitu == false) { return; }

                cs_sapbo sapo = new cs_sapbo();
                radGridPrecios.DataSource = sapo.GET_PRECIOS((string)txt_estudios.SelectedValue, (string)txt_salas.SelectedValue, (string)txt_instituciones.SelectedValue);
                radGridPrecios.Refresh();
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_paciente.Text == "" || txt_nombre.Text == "" || txt_apellido_paterno.Text == "" || txt_apellido_materno.Text == "" || txt_sexo.Text == "" || txt_medico.Text == "")
                {
                    MessageBox.Show("Debe de capturar todos la información de los datos del paciente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cs_sapbo sapo = new cs_sapbo();

                    this.AppointmentUpdate();

                    if ((string)txt_salas.SelectedValue == "AM005")
                    {
                        //crEtiquetas etiqueta = new crEtiquetas();
                        //DataTable dtReporte = sapo.GET_CITAS(int.Parse(txt_DocEntry.Text));
                        //etiqueta.SetDataSource(dtReporte);

                        //ViewEtiquetas vistaPrevia = new ViewEtiquetas();
                        //vistaPrevia.crystalReportViewer1.ReportSource = etiqueta;
                        //vistaPrevia.ShowDialog();
                        //vistaPrevia = null;
                        //dtReporte = null;
                        //etiqueta.SetDatabaseLogon("sa", "Passw0rd");
                        //etiqueta.SetParameterValue("idDoc", txt_DocEntry.Text);
                        //etiqueta.PrintToPrinter(1, true, 1, 1);
                    }

                    DataTable dt = sapo.GET_CITAS(int.Parse(txt_DocEntry.Text));
                    if (sapo.CreatePedidoORDR(dt) == true)
                    {
                        MessageBox.Show("Creado correctamente la Orden de Trabajo.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(sapo.MessageError);
                    }

                    dt = null;
                    sapo = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radScheduler1_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_ambulancia_Click(object sender, EventArgs e)
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                if (sapo.INSERT_CITARECURSOS(int.Parse(txt_DocEntry.Text), -1, "Ambulancia") == true)
                {
                    radGridRecursos.DataSource = sapo.GET_CITARECURSOS(int.Parse(txt_DocEntry.Text));
                    radGridRecursos.Refresh();
                }
                else
                {
                    MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anestesiologos_Click(object sender, EventArgs e)
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                string code = txt_Anestesiologo.SelectedValue.ToString();
                if (sapo.INSERT_CITARECURSOS(int.Parse(txt_DocEntry.Text), int.Parse(code), txt_Anestesiologo.Text) == true)
                {
                    radGridRecursos.DataSource = sapo.GET_CITARECURSOS(int.Parse(txt_DocEntry.Text));
                    radGridRecursos.Refresh();
                }
                else
                {
                    MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_quitar_recursos_Click(object sender, EventArgs e)
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();
                for (int i = 0; i < radGridRecursos.Rows.Count; i++)
                {
                    if (radGridRecursos.Rows[i].IsSelected == true)
                    {
                        if (sapo.DELETE_CITARECURSOS(int.Parse(txt_DocEntry.Text), int.Parse(radGridRecursos.Rows[i].Cells["RecursoCode"].Value.ToString())) == true)
                        {
                            radGridRecursos.DataSource = sapo.GET_CITARECURSOS(int.Parse(txt_DocEntry.Text));
                            radGridRecursos.Refresh();
                        }
                        else
                        {
                            MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                sapo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea cancelar la cita?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cs_sapbo sapbo = new cs_sapbo();
                    sapbo.CANCEL_CITAS(int.Parse(txt_DocEntry.Text));
                    if (MessageBox.Show("Cita cancelada!\nDesea cerrar esta ventana?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radScheduler1_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
            if (e.Appointment.Description == "C")
                e.AppointmentElement.Visibility = ElementVisibility.Collapsed;
        }
    }
}