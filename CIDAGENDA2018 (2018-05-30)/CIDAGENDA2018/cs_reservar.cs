using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDAGENDA2018
{
    public static class cs_reservar
    {
        #region VARIABLES

        //static DateTime _Start;
        //static DateTime _End;
        static DateTime _Start = DateTime.Today;
        static DateTime _End = DateTime.Today.AddDays(1);

        static string _estado = "";
        static string _ResourceId = "";
        
        static int _UnidadNegocio = 0; // variable nueva para determinar las unidades de negocio (sucursales)

        static int _NewDocEntry = 0;
        #endregion

        #region PARAMETROS
        public static DateTime Start
        {
            get { return _Start; }
            set { _Start = value; }
        }
        public static DateTime End
        {
            get { return _End; }
            set { _End = value; }
        }
        public static string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public static string ResourceId
        {
            get { return _ResourceId; }
            set { _ResourceId = value; }
        }
        public static int UnidadNegocio
        {
            get { return _UnidadNegocio; }
            set { _UnidadNegocio = value; }
        }
        public static int NewDocEntry
        {
            get { return _NewDocEntry; }
            set { _NewDocEntry = value; }
        }
        #endregion

    }
}
