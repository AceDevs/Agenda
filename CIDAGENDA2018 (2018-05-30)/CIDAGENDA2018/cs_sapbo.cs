using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CIDAGENDA2018
{
    public class cs_sapbo
    {
        private string _message_error = "";
        private string _SQLClientConnection = "";
        private string _SAPConnectionJSON = "";
        private string _DataBaseSAP = "";
        private int _NewDocEntry = 0;

        // SAPBO ===================================================================================================

        private SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
        private SAPbobsCOM.Company oCompany2 = new SAPbobsCOM.Company();
        private int lErrCode = 0;
        private int lRetCode;
        private string sErrMsg;
        public int NewDocNumORDR = 0;

        // ===================================================================================================

        public string MessageError
        {
            get { return _message_error; }
        }

        public int NewDocEntry
        {
            get { return _NewDocEntry; }
            set { _NewDocEntry = value; }
        }

        public cs_sapbo()
        {
            _SQLClientConnection = Properties.Settings.Default.ConnectionStringSQL;
            _SAPConnectionJSON = Properties.Settings.Default.ConnectionStringJSON;

            string[] data_base = _SAPConnectionJSON.Split(',');
            _DataBaseSAP = data_base[2].ToString();
            data_base = null;
        }

        // Metodos de SAP ===============================================================================================================

        public bool ConnectCompany()
        {
            //Conectar compañia de SAP
            try
            {
                bool resul = false;
                string[] conn = _SAPConnectionJSON.Split(',');

                if (oCompany.Connected == true) { oCompany.Disconnect(); }

                // <value>tie-desarrollo1,MSSQL2014,Cid,sa,Passw0rd,manager,sapo,tie-desarrollo1</value>

                oCompany.Server = conn[0].ToString();
                oCompany.language = SAPbobsCOM.BoSuppLangs.ln_Spanish_La; //Lenguaje para la sesión.
                oCompany.UseTrusted = false;
                oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes)8;
                oCompany.DbUserName = conn[3].ToString();
                oCompany.DbPassword = conn[4].ToString();
                oCompany.CompanyDB = conn[2].ToString();
                oCompany.UserName = conn[5].ToString();
                oCompany.Password = conn[6].ToString();

                oCompany.LicenseServer = conn[7].ToString() + ":30000";

                lRetCode = oCompany.Connect();
                if (lRetCode != 0)
                {
                    oCompany.GetLastError(out lErrCode, out sErrMsg);
                    _message_error = lErrCode + "." + sErrMsg;
                }
                else
                {
                    resul = true;
                }

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return false;
            }
        }

        public bool CreatePedidoORDR(DataTable dtPedido)
        {
            try
            {
                bool resul = false;

                if (ConnectCompany() == true)
                {
                    SAPbobsCOM.Documents oDocto;
                    oDocto = (SAPbobsCOM.Documents)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders);

                    oDocto.DocDate = DateTime.Now;
                    oDocto.DocDueDate = DateTime.Now;
                    //oDocto.TaxDate = DateTime.Now;
                    oDocto.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items;
                    //oDocto.Series = int.Parse(dtPedido.Rows[0]["Series"].ToString());
                    oDocto.CardCode = dtPedido.Rows[0]["InstitutionCode"].ToString();
                    oDocto.CardName = dtPedido.Rows[0]["InstitutionName"].ToString();
                    oDocto.Comments = dtPedido.Rows[0]["Comments"].ToString();

                    //oDocto.DocCurrency = dtPedido.Rows[0]["Currency"].ToString();

                    //if (dtPedido.Rows[0]["Confirmed"].ToString() == "Y") { oDocto.Confirmed = SAPbobsCOM.BoYesNoEnum.tYES; }
                    //else { oDocto.Confirmed = SAPbobsCOM.BoYesNoEnum.tNO; }

                    for (int i = 0; i < dtPedido.Rows.Count; i++)
                    {
                        oDocto.Lines.SetCurrentLine(i);
                        oDocto.Lines.ItemCode = dtPedido.Rows[i]["ItemCode"].ToString();
                        oDocto.Lines.ItemDescription = dtPedido.Rows[i]["Dscription"].ToString();
                        oDocto.Lines.Quantity = double.Parse(dtPedido.Rows[i]["Quantity"].ToString());

                        if (double.Parse(dtPedido.Rows[i]["DiscPrcnt"].ToString()) > 0)
                        {
                            oDocto.Lines.Price = double.Parse(dtPedido.Rows[i]["Price"].ToString());
                            //oDocto.Lines.UnitPrice = double.Parse(dtPedido.Rows[i]["Price"].ToString());
                            //oDocto.Lines.DiscountPercent = double.Parse(dtPedido.Rows[i]["DiscPrcnt"].ToString());
                            //oDocto.Lines.LineTotal = double.Parse(dtPedido.Rows[i]["LineTotal"].ToString());
                        }
                        else
                        {
                            oDocto.Lines.Price = double.Parse(dtPedido.Rows[i]["Price"].ToString());
                            //oDocto.Lines.UnitPrice = double.Parse(dtPedido.Rows[i]["Price"].ToString());
                            //oDocto.Lines.DiscountPercent = double.Parse(dtPedido.Rows[i]["DiscPrcnt"].ToString());
                            //oDocto.Lines.LineTotal = double.Parse(dtPedido.Rows[i]["LineTotal"].ToString());
                        }

                        //oDocto.Lines.Currency = dtPedido.Rows[i]["Currency"].ToString();
                        //oDocto.Lines.WarehouseCode = dtPedido.Rows[i]["WhsCode"].ToString();
                        //oDocto.Lines.AccountCode = dtPedido.Rows[i]["AcctCode"].ToString();
                        //oDocto.Lines.COGSAccountCode = dtPedido.Rows[i]["CogsAcct"].ToString();
                        //oDocto.Lines.CostingCode = dtPedido.Rows[i]["OcrCode"].ToString();
                        //oDocto.Lines.CostingCode3 = dtPedido.Rows[i]["OcrCode3"].ToString();

                        oDocto.UserFields.Fields.Item("U_PacienteID").Value = dtPedido.Rows[0]["PatientCode"].ToString();
                        oDocto.UserFields.Fields.Item("U_PacienteName").Value = dtPedido.Rows[0]["PatientName"].ToString();

                        oDocto.Lines.Add();
                    }

                    lRetCode = oDocto.Add();
                    if (lRetCode != 0)
                    {
                        oCompany.GetLastError(out lErrCode, out sErrMsg);
                        _message_error = lErrCode + " " + sErrMsg;
                        resul = false;
                    }
                    else
                    {
                        resul = true;
                        //NewDocNumORDR = this.GetDocNumFC(int.Parse(oCompany.GetNewObjectKey()));
                    }
                    oDocto.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oDocto);
                    GC.Collect();
                }

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_MEDICO_DDL()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'DoctorCode', '' as 'DoctorName' union all select Distinct DoctorCode,DoctorName from [cid].[CITAS]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        // ===============================================================================================================

        public DataTable GET_Usuario(string userCode)
        {
            try
            {
                bool resul = false;

                SqlConnection conn;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt = new DataTable();
                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[USUARIOS] where [USER_CODE]=@USER_CODE", conn);
                cmd.Parameters.AddWithValue("USER_CODE", userCode);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Autentificar(string USER_CODE, string PASSWORD)
        {
            try
            {
                bool resul = false;

                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[USUARIOS] where [USER_CODE]=@USER_CODE and [PASSWORD]=@PASSWORD ", conn);
                cmd.Parameters.AddWithValue("USER_CODE", USER_CODE);
                cmd.Parameters.AddWithValue("PASSWORD", PASSWORD);

                reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    cs_funciones.session_id = reader["USERID"].ToString();
                    cs_funciones.session_name = reader["U_NAME"].ToString();
                    cs_funciones.session_type = reader["SUPERUSER"].ToString();
                    cs_funciones.session_location = reader["IDSucursal"].ToString();

                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return false;
            }
        }

        public DataTable GET_CITAS_RGV(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T1.RoomCode,T2.RoomName,T1.ItemCode,T1.Dscription,T1.[Start],T1.[End],T1.[Quantity],T1.[Price],T1.DiscPrcnt,T1.LineTotal " +
                                "from [cid].[CITAS] T0 inner join [cid].[CITA1] T1 on T1.DocEntry=T0.DocEntry " +
                                " inner join [cid].[SALAS] T2 on T2.RoomCode=T1.RoomCode " +
                                "where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_CITAS(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.DocEntry,T0.[Start],T0.[End],T0.[DocDate],T0.[DocTotal],T0.[Comments] " +
                                    ",T0.[PatientCode],T0.[PatientName],T0.[PatientType],T0.[InstitutionCode],T0.[InstitutionName] " +
                                    ",T1.RoomCode,T1.ItemCode,T1.Dscription,T1.[Start],T1.[End],T1.[Quantity],T1.[Price],T1.DiscPrcnt,T1.LineTotal " +
                                "from [cid].[CITAS] T0 inner join [cid].[CITA1] T1 on T1.DocEntry=T0.DocEntry " +
                                "where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_CITAS_ETIQUETAS(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.DocEntry,T0.[PatientCode],T0.[PatientName] " +
                                    ",T1.RoomCode,T1.ItemCode,T1.Dscription,T2.CardName,T2.Age,T2.Sex " +
                                "from [cid].[CITAS] T0 inner join [cid].[CITA1] T1 on T1.DocEntry=T0.DocEntry " +
                                    "inner join [cid].[PACIENTES] T2 on T2.CardCode=T0.PatientCode " +
                                "where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_CITAS(DateTime DocDate, DateTime Start, string ResourceID)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.DocEntry,T0.[Start],T0.[End],T0.[DocDate],T0.[DocTotal],T0.Comments " +
                                    ",T0.[PatientCode],T0.[PatientName],T0.[PatientType],T0.[InstitutionCode],T0.[InstitutionName] " +
                                    ",T1.RoomCode,T1.ItemCode,T1.Dscription,T1.[Start],T1.[End],T1.[Quantity],T1.[Price],T1.DiscPrcnt,T1.LineTotal " +
                                "from[cid].[CITAS] T0 inner join[cid].[CITA1] T1 on T1.DocEntry = T0.DocEntry " +
                                "where T0.[DocDate]=@DocDate and T0.[Start]=@Start and T1.[ResourceID]=@ResourceID";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocDate", DocDate);
                cmd.Parameters.AddWithValue("Start", Start);
                cmd.Parameters.AddWithValue("ResourceID", ResourceID);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public string GET_CITAS_ItemName(int DocEntry)
        {
            try
            {
                string resul = "";
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                string query = "select T0.DocEntry,T0.[Start],T0.[End],T0.[DocDate],T0.[PatientName],T1.RoomCode,T1.ItemCode,T1.Dscription,T1.Start,T1.[End] " +
                              "from [cid].[CITAS] T0 inner join[cid].[CITA1] T1 on T1.DocEntry = T0.DocEntry where T0.DocEntry=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = reader["Dscription"].ToString();
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return "";
            }
        }

        public string GET_CITAS_DocStatus(int DocEntry)
        {
            try
            {
                string resul = "";
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                string query = "select T0.DocEntry,T0.DocStatus,T0.[Start],T0.[End],T0.[DocDate],T0.[PatientName],T1.RoomCode,T1.ItemCode,T1.Dscription,T1.Start,T1.[End] " +
                              "from [cid].[CITAS] T0 inner join[cid].[CITA1] T1 on T1.DocEntry = T0.DocEntry where T0.DocEntry=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = reader["DocStatus"].ToString();
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return "";
            }
        }

        public bool MISMO_HORARIO_CITA1(int DocEntry, DateTime Start)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[CITA1] where DocEntry=@DocEntry and [Start]=@Start and (ItemCode<>'RESERVADO')", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("Start", Start);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_dtCITAS(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.DocEntry,T0.[DocDate],T0.[Start],T0.[End],T0.MultiCita,T0.InstitutionCode,T0.InstitutionName,T0.DocTotal,T0.Comments " +
                                "   ,T1.RoomCode,T1.ItemCode, T0.DoctorCode, T0.DoctorName,T1.Dscription,T1.LineNum,T1.[Start],T1.[End],T1.Price,T1.DiscPrcnt,T1.LineTotal " +
                                "   ,T2.CardCode,T2.CardName,T2.CardType,T2.FirstName,T2.MiddleName,T2.FirstSurname,T2.SecondSurname,T2.Sex,T2.Birthday,T2.Age,T2.Phone1,T2.Cellular,T2.E_Mail " +
                                "from[cid].[CITAS] T0 " +
                                "   inner join[cid].[CITA1] T1 on T1.DocEntry=T0.DocEntry " +
                                "   inner join[cid].[PACIENTES] T2 on T2.CardCode=T0.PatientCode " +
                                "where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_dtCITA1(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [cid].[CITA1] where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public int GET_CITAS_DocEntry()
        {
            try
            {
                int resul = 0;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                string query = "select max(DocEntry) as 'DocEntry' from [cid].[CITAS]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = int.Parse(reader["DocEntry"].ToString());
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return 0;
            }
        }

        public int GET_CITA1_LineNum(int DocEntry)
        {
            try
            {
                int resul = 0;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                string query = "select max(LineNum)+1 as 'LineNum' from [cid].[CITA1] where DocEntry=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = int.Parse(reader["LineNum"].ToString());
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return 0;
            }
        }

        public int GET_ESTUDIO_Duration(string ItemCode)
        {
            try
            {
                int resul = 0;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                string query = "select U_Duracion from  " + _DataBaseSAP + ".[dbo].[OITM] where ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = int.Parse(reader["U_Duracion"].ToString());
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return 0;
            }
        }

        public bool INSERT_CITAS(cs_cita cita)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[INSERT_CITAS] @DocNum,@CANCELED,@DocStatus,@DocDate,@NumAtCard,@PatientCode,@PatientName,@PatientType,@InstitutionCode,@InstitutionName,@DependencyCode,@DependencyName,@DoctorCode,@DoctorName,@VatSum,@DiscPrcnt,@DocCur,@DocTotal,@PaidToDate,@Comments,@MultiCita,@Series,@CreateDate,@UpdateDate,@UserSign,@VersionNum,@Summary,@Start,@End,@RecurrenceRule,@MasterEventID,@Location,@Description,@BackgroundID,@StatusID,@ParentID,@Email,@Visible", conn);
                cmd.Parameters.AddWithValue("DocNum", cita.DocNum);
                cmd.Parameters.AddWithValue("CANCELED", cita.CANCELED);
                cmd.Parameters.AddWithValue("DocStatus", cita.DocStatus);
                cmd.Parameters.AddWithValue("DocDate", cita.DocDate);
                cmd.Parameters.AddWithValue("NumAtCard", cita.NumAtCard);
                cmd.Parameters.AddWithValue("PatientCode", cita.PatientCode);
                cmd.Parameters.AddWithValue("PatientName", cita.PatientName);
                cmd.Parameters.AddWithValue("PatientType", cita.PatientType);
                cmd.Parameters.AddWithValue("InstitutionCode", cita.InstitutionCode);
                cmd.Parameters.AddWithValue("InstitutionName", cita.InstitutionName);
                cmd.Parameters.AddWithValue("DependencyCode", cita.DependencyCode);
                cmd.Parameters.AddWithValue("DependencyName", cita.DependencyName);
                cmd.Parameters.AddWithValue("DoctorCode", cita.DoctorCode);
                cmd.Parameters.AddWithValue("DoctorName", cita.DoctorName);
                cmd.Parameters.AddWithValue("VatSum", cita.VatSum);
                cmd.Parameters.AddWithValue("DiscPrcnt", cita.DiscPrcnt);
                cmd.Parameters.AddWithValue("DocCur", cita.DocCur);
                cmd.Parameters.AddWithValue("DocTotal", cita.DocTotal);
                cmd.Parameters.AddWithValue("PaidToDate", cita.PaidToDate);
                cmd.Parameters.AddWithValue("Comments", cita.Comments);
                cmd.Parameters.AddWithValue("MultiCita", cita.MultiCita);
                cmd.Parameters.AddWithValue("Series", cita.Series);
                cmd.Parameters.AddWithValue("CreateDate", cita.CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", cita.UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", cita.UserSign);
                cmd.Parameters.AddWithValue("VersionNum", cita.VersionNum);
                cmd.Parameters.AddWithValue("Summary", cita.Summary);
                cmd.Parameters.AddWithValue("Start", cita.Start);
                cmd.Parameters.AddWithValue("End", cita.End);
                cmd.Parameters.AddWithValue("RecurrenceRule", cita.RecurrenceRule);
                cmd.Parameters.AddWithValue("MasterEventID", cita.MasterEventID);
                cmd.Parameters.AddWithValue("Location", cita.Location);
                cmd.Parameters.AddWithValue("Description", cita.Description);
                cmd.Parameters.AddWithValue("BackgroundID", cita.BackgroundID);
                cmd.Parameters.AddWithValue("StatusID", cita.StatusID);
                cmd.Parameters.AddWithValue("ParentID", cita.ParentID);
                cmd.Parameters.AddWithValue("Email", cita.Email);
                cmd.Parameters.AddWithValue("Visible", cita.Visible);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    _NewDocEntry = int.Parse(reader["DocEntry"].ToString());
                    resul = true;
                }

                //int r = cmd.ExecuteNonQuery();
                //if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        internal bool MultiCitas(string RoomCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[SALAS] where RoomCode=@RoomCode and (MultiCitas<>'N')", conn);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool INSERT_CITA1(cs_cita cita)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[INSERT_CITA1] @DocEntry,@LineNum,@TargetType,@TrgetEntry,@ItemCode,@Dscription,@Quantity,@Price,@RoomCode,@Currency,@DiscPrcnt,@LineTotal,@PriceBefDi,@DocDate,@Start,@End,@AppointmentID,@ResourceID", conn);
                cmd.Parameters.AddWithValue("DocEntry", cita.DocEntry);
                cmd.Parameters.AddWithValue("LineNum", cita.LineNum);
                cmd.Parameters.AddWithValue("TargetType", cita.TargetType);
                cmd.Parameters.AddWithValue("TrgetEntry", cita.TrgetEntry);
                cmd.Parameters.AddWithValue("ItemCode", cita.ItemCode);
                cmd.Parameters.AddWithValue("Dscription", cita.Dscription);
                cmd.Parameters.AddWithValue("Quantity", cita.Quantity);
                cmd.Parameters.AddWithValue("Price", cita.Price);
                cmd.Parameters.AddWithValue("RoomCode", cita.RoomCode);
                cmd.Parameters.AddWithValue("Currency", cita.Currency);
                cmd.Parameters.AddWithValue("DiscPrcnt", cita.DiscPrcnt1);
                cmd.Parameters.AddWithValue("LineTotal", cita.LineTotal);
                cmd.Parameters.AddWithValue("PriceBefDi", cita.PriceBefDi);
                cmd.Parameters.AddWithValue("DocDate", cita.DocDate);
                cmd.Parameters.AddWithValue("Start", cita.Start);
                cmd.Parameters.AddWithValue("End", cita.End);
                cmd.Parameters.AddWithValue("AppointmentID", cita.AppointmentID);
                cmd.Parameters.AddWithValue("ResourceID", cita.ResourceID);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITAS(cs_cita cita)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                //SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[UPDATE_CITAS] @DocEntry,@DocNum,@CANCELED,@DocStatus,@DocDate,@NumAtCard,@PatientCode,@PatientName,@PatientType,@InstitutionCode,@InstitutionName,@DependencyCode,@DependencyName,@DoctorCode,@DoctorName,@VatSum,@DiscPrcnt,@DocCur,@DocTotal,@PaidToDate,@Comments,@MultiCita,@Series,@CreateDate,@UpdateDate,@UserSign,@VersionNum,@Summary,@Start,@End,@RecurrenceRule,@MasterEventID,@Location,@Description,@BackgroundID,@StatusID,@ParentID,@Email,@Visible", conn);
                cmd.Parameters.AddWithValue("DocEntry", cita.DocEntry);
                cmd.Parameters.AddWithValue("DocNum", cita.DocNum);
                cmd.Parameters.AddWithValue("CANCELED", cita.CANCELED);
                cmd.Parameters.AddWithValue("DocStatus", cita.DocStatus);
                cmd.Parameters.AddWithValue("DocDate", cita.DocDate);
                cmd.Parameters.AddWithValue("NumAtCard", cita.NumAtCard);
                cmd.Parameters.AddWithValue("PatientCode", cita.PatientCode);
                cmd.Parameters.AddWithValue("PatientName", cita.PatientName);
                cmd.Parameters.AddWithValue("PatientType", cita.PatientType);
                cmd.Parameters.AddWithValue("InstitutionCode", cita.InstitutionCode);
                cmd.Parameters.AddWithValue("InstitutionName", cita.InstitutionName);
                cmd.Parameters.AddWithValue("DependencyCode", cita.DependencyCode);
                cmd.Parameters.AddWithValue("DependencyName", cita.DependencyName);
                cmd.Parameters.AddWithValue("DoctorCode", cita.DoctorCode);
                cmd.Parameters.AddWithValue("DoctorName", cita.DoctorName);
                cmd.Parameters.AddWithValue("VatSum", cita.VatSum);
                cmd.Parameters.AddWithValue("DiscPrcnt", cita.DiscPrcnt);
                cmd.Parameters.AddWithValue("DocCur", cita.DocCur);
                cmd.Parameters.AddWithValue("DocTotal", cita.DocTotal);
                cmd.Parameters.AddWithValue("PaidToDate", cita.PaidToDate);
                cmd.Parameters.AddWithValue("Comments", cita.Comments);
                cmd.Parameters.AddWithValue("MultiCita", cita.MultiCita);
                cmd.Parameters.AddWithValue("Series", cita.Series);
                cmd.Parameters.AddWithValue("CreateDate", cita.CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", cita.UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", cita.UserSign);
                cmd.Parameters.AddWithValue("VersionNum", cita.VersionNum);
                cmd.Parameters.AddWithValue("Summary", cita.Summary);
                cmd.Parameters.AddWithValue("Start", cita.Start);
                cmd.Parameters.AddWithValue("End", cita.End);
                cmd.Parameters.AddWithValue("RecurrenceRule", cita.RecurrenceRule);
                cmd.Parameters.AddWithValue("MasterEventID", cita.MasterEventID);
                cmd.Parameters.AddWithValue("Location", cita.Location);
                cmd.Parameters.AddWithValue("Description", cita.Description);
                cmd.Parameters.AddWithValue("BackgroundID", cita.BackgroundID);
                cmd.Parameters.AddWithValue("StatusID", cita.StatusID);
                cmd.Parameters.AddWithValue("ParentID", cita.ParentID);
                cmd.Parameters.AddWithValue("Email", cita.Email);
                cmd.Parameters.AddWithValue("Visible", cita.Visible);

                //reader = cmd.ExecuteReader();
                //if (reader.Read() == true)
                //{
                //    _NewDocEntry = int.Parse(reader["DocEntry"].ToString());
                //    resul = true;
                //}

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITA1(cs_cita cita)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[UPDATE_CITA1] @DocEntry,@LineNum,@TargetType,@TrgetEntry,@ItemCode,@Dscription,@Quantity,@Price,@RoomCode,@Currency,@DiscPrcnt,@LineTotal,@PriceBefDi,@DocDate,@Start,@End,@AppointmentID,@ResourceID", conn);
                cmd.Parameters.AddWithValue("DocEntry", cita.DocEntry);
                cmd.Parameters.AddWithValue("LineNum", cita.LineNum);
                cmd.Parameters.AddWithValue("TargetType", cita.TargetType);
                cmd.Parameters.AddWithValue("TrgetEntry", cita.TrgetEntry);
                cmd.Parameters.AddWithValue("ItemCode", cita.ItemCode);
                cmd.Parameters.AddWithValue("Dscription", cita.Dscription);
                cmd.Parameters.AddWithValue("Quantity", cita.Quantity);
                cmd.Parameters.AddWithValue("Price", cita.Price);
                cmd.Parameters.AddWithValue("RoomCode", cita.RoomCode);
                cmd.Parameters.AddWithValue("Currency", cita.Currency);
                cmd.Parameters.AddWithValue("DiscPrcnt", cita.DiscPrcnt1);
                cmd.Parameters.AddWithValue("LineTotal", cita.LineTotal);
                cmd.Parameters.AddWithValue("PriceBefDi", cita.PriceBefDi);
                cmd.Parameters.AddWithValue("DocDate", cita.DocDate);
                cmd.Parameters.AddWithValue("Start", cita.Start);
                cmd.Parameters.AddWithValue("End", cita.End);
                cmd.Parameters.AddWithValue("AppointmentID", cita.AppointmentID);
                cmd.Parameters.AddWithValue("ResourceID", cita.ResourceID);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_CITARECURSOS(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.DocEntry,T0.[RecursoCode],T0.[Recurso]" +
                                "from[cid].[CITARECURSOS] T0 where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool INSERT_CITARECURSOS(int DocEntry, int RecursoCode, string Recurso)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("insert into [cid].[CITARECURSOS] ([DocEntry],[RecursoCode],[Recurso]) VALUES(@DocEntry,@RecursoCode,@Recurso)", conn);

                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("RecursoCode", RecursoCode);
                cmd.Parameters.AddWithValue("Recurso", Recurso);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_CITARECURSOS(int DocEntry, int RecursoCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[CITARECURSOS] where DocEntry=@DocEntry and RecursoCode=@RecursoCode", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("RecursoCode", RecursoCode);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_CITAREQUISITOS(int DocEntry)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select cast(0 as bit) as 'Check',T0.[Requirement] as 'Requisito',T0.[RequirementCode] as 'Code'" +
                                "from[cid].[CITAREQUISITOS] T0 where T0.[DocEntry]=@DocEntry";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool INSERT_CITAREQUISITOS(int DocEntry, int RequirementCode, string Requirement, string Check)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("insert into [cid].[CITAREQUISITOS] ([DocEntry],[RequirementCode],[Requirement],[Check]) VALUES(@DocEntry,@RequirementCode,@Requirement,@Check)", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("RequirementCode", RequirementCode);
                cmd.Parameters.AddWithValue("Requirement", Requirement);
                cmd.Parameters.AddWithValue("Check", Check);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITAREQUISITOS(int Code, int DocEntry, int RequirementCode, string Check)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[CITARECURSOS] set [Check]=@Check where Code=@Code and RequirementCode=@RequirementCode and DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("RequirementCode", RequirementCode);
                cmd.Parameters.AddWithValue("Check", Check);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_CITAREQUISITOS(int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[CITARECURSOS] where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool CANCEL_CITAS(int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[CANCEL_CITAS] @DocEntry", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITAS(DateTime Start, DateTime End, DateTime DocDate, int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[CITAS] set [Start]=@Start,[End]=@End,[DocDate]=@DocDate where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("Start", Start);
                cmd.Parameters.AddWithValue("End", End);
                cmd.Parameters.AddWithValue("DocDate", DocDate);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITAS(int DocEntry, string PatientCode, string PatientName, DateTime Start, DateTime End)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[CITAS] set [PatientCode]=@PatientCode,[PatientName]=@PatientName,[Start]=@Start,[End]=@End,[DocStatus]='N',[Description]='N' where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("PatientCode", PatientCode);
                cmd.Parameters.AddWithValue("PatientName", PatientName);
                cmd.Parameters.AddWithValue("Start", Start);
                cmd.Parameters.AddWithValue("End", End);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_CITA1(DateTime Start, DateTime End, DateTime DocDate, int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[CITA1] set [Start]=@Start,[End]=@End,[DocDate]=@DocDate where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("Start", Start);
                cmd.Parameters.AddWithValue("End", End);
                cmd.Parameters.AddWithValue("DocDate", DocDate);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_CITAS_RESERVADO(int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[CITAS] where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_CITA1_RESERVADO(int DocEntry)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[CITA1] where DocEntry=@DocEntry", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_CITA1_RESERVADO(int DocEntry, string ItemCode = "RESERVADO")
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[CITA1] where DocEntry=@DocEntry and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_HORARIOS(string RoomCode, string Day)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [cid].[SALA1] where RoomCode=@RoomCode and [Day]=@Day";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);
                cmd.Parameters.AddWithValue("Day", Day);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_SALAS_DDL(int Subsidiary)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'RoomCode', '' as 'RoomName' union all select RoomCode,RoomName from [cid].[SALAS]";
                if (Subsidiary != 0)
                    query += " where Subsidiary=@Subsidiary";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                if (Subsidiary != 0)
                    cmd.Parameters.AddWithValue("Subsidiary", Subsidiary);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_SALAS(int Subsidiary)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                //Done:  Order by RoomOrder Asc
                string query = "select * from [cid].[SALAS] where Subsidiary=@Subsidiary Order by RoomOrder Asc";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Subsidiary", Subsidiary);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_SALAS(string RoomCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [cid].[SALAS] where RoomCode=@RoomCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_SALAS(int DocEntry, int Subsidiary)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.[Start],T0.[End],T0.ItemCode,T0.RoomCode,T1.RoomName " +
                    "from [cid].CITA1 T0 inner join [cid].SALAS T1 on T1.RoomCode=T0.ResourceID where T0.DocEntry=@DocEntry and Subsidiary=@Subsidiary";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("DocEntry", DocEntry);
                cmd.Parameters.AddWithValue("Subsidiary", Subsidiary);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_ESTUDIOS_DDL(string RoomCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'ItemCode', '' as 'ItemName' union all select ItemCode,ItemName from " + _DataBaseSAP + ".[dbo].[OITM] where validFor='Y'";
                if (RoomCode != "")
                    query += " and U_SalaDepto=@RoomCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                if (RoomCode != "")
                    cmd.Parameters.AddWithValue("RoomCode", RoomCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_ESTUDIOS(string RoomCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from " + _DataBaseSAP + ".[dbo].[OITM] where U_SalaDepto=@RoomCode and validFor='Y'";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PRECIOS(string ItemCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode = T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "where T1.Price>0 and T0.ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PRECIOS(string ItemCode, string CardCode, bool setter)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode=T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OCRD T3 on T3.ListNum=T2.ListNum " +
                                "where (T1.Price>0 and T0.ItemCode=@ItemCode and T3.CardCode=@CardCode) " +
                                "union " +
                                "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode=T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "where (T1.Price>0 and T0.ItemCode=@ItemCode and T1.PriceList=1)";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PRECIOS(string ItemCode, string RoomCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode = T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "where T1.Price>0 and T0.U_SalaDepto=@RoomCode and T0.ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PRECIOS(string ItemCode, string RoomCode, int PriceList)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode = T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "where T1.Price>0 and T0.U_SalaDepto=@RoomCode and T0.ItemCode=@ItemCode and T1.PriceList=@PriceList";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);
                cmd.Parameters.AddWithValue("PriceList", PriceList);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PRECIOS(string ItemCode, string RoomCode, string CardCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode=T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OCRD T3 on T3.ListNum=T2.ListNum " +
                                "where (T1.Price>0 and T0.U_SalaDepto=@RoomCode and T0.ItemCode=@ItemCode and T3.CardCode=@CardCode) " +
                                "union " +
                                "select CONVERT(varchar, CAST(T1.Price AS money), 1) as 'Price',T2.ListName,T1.PriceList " +
                                "from " + _DataBaseSAP + ".[dbo].OITM T0 " +
                                "    inner join " + _DataBaseSAP + ".[dbo].ITM1 T1 on T1.ItemCode=T0.ItemCode " +
                                "    inner join " + _DataBaseSAP + ".[dbo].OPLN T2 on T2.ListNum=T1.PriceList " +
                                "where (T1.Price>0 and T0.U_SalaDepto=@RoomCode and T0.ItemCode=@ItemCode and T1.PriceList=1)";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("RoomCode", RoomCode);
                cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PACIENTES_SEARCH(string value)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string[] parametros = value.Split(',');

                string query = "select CardCode, CardName,CardType,Age,Sex,Phone1,Phone2,Cellular,E_Mail " +
                                "from[cid].[PACIENTES] " +
                                "where " +
                                " (CardName like '%" + parametros[0] + "%' " +
                                " and CardName like '%" + parametros[1] + "%' " +
                                " and CardName like '%" + parametros[2] + "%') " +
                                " and (Sex like '%" + parametros[3] + "%') " +
                                " and (Phone1 like '%" + parametros[4] + "%') " +
                                " and (Cellular like '%" + parametros[5] + "%') " +
                                " and (E_Mail like '%" + parametros[6] + "%')";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PACIENTES_SEARCH2(string value)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select CardCode, CardName,CardType,Age,Sex,Phone1,Phone2,Cellular,E_Mail " +
                                "from[cid].[PACIENTES] " +
                                "where " +
                                " (CardName like '%" + value + "%' " +
                                " or CardName like '%" + value + "%' " +
                                " or CardName like '%" + value + "%') " +
                                " or (Sex like '%" + value + "%') " +
                                " or (Phone1 like '%" + value + "%') " +
                                " or (Cellular like '%" + value + "%') " +
                                " or (E_Mail like '%" + value + "%')";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PACIENTES()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [cid].[PACIENTES]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PACIENTES(string CardCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [cid].[PACIENTES] where CardCode=@CardCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool EXIST_PACIENTE(string CardCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[PACIENTES] where CardCode=@CardCode", conn);
                cmd.Parameters.AddWithValue("CardCode", CardCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool INSERT_PACIENTES(cs_pacientes pacientes)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("EXEC [dbo].[INSERT_PACIENTES] @CardCode,@CardName,@CardType,@GroupCode,@CmpPrivate,@FirstName,@MiddleName,@FirstSurname,@SecondSurname,@Birthday,@Age,@Sex,@Phone1,@Phone2,@Cellular,@E_Mail,@LicTradNum,@Notes,@CreateDate,@UpdateDate,@UserSign,@validFor,@Series", conn);

                cmd.Parameters.AddWithValue("CardCode", pacientes.CardCode);
                cmd.Parameters.AddWithValue("CardName", pacientes.CardName);
                cmd.Parameters.AddWithValue("CardType", pacientes.CardType);
                cmd.Parameters.AddWithValue("GroupCode", pacientes.GroupCode);
                cmd.Parameters.AddWithValue("CmpPrivate", pacientes.CmpPrivate);
                cmd.Parameters.AddWithValue("FirstName", pacientes.FirstName);
                cmd.Parameters.AddWithValue("MiddleName", pacientes.MiddleName);
                cmd.Parameters.AddWithValue("FirstSurname", pacientes.FirstSurname);
                cmd.Parameters.AddWithValue("SecondSurname", pacientes.SecondSurname);
                cmd.Parameters.AddWithValue("Birthday", pacientes.Birthday);
                cmd.Parameters.AddWithValue("Age", pacientes.Age);
                cmd.Parameters.AddWithValue("Sex", pacientes.Sex);
                cmd.Parameters.AddWithValue("Phone1", pacientes.Phone1);
                cmd.Parameters.AddWithValue("Phone2", pacientes.Phone2);
                cmd.Parameters.AddWithValue("Cellular", pacientes.Cellular);
                cmd.Parameters.AddWithValue("E_Mail", pacientes.E_Mail);
                cmd.Parameters.AddWithValue("LicTradNum", pacientes.LicTradNum);
                cmd.Parameters.AddWithValue("Notes", pacientes.Notes);
                cmd.Parameters.AddWithValue("CreateDate", pacientes.CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", pacientes.UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", pacientes.UserSign);
                cmd.Parameters.AddWithValue("validFor", pacientes.validFor);
                cmd.Parameters.AddWithValue("Series", pacientes.Series);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    //_NewDocEntry = int.Parse(reader["CardCode"].ToString());
                    resul = true;
                }

                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_INSTITUCIONES_DDL()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'CardCode','' as 'CardName' union all select CardCode,CardName from " + _DataBaseSAP + ".[dbo].[OCRD] where CardType='C'";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_INSTITUCIONES()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'CardCode', '' as 'CardName' union all select CardCode,CardName from " + _DataBaseSAP + ".[dbo].[OCRD] where CardType='C'";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_PREPARACION(string ItemCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select ItemCode,Preparacion,Code " +
                                "from [cid].[PREPARACION] where ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool EXIST_PREPARACION(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[PREPARACION] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool INSERT_PREPARACION(string ItemCode, string Preparacion, DateTime CreateDate, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("insert into [cid].[PREPARACION] ([ItemCode],[Preparacion],[CreateDate],[UpdateDate],[validFor],[UserSign]) VALUES(@ItemCode,@Preparacion,@CreateDate,@UpdateDate,@validFor,@UserSign)", conn);

                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Preparacion", Preparacion);
                cmd.Parameters.AddWithValue("CreateDate", CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_PREPARACION(int Code, string ItemCode, string Preparacion, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[PREPARACION] set [Preparacion]=@Preparacion,[UpdateDate]=@UpdateDate,[UserSign]=@UserSign where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Preparacion", Preparacion);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                //cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_PREPARACION(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[PREPARACION] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_COMPLEMENTOS(string ItemCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select ItemCode,Complemento,Code from [cid].[COMPLEMENTOS] where ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool EXIST_COMPLEMENTOS(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[COMPLEMENTOS] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool INSERT_COMPLEMENTOS(string ItemCode, string Complemento, DateTime CreateDate, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("insert into [cid].[COMPLEMENTOS] ([ItemCode],[Complemento],[CreateDate],[UpdateDate],[validFor],[UserSign]) VALUES(@ItemCode,@Complemento,@CreateDate,@UpdateDate,@validFor,@UserSign)", conn);

                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Complemento", Complemento);
                cmd.Parameters.AddWithValue("CreateDate", CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_COMPLEMENTOS(int Code, string ItemCode, string Complemento, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[COMPLEMENTOS] set [Complemento]=@Complemento,[UpdateDate]=@UpdateDate,[UserSign]=@UserSign where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Complemento", Complemento);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                //cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_COMPLEMENTOS(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[COMPLEMENTOS] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_DIAGNOSTICO(string ItemCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select ItemCode,Diagnostico,Code from [cid].[DIAGNOSTICO] where ItemCode=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public bool EXIST_DIAGNOSTICO(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("select * from [cid].[DIAGNOSTICO] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    resul = true;
                }

                reader.Close();
                reader.Dispose();
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                conn.Close();
                conn.Dispose();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool INSERT_DIAGNOSTICO(string ItemCode, string Diagnostico, DateTime CreateDate, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("insert into [cid].[DIAGNOSTICO] ([ItemCode],[Diagnostico],[CreateDate],[UpdateDate],[validFor],[UserSign]) VALUES(@ItemCode,@Diagnostico,@CreateDate,@UpdateDate,@validFor,@UserSign)", conn);

                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Diagnostico", Diagnostico);
                cmd.Parameters.AddWithValue("CreateDate", CreateDate);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool UPDATE_DIAGNOSTICO(int Code, string ItemCode, string Diagnostico, DateTime UpdateDate, string validFor, int UserSign)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("update [cid].[DIAGNOSTICO] set [Diagnostico]=@Diagnostico,[UpdateDate]=@UpdateDate,[UserSign]=@UserSign where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("Diagnostico", Diagnostico);
                cmd.Parameters.AddWithValue("UpdateDate", UpdateDate);
                cmd.Parameters.AddWithValue("UserSign", UserSign);
                //cmd.Parameters.AddWithValue("validFor", validFor);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public bool DELETE_DIAGNOSTICO(int Code, string ItemCode)
        {
            try
            {
                bool resul = false;
                SqlConnection conn;
                SqlCommand cmd;

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand("delete from [cid].[DIAGNOSTICO] where Code=@Code and ItemCode=@ItemCode", conn);
                cmd.Parameters.AddWithValue("Code", Code);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                int r = cmd.ExecuteNonQuery();
                if (r > 0) { resul = true; }
                cmd.Connection.Close();
                conn.Close();

                return resul;
            }
            catch (Exception ex)
            {
                _message_error = "Warning: " + ex.Message;
                return false;
            }
        }

        public DataTable GET_REQUISITOS(string CardCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select T0.CardCode,T0.U_Requisitos,T1.RequirementCode,T1.Requirement,T1.Code " +
                                "from " + _DataBaseSAP + "..[OCRD] T0  " +
                                    "inner join [cid].[REQUISITOS1] T1 on T1.RequirementCode=T0.U_Requisitos  " +
                                "where T0.CardCode=@CardCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_ANESTESIOLOGOS()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select Code,CardName from [cid].[ANESTESIOLOGOS]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_ANESTESIOLOGOS_DDL()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'Code','' as 'CardName' union all select Code,CardName from [cid].[ANESTESIOLOGOS]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("CardCode", CardCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        // ===================================================================================

        public DataTable GET_ItemsOITM(string ItemCode)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select ItemCode,ItemName,U_Sinonimos as 'Sinonimos' from " + _DataBaseSAP + "..[OITM] where [ItemCode]=@ItemCode";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_ItemsOITM(string U_SalaDepto, Int16 value = 0)
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select ItemCode,ItemName,U_Sinonimos as 'Sinonimos' from " + _DataBaseSAP + "..[OITM] where [U_SalaDepto]=@U_SalaDepto";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("U_SalaDepto", U_SalaDepto);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_UnidadNegocio()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select PrcCode,PrcName from " + _DataBaseSAP + "..[OPRC] where DimCode=1 and Locked='N'";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_UnidadNegocioDDL()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select '' as 'PrcCode','' as 'PrcName' union all select PrcCode,PrcName from " + _DataBaseSAP + "..[OPRC] where DimCode=1 and Locked='N'";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("ItemCode", ItemCode);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        // ===================================================================================

        public DataTable GET_Appointments()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [dbo].[Appointments]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_Resources()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [dbo].[Resources]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }

        public DataTable GET_AppointmentsResources()
        {
            try
            {
                SqlConnection conn;
                SqlCommand cmd;
                DataTable dt = new DataTable();
                SqlDataAdapter sda;

                string query = "select * from [dbo].[AppointmentsResources]";

                conn = new SqlConnection(_SQLClientConnection);
                conn.Open();
                cmd = new SqlCommand(query, conn);

                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmd.Connection.Close();
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                _message_error = ex.Message;
                return null;
            }
        }
    }
}