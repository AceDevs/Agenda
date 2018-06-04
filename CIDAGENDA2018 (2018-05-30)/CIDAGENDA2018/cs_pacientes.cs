using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDAGENDA2018
{
    public class cs_pacientes
    {
        string _CardCode = "";
        string _CardName = "";
        string _CardType = "";
        int _GroupCode = 0;
        string _CmpPrivate = "";
        string _FirstName = "";
        string _MiddleName = "";
        string _FirstSurname = "";
        string _SecondSurname = "";
        DateTime _Birthday = DateTime.Now.Date;
        int _Age = 0;
        string _Sex = "";
        string _Phone1 = "";
        string _Phone2 = "";
        string _Cellular = "";
        string _E_Mail = "";
        string _LicTradNum = "";
        string _Notes = "";
        DateTime _CreateDate = DateTime.Now.Date;
        DateTime _UpdateDate = DateTime.Now.Date;
        int _UserSign = 0;
        string _validFor = "";
        int _Series = 0;

        
        public string CardCode
        {
            get { return _CardCode; }
            set { _CardCode = value; }
        }
        public string CardName
        {
            get { return _CardName; }
            set { _CardName = value; }
        }
        public string CardType
        {
            get { return _CardType; }
            set { _CardType = value; }
        }
        public int GroupCode
        {
            get { return _GroupCode; }
            set { _GroupCode = value; }
        }
        public string CmpPrivate
        {
            get { return _CmpPrivate; }
            set { _CmpPrivate = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }
        public string FirstSurname
        {
            get { return _FirstSurname; }
            set { _FirstSurname = value; }
        }
        public string SecondSurname
        {
            get { return _SecondSurname; }
            set { _SecondSurname = value; }
        }
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public string Phone1
        {
            get { return _Phone1; }
            set { _Phone1 = value; }
        }
        public string Phone2
        {
            get { return _Phone2; }
            set { _Phone2 = value; }
        }
        public string Cellular
        {
            get { return _Cellular; }
            set { _Cellular = value; }
        }
        public string E_Mail
        {
            get { return _E_Mail; }
            set { _E_Mail = value; }
        }
        public string LicTradNum
        {
            get { return _LicTradNum; }
            set { _LicTradNum = value; }
        }
        public string Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
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
        public string validFor
        {
            get { return _validFor; }
            set { _validFor = value; }
        }
        public int Series
        {
            get { return _Series; }
            set { _Series = value; }
        }

    }
}
