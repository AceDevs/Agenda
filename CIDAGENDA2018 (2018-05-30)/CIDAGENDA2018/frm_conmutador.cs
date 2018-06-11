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
    public partial class frm_conmutador : Form
    {
        private bool flag_FillSala = false;
        private bool flag_FillEstudio = false;
        private bool flag_FillInstitu = false;
        private bool flag_StatusSavedCita = false;

        public frm_conmutador()
        {
            InitializeComponent();
        }

        private void InitializeComponents()
        {
            try
            {
                txt_sexo.Items.Add("");
                txt_sexo.Items.Add("MASCULINO");
                txt_sexo.Items.Add("FEMENINO");

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
                //cs_sapbo sapo = new cs_sapbo();
                //this.schedulerBindingDataSource1.EventProvider.DataSource = sapo.GET_CITAS();
                //this.schedulerBindingDataSource1.EventProvider.DataMember = "CITAS";
                //this.schedulerBindingDataSource1.ResourceProvider.DataSource = sapo.GET_SALAS(1);
                //this.schedulerBindingDataSource1.ResourceProvider.DataMember = "SALAS";
                //sapo = null;

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

        private void frm_conmutador_Load(object sender, EventArgs e)
        {
            try
            {
                this.InitializeComponents();

                txt_start.Text = cs_reservar.Start.ToString();
                txt_end.Text = cs_reservar.End.ToString();
                txt_DocEntry.Text = cs_reservar.NewDocEntry.ToString();
                txt_salas.SelectedValue = cs_reservar.ResourceId;

                txt_fecha.Value = cs_reservar.Start.Date;
                radScheduler1.FocusedDate = txt_fecha.Value;

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
                    txt_edad.Text = dtCita.Rows[0]["Age"].ToString();
                    txt_sexo.Text = dtCita.Rows[0]["Sex"].ToString();
                    txt_telefono.Text = dtCita.Rows[0]["Phone1"].ToString();
                    txt_celular.Text = dtCita.Rows[0]["Cellular"].ToString();
                    txt_correo.Text = dtCita.Rows[0]["E_Mail"].ToString();

                    //if (dtCita.Rows[0]["MultiCita"].ToString() == "Y") { cbox_multicita.Checked = true; } else { cbox_multicita.Checked = false; }
                    txt_doc_total.Text = Convert.ToDouble(dtCita.Rows[0]["DocTotal"].ToString()).ToString("C");

                    txt_estudios.SelectedValue = dtCita.Rows[0]["ItemCode"].ToString();
                    txt_instituciones.SelectedValue = dtCita.Rows[0]["InstitutionCode"].ToString();

                    for (int i = 0; i < dtCita.Rows.Count; i++)
                    {
                    }

                    radGridEstudios.DataSource = sapo.GET_CITAS(int.Parse(txt_DocEntry.Text));
                    radGridEstudios.Refresh();
                }
                dtCita = null;
                sapo = null;

                this.InitializeRadScheduler();
                this.InitializeRadSchedulerDataBinding();
                this.InitializeRadSchedulerResource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_conmutador_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frm_conmutador_ResizeEnd(object sender, EventArgs e)
        {
            this.radScheduler1.Height = this.Height;
        }

        private void frm_conmutador_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            this.radScheduler1.Height = this.Height;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radScheduler1_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}