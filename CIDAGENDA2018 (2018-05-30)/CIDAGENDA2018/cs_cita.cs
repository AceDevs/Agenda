using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CIDAGENDA2018
{
    public class cs_cita
    {
        #region VARIABLES

        // ========== CITAS
        int _DocNum = 0;
        string _CANCELED = "N";
        string _DocStatus = "";
        DateTime _DocDate = DateTime.Now.Date;
        string _NumAtCard = "";
        string _PatientCode = "";
        string _PatientName = "";
        string _PatientType = "";
        string _InstitutionCode = "";
        string _InstitutionName = "";
        string _DependencyCode = "";
        string _DependencyName = "";
        string _DoctorCode = "";
        string _DoctorName = "";
        double _VatSum = 0;
        double _DiscPrcnt = 0;
        string _DocCur = "";
        double _DocTotal = 0;
        double _PaidToDate;
        string _Comments = "";
        string _MultiCita = "";
        int _Series = 0;
        DateTime _CreateDate = DateTime.Now.Date;
        DateTime _UpdateDate = DateTime.Now.Date;
        int _UserSign = 0;
        string _VersionNum = "";
        string _Summary = "";
        DateTime _Start;
        DateTime _End;
        string _RecurrenceRule = "";
        int _MasterEventID = 0;
        string _Location = "";
        string _Description = "";
        int _BackgroundID = 1;
        int _StatusID = 4;
        int _ParentID = 0;
        string _Email = "";
        int _Visible = 1;

        // ========== CITA1
        int _DocEntry = 0;
        int _LineNum = 0;
        int _TargetType = 0;
        int _TrgetEntry = 0;
        string _ItemCode = "";
        string _Dscription = "";
        double _Quantity = 0;
        double _Price = 0;
        string _RoomCode = "";
        string _Currency = "";
        double _DiscPrcnt1 = 0;
        double _LineTotal = 0;
        double _PriceBefDi = 0;
        //string _DocDate = "";
        //string _Start = "";
        //string _End = "";
        int _AppointmentID = 0;
        string _ResourceID = "";

        #endregion


        #region PARAMETROS

        public int DocNum
        {
            get { return _DocNum; }
            set { _DocNum = value; }
        }
        public string CANCELED
        {
            get { return _CANCELED; }
            set { _CANCELED = value; }
        }
        public string DocStatus
        {
            get { return _DocStatus; }
            set { _DocStatus = value; }
        }
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { _DocDate = value; }
        }
        public string NumAtCard
        {
            get { return _NumAtCard; }
            set { _NumAtCard = value; }
        }
        public string PatientCode
        {
            get { return _PatientCode; }
            set { _PatientCode = value; }
        }
        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        public string PatientType
        {
            get { return _PatientType; }
            set { _PatientType = value; }
        }
        public string InstitutionCode
        {
            get { return _InstitutionCode; }
            set { _InstitutionCode = value; }
        }
        public string InstitutionName
        {
            get { return _InstitutionName; }
            set { _InstitutionName = value; }
        }
        public string DependencyCode
        {
            get { return _DependencyCode; }
            set { _DependencyCode = value; }
        }
        public string DependencyName
        {
            get { return _DependencyName; }
            set { _DependencyName = value; }
        }
        public string DoctorCode
        {
            get { return _DoctorCode; }
            set { _DoctorCode = value; }
        }
        public string DoctorName
        {
            get { return _DoctorName; }
            set { _DoctorName = value; }
        }
        public double VatSum
        {
            get { return _VatSum; }
            set { _VatSum = value; }
        }
        public double DiscPrcnt
        {
            get { return _DiscPrcnt; }
            set { _DiscPrcnt = value; }
        }
        public string DocCur
        {
            get { return _DocCur; }
            set { _DocCur = value; }
        }
        public double DocTotal
        {
            get { return _DocTotal; }
            set { _DocTotal = value; }
        }
        public double PaidToDate
        {
            get { return _PaidToDate; }
            set { _PaidToDate = value; }
        }
        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }
        public string MultiCita
        {
            get { return _MultiCita; }
            set { _MultiCita = value; }
        }
        public int Series
        {
            get { return _Series; }
            set { _Series = value; }
        }
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }
        public DateTime UpdateDate
        {
            get { return _UpdateDate; }
            set { _UpdateDate = value; }
        }
        public int UserSign
        {
            get { return _UserSign; }
            set { _UserSign = value; }
        }
        public string VersionNum
        {
            get { return _VersionNum; }
            set { _VersionNum = value; }
        }
        public string Summary
        {
            get { return _Summary; }
            set { _Summary = value; }
        }
        public DateTime Start
        {
            get { return _Start; }
            set { _Start = value; }
        }
        public DateTime End
        {
            get { return _End; }
            set { _End = value; }
        }
        public string RecurrenceRule
        {
            get { return _RecurrenceRule; }
            set { _RecurrenceRule = value; }
        }
        public int MasterEventID
        {
            get { return _MasterEventID; }
            set { _MasterEventID = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int BackgroundID
        {
            get { return _BackgroundID; }
            set { _BackgroundID = value; }
        }
        public int StatusID
        {
            get { return _StatusID; }
            set { _StatusID = value; }
        }
        public int ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public int Visible
        {
            get { return _Visible; }
            set { _Visible = value; }
        }


        public int DocEntry
        {
            get { return _DocEntry; }
            set { _DocEntry = value; }
        }
        public int LineNum
        {
            get { return _LineNum; }
            set { _LineNum = value; }
        }
        public int TargetType
        {
            get { return _TargetType; }
            set { _TargetType = value; }
        }
        public int TrgetEntry
        {
            get { return _TrgetEntry; }
            set { _TrgetEntry = value; }
        }
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        public string Dscription
        {
            get { return _Dscription; }
            set { _Dscription = value; }
        }
        public double Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string RoomCode
        {
            get { return _RoomCode; }
            set { _RoomCode = value; }
        }
        public string Currency
        {
            get { return _Currency; }
            set { _Currency = value; }
        }
        public double DiscPrcnt1
        {
            get { return _DiscPrcnt1; }
            set { _DiscPrcnt1 = value; }
        }
        public double LineTotal
        {
            get { return _LineTotal; }
            set { _LineTotal = value; }
        }
        public double PriceBefDi
        {
            get { return _PriceBefDi; }
            set { _PriceBefDi = value; }
        }
        //string _DocDate = "";
        //string _Start = "";
        //string _End = "";
        public int AppointmentID
        {
            get { return _AppointmentID; }
            set { _AppointmentID = value; }
        }
        public string ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        #endregion


        public cs_cita()
        {

        }

    }
}
