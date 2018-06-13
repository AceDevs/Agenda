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

namespace CIDAGENDA2018
{
    public partial class Form1 : Form
    {
        private bool flag_FillSala = false;
        private int _NewDocEntry = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnableMenu()
        {
            try
            {
                btn_IniciarSesion.Enabled = false;
                btn_CerrarSesion.Enabled = true;
                btnAgendarCitas.Enabled = true;
                btnRecepcion.Enabled = true;
                btn_VerAgenda.Enabled = true;
                btn_Complementos.Enabled = true;
                btn_Preparacion.Enabled = true;
                btn_Diagnostico.Enabled = true;
                btn_Salas.Enabled = true;
                btn_Usuarios.Enabled = true;
                btnCotizador.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisabledMenu()
        {
            try
            {
                btn_IniciarSesion.Enabled = true;
                btn_CerrarSesion.Enabled = false;
                btnAgendarCitas.Enabled = false;
                btnRecepcion.Enabled = false;
                btn_VerAgenda.Enabled = false;
                btn_Complementos.Enabled = false;
                btn_Preparacion.Enabled = false;
                btn_Diagnostico.Enabled = false;
                btn_Salas.Enabled = false;
                btn_Usuarios.Enabled = false;
                btnCotizador.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeForm()
        {
            try
            {
                cs_sapbo sapo = new cs_sapbo();

                DataTable dt = sapo.GET_SALAS_DDL(int.Parse(cs_funciones.session_location));
                txt_salas.DataSource = dt;
                txt_salas.ValueMember = "RoomCode";
                txt_salas.DisplayMember = "RoomName";
                dt = null;

                sapo = null;

                flag_FillSala = true;
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
                this.panelTool.Visible = false;
                this.panelScheduler.Visible = false;
                this.radScheduler1.Height = this.panelScheduler.Height;

                SchedulerDayView dayView = this.radScheduler1.GetDayView();
                dayView.DayCount = 1;
                dayView.RangeFactor = ScaleRange.HalfHour;
                dayView.RulerScaleSize = 15;
                dayView.RulerStartScale = 6;
                dayView.RulerEndScale = 22;

                dayView.WorkTime = new TimeInterval(new TimeSpan(6, 0, 0), new TimeSpan(22, 0, 0));
                dayView.WorkWeekStart = DayOfWeek.Monday;
                dayView.WorkWeekEnd = DayOfWeek.Sunday;
                dayView.GroupSeparatorWidth = 5;
                dayView.RulerFormatStrings = new RulerFormatStrings("hh", "tt", "", "");
                dayView.RulerWidth = 45;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRadSchedulerResource()
        {
            try
            {
                this.radScheduler1.Resources.Clear();
                Resource sala;
                sala = new Resource((string)txt_salas.SelectedValue, txt_salas.Text);
                sala.Color = Color.White;
                this.radScheduler1.Resources.Add(sala);
                this.radScheduler1.GroupType = GroupType.Resource;
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
                DataTable dtresource = sapo.GET_SALAS(int.Parse(cs_funciones.session_location));
                if (dtresource.Rows.Count > 0)
                {
                    this.radScheduler1.Resources.Clear();
                    Resource resourse;
                    for (int i = 0; i < dtresource.Rows.Count; i++)
                    {
                        resourse = new Resource(dtresource.Rows[i]["RoomCode"].ToString(), dtresource.Rows[i]["RoomName"].ToString());
                        resourse.Color = Color.White;
                        this.radScheduler1.Resources.Add(resourse);

                        //txt_mostrar_salas.Items.Add((i + 1).ToString());
                    }
                }
                this.radScheduler1.GroupType = GroupType.Resource;
                this.radScheduler1.ActiveView.ResourcesPerView = 5;
                //txt_mostrar_salas.Text = this.radScheduler1.ActiveView.ResourcesPerView.ToString();
                //btn_DayView.Checked = true;

                dtresource = null;
                sapo = null;
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

        private bool AppointmentNuevaCita(AppointmentEditDialogShowingEventArgs e)
        {
            try
            {
                bool resul = false;

                cs_cita objCita = new cs_cita();
                cs_sapbo sapo = new cs_sapbo();

                objCita.Start = e.Appointment.Start;
                objCita.End = e.Appointment.End;
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
                    objCita.ResourceID = e.Appointment.ResourceId.KeyValue.ToString();
                    objCita.RoomCode = e.Appointment.ResourceId.KeyValue.ToString();
                    objCita.ItemCode = "RESERVADO";
                    objCita.Dscription = "RESERVADO";
                    objCita.Currency = "MXP";

                    _NewDocEntry = sapo.NewDocEntry;

                    if (sapo.INSERT_CITA1(objCita) == true)
                    {
                        resul = true;
                    }
                    else
                    {
                        MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sapo.DELETE_CITAS_RESERVADO(_NewDocEntry);
                    }
                }
                else
                {
                    MessageBox.Show(sapo.MessageError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                objCita = null;
                sapo = null;

                return resul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = cs_funciones.CompanyName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.DisabledMenu();
            this.InitializeForm();

            this.InitializeRadScheduler();

            this.InitializeRadSchedulerDataBinding(); // primero carga los datos de la base de datos
            this.InitializeRadSchedulerResources(); // segundo, se da formato y estilo al radscheduler

            this.radScheduler1.Focus();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.radScheduler1.Height = this.Height;
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.ShowDialog();
            frm = null;

            if (cs_funciones.session_id == "")
            {
                this.DisabledMenu();
            }
            else
            {
                this.Form1_Shown(null, null);
                this.EnableMenu();
            }
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            cs_funciones.session_id = "";
            cs_funciones.session_name = "";
            cs_funciones.session_type = "";
            this.DisabledMenu();

            this.panelTool.Visible = false;
            this.panelScheduler.Visible = false;
        }

        private void btnAgendarCitas_Click(object sender, EventArgs e)
        {
            try
            {
                //cs_reservar.Start = DateTime.Now.Date;
                //cs_reservar.End = DateTime.Now.Date;
                //cs_reservar.Estado = "";
                //cs_reservar.ResourceId = "";
                //cs_reservar.NewDocEntry = 0;

                //this.panelTool.Visible = true;
                //this.panelScheduler.Visible = true;

                Conmutador.frmViewAgenda frm = new Conmutador.frmViewAgenda();
                frm.ShowDialog();
                frm = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Recepcion.frmViewAppointment frm = new Recepcion.frmViewAppointment();
                frm.ShowDialog();
                frm = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btn_VerAgenda_Click(object sender, EventArgs e)
        {
            if (radScheduler1.Visible == false)
            {
                this.panelTool.Visible = true;
                this.panelScheduler.Visible = true;
            }
            else
            {
                this.panelTool.Visible = false;
                this.panelScheduler.Visible = false;
            }
        }

        private void btn_Preparacion_Click(object sender, EventArgs e)
        {
            frm_cat_preparacion frm = new frm_cat_preparacion();
            frm.ShowDialog();

            frm = null;
        }

        private void btn_Complementos_Click(object sender, EventArgs e)
        {
            frm_cat_complementos frm = new frm_cat_complementos();
            frm.ShowDialog();
            frm = null;
        }

        private void btn_Diagnostico_Click(object sender, EventArgs e)
        {
            frm_cat_diagnostico frm = new frm_cat_diagnostico();
            frm.ShowDialog();
            frm = null;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void txt_salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag_FillSala == false) { return; }

                if (txt_salas.Text != "")
                {
                    this.InitializeRadSchedulerResource();
                }
                else
                {
                    this.InitializeRadSchedulerResources();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_resource_Click(object sender, EventArgs e)
        {
            int resources = this.radScheduler1.ActiveView.ResourcesPerView;
            int inicio = ((SchedulerViewGroupedByResourceElementBase)this.radScheduler1.ViewElement).ResourceStartIndex;

            ((SchedulerViewGroupedByResourceElementBase)this.radScheduler1.ViewElement).ResourceStartIndex = (inicio - resources);
        }

        private void btn_forward_resource_Click(object sender, EventArgs e)
        {
            int resources = this.radScheduler1.ActiveView.ResourcesPerView;
            int inicio = ((SchedulerViewGroupedByResourceElementBase)this.radScheduler1.ViewElement).ResourceStartIndex;

            ((SchedulerViewGroupedByResourceElementBase)this.radScheduler1.ViewElement).ResourceStartIndex = (inicio + resources);
        }

        private void radScheduler1_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void radScheduler1_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            AppointmentElement appElement = sender as AppointmentElement;
            if (appElement != null)
            {
                cs_sapbo sapo = new cs_sapbo();

                e.ToolTip.AutoPopDelay = 15000;
                e.ToolTip.ToolTipIcon = ToolTipIcon.Info;
                e.ToolTip.ToolTipTitle = "Cita " + appElement.Start.ToShortDateString();

                e.ToolTipText =
                    "Horario: " + appElement.Start.TimeOfDay.ToString() + " " + appElement.End.TimeOfDay.ToString() + " " +
                    Environment.NewLine +
                    "Paciente: " + appElement.Appointment.Summary + " " +
                    Environment.NewLine +
                    "Estudio: " + sapo.GET_CITAS_ItemName(int.Parse(appElement.Appointment.UniqueId.KeyValue.ToString()));

                sapo = null;
            }
        }

        private void radScheduler1_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
        }

        private void radScheduler1_AppointmentResizeEnd(object sender, SchedulerAppointmentEventArgs e)
        {
            try
            {
                if (e.Appointment.Description == "N")
                {
                    citasTableAdapter1.Update(this.schedulerDataDataSet.CITAS);
                    cita1TableAdapter1.Update(this.schedulerDataDataSet.CITA1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radScheduler1_AppointmentDropping(object sender, AppointmentMovingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                if (this.AppointmentValidations(e) == true)
                {
                    // mover de lugar la cita correctamente
                    TimeSpan _hora_start = new TimeSpan(e.Appointment.Start.Hour, e.Appointment.Start.Minute, e.Appointment.Start.Second);
                    TimeSpan _hora_end = new TimeSpan(e.Appointment.End.Hour, e.Appointment.End.Minute, e.Appointment.End.Second);
                    TimeSpan _diferencia = _hora_end.Subtract(_hora_start);

                    DateTime _Start = e.NewDate;
                    DateTime _End = _Start.Add(_diferencia);
                    DateTime _DocDate = e.NewDate.Date;
                    int _DocEntry = int.Parse(e.Appointment.UniqueId.KeyValue.ToString());

                    cs_sapbo sapo = new cs_sapbo();
                    if (sapo.UPDATE_CITAS(_Start, _End, _DocDate, _DocEntry) == true)
                    {
                        if (sapo.UPDATE_CITA1(_Start, _End, _DocDate, _DocEntry) == true)
                        {
                            this.InitializeRadSchedulerDataBinding(); // primero carga los datos de la base de datos

                            if (txt_salas.Text != "") this.InitializeRadSchedulerResource();
                            else this.InitializeRadSchedulerResources();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema al mover la cita, por favor intentar de nuevo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sapo = null;
                }
                else
                {
                    // no dejar mover de lugar la cita.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.Cancel = true;

            try
            {
                if (e.Appointment.DataItem != null)
                {
                    cs_reservar.Start = e.Appointment.Start;
                    cs_reservar.End = e.Appointment.End;
                    cs_reservar.ResourceId = e.Appointment.ResourceId.KeyValue.ToString();
                    cs_reservar.NewDocEntry = int.Parse(e.Appointment.UniqueId.KeyValue.ToString());

                    frm_conmutador frm = new frm_conmutador();
                    frm.ShowDialog();
                    frm = null;
                }
                else
                {
                    if (this.AppointmentNuevaCita(e) == true)
                    {
                        cs_reservar.Start = e.Appointment.Start;
                        cs_reservar.End = e.Appointment.End;
                        cs_reservar.Estado = "RESERVADO";
                        cs_reservar.ResourceId = e.Appointment.ResourceId.KeyValue.ToString();
                        cs_reservar.NewDocEntry = _NewDocEntry;

                        frm_agendar frm = new frm_agendar();
                        frm.ShowDialog();
                        frm = null;

                        this.InitializeRadSchedulerDataBinding(); // primero carga los datos de la base de datos
                        if (txt_salas.Text != "") this.InitializeRadSchedulerResource();
                        else this.InitializeRadSchedulerResources();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Salas_Click(object sender, EventArgs e)
        {
        }

        private void btnCotizador_Click(object sender, EventArgs e)
        {
            frm_cotizador frm = new frm_cotizador();
            frm.Show();
        }

        private void radScheduler1_AppointmentFormatting_1(object sender, SchedulerAppointmentEventArgs e)
        {
            try
            {
                if (e.Appointment.Description == "N")
                {
                    e.AppointmentElement.BorderColor = Color.DarkBlue;
                    e.AppointmentElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    e.AppointmentElement.BorderWidth = 1;
                    e.AppointmentElement.BackColor = Color.White;
                    e.AppointmentElement.BackColor2 = Color.White;
                    e.AppointmentElement.BackColor3 = Color.White;
                }
                else if (e.Appointment.Description == "C")
                {
                    e.AppointmentElement.Visibility = ElementVisibility.Collapsed;
                    e.AppointmentElement.BorderColor = Color.Gold;
                    e.AppointmentElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    e.AppointmentElement.BorderWidth = 1;
                    e.AppointmentElement.BackColor = Color.Gold;
                    e.AppointmentElement.BackColor2 = Color.Gold;
                    e.AppointmentElement.BackColor3 = Color.Gold;
                }
                else if (e.Appointment.Description == "D")
                {
                    e.AppointmentElement.BorderColor = Color.IndianRed;
                    e.AppointmentElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    e.AppointmentElement.BorderWidth = 1;
                    e.AppointmentElement.BackColor = Color.IndianRed;
                    e.AppointmentElement.BackColor2 = Color.IndianRed;
                    e.AppointmentElement.BackColor3 = Color.IndianRed;
                }
                else if (e.Appointment.Description == "P")
                {
                    e.AppointmentElement.BorderColor = Color.LightGreen;
                    e.AppointmentElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    e.AppointmentElement.BorderWidth = 1;
                    e.AppointmentElement.BackColor = Color.LightGreen;
                    e.AppointmentElement.BackColor2 = Color.LightGreen;
                    e.AppointmentElement.BackColor3 = Color.LightGreen;
                }
                else if (e.Appointment.Description == "R")
                {
                    e.AppointmentElement.BorderColor = Color.Gray;
                    e.AppointmentElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    e.AppointmentElement.BorderWidth = 1;
                    e.AppointmentElement.BackColor = Color.Gray;
                    e.AppointmentElement.BackColor2 = Color.Gray;
                    e.AppointmentElement.BackColor3 = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            if (cs_funciones.session_type != "Y")
            {
                MessageBox.Show("No tienes permiso para ingresar a este modulo.");
            }
        }
    }
}