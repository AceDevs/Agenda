using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDAGENDA2018
{
    public static class cs_funciones
    {
        private static String uno, dos, tres, cuatro;
        private static String[] primerNombre, PreAP, PreAM;
        private static char[] ap, am;

        public static string CompanyName = "Unidad Radiologica IRM, S. de R.L. de C.V.";

        public static string var_buscar = "";
        public static string var_CardCode = "";

        public static string var_RoomCode = "";
        public static string var_RoomHora = "";

        public static string session_id = "";
        public static string session_name = "";
        public static string session_type = "";

        public static string session_location
        {
            get
            {
                if (_session_location != "")
                    return _session_location;
                return "10";
            }
            set
            {
                _session_location = value;
            }
        }

        internal static string _session_location = "10";

        public static String GET_PatientCode(String nombre, String apellidoP, String apellidoM)
        {
            int i, validacionA = 0, validacionB = 0, bandera = 0;
            String RFC = "";
            nombre = nombre.ToUpper();
            apellidoP = apellidoP.ToUpper();
            apellidoM = apellidoM.ToUpper();
            //a: guarda el nombre, b: guarda el apellido paterno, c: guarda el apellido materno-----------------------------------
            char[] a = nombre.ToCharArray();
            char[] b = apellidoP.ToCharArray();
            char[] c = apellidoM.ToCharArray();
            //Validar si faltan apellidos-----------------------------------------------------------------------------------------
            if (apellidoP == "")
                validacionA = 1; //Validacion de apellido paterno que no sea "null"
            if (apellidoM == "")
                validacionB = 1;//Validacion de apellido materno que no sea "null"
            //Letra inicial del  apellido paterno---------------------------------------------------------------------------------
            if (validacionA == 0)
            {
                try //Validacion con try catch por si tiene dos apellidos
                {
                    PreAP = apellidoP.Split(' ');
                    ap = PreAP[1].ToArray();
                    if (PreAP[0] == "MARIA" || PreAP[0] == "MA." || PreAP[0] == "MA" || PreAP[0] == "JOSE" ||
                            PreAP[0] == "J." || PreAP[0] == "J" || PreAP[0] == "DA" || PreAP[0] == "DAS" ||
                            PreAP[0] == "DE" || PreAP[0] == "DEL" || PreAP[0] == "DER" || PreAP[0] == "DI" ||
                            PreAP[0] == "DIE" || PreAP[0] == "DD" || PreAP[0] == "EL" || PreAP[0] == "LA" ||
                            PreAP[0] == "LOS" || PreAP[0] == "LAS" || PreAP[0] == "LE" || PreAP[0] == "LES" ||
                            PreAP[0] == "MAC" || PreAP[0] == "MC" || PreAP[0] == "VAN" || PreAP[0] == "VON")
                    {
                        uno = Convert.ToString(ap[0]); //Se toma el segundo apellido paterno
                        if (uno == "Ñ" || uno == "-" || uno == "/" || uno == ".")
                        {
                            uno = "X";
                        }
                    }
                }
                catch (Exception ex)
                {
                    uno = Convert.ToString(b[0]); //Si llega a la excepcion quiere decir que no tiene apellidos compuestos.
                    if (uno == "Ñ" || uno == "-" || uno == "/" || uno == ".")
                    {
                        uno = "X";
                    }
                }
            }
            //Primera vocal del apellido Paterno O Materno (en caso de que falte el apellido materno)----------------------------------------------------------------------------------
            if ((validacionB == 1) || (validacionA == 0 && validacionB == 0))
            {
                try //Validacion con try catch por si tiene dos apellidos(paterno)
                {
                    for (i = 1; i < PreAP[1].Length; i++) //Se valida el segundo apellido paterno en caso de tener apellidos compuestos.
                    {
                        if (ap[i] == 'A' || ap[i] == 'E' || ap[i] == 'I' || ap[i] == 'O' || ap[i] == 'U')
                        {
                            bandera = 1;
                            dos = Convert.ToString(ap[i]);
                            break;
                        }
                    }
                    if (bandera == 0)
                        dos = "X";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ERROR" + ex);
                    for (i = 1; i < apellidoP.Length; i++) //Si llega a la excepcion quiere decir que no tiene apellido paterno compuesto.
                    {
                        if (b[i] == 'A' || b[i] == 'E' || b[i] == 'I' || b[i] == 'O' || b[i] == 'U')
                        {
                            bandera = 1;
                            dos = Convert.ToString(b[i]);
                            break;
                        }
                    }
                    if (bandera == 0)
                        dos = "X";
                }
            }
            if (validacionA == 1)
            {
                try //Validacion con try catch por si tiene dos apellidos (materno)
                {
                    for (i = 1; i < PreAM[1].Length; i++)//Se valida el segundo apellido materno en caso de tener apellidos compuestos.
                    {
                        if (am[i] == 'A' || am[i] == 'E' || am[i] == 'I' || am[i] == 'O' || am[i] == 'U')
                        {
                            bandera = 1;
                            dos = Convert.ToString(am[i]);
                            break;
                        }
                    }
                    if (bandera == 0)
                        dos = "X";
                }
                catch (Exception ex)
                {
                    for (i = 1; i < apellidoM.Length; i++)//Si llega a la excepcion quiere decir que no tiene apellido materno compuesto.
                    {
                        if (c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                        {
                            bandera = 1;
                            dos = Convert.ToString(c[i]);
                            break;
                        }
                    }
                    if (bandera == 0)
                        dos = "X";
                }
            }
            if (dos == "-" || dos == "/" || dos == ".")
            {
                dos = "X";
            }
            //Letra inicial del apellido materno----------------------------------------------------------------------------------
            if (validacionB == 0)
            {
                try //Validacion con try catch por si tiene dos nombres
                {
                    PreAM = apellidoM.Split(' ');
                    char[] am = PreAM[1].ToArray();
                    if (PreAM[0] == "MARIA" || PreAM[0] == "MA." || PreAM[0] == "MA" || PreAM[0] == "JOSE" ||
                            PreAM[0] == "J." || PreAM[0] == "J" || PreAM[0] == "DA" || PreAM[0] == "DAS" ||
                            PreAM[0] == "DE" || PreAM[0] == "DEL" || PreAM[0] == "DER" || PreAM[0] == "DI" ||
                            PreAM[0] == "DIE" || PreAM[0] == "DD" || PreAM[0] == "EL" || PreAM[0] == "LA" ||
                            PreAM[0] == "LOS" || PreAM[0] == "LAS" || PreAM[0] == "LE" || PreAM[0] == "LES" ||
                            PreAM[0] == "MAC" || PreAM[0] == "MC" || PreAM[0] == "VAN" || PreAM[0] == "VON")
                    {
                        tres = Convert.ToString(am[0]);
                        if (tres == "Ñ" || tres == "-" || tres == "/" || tres == ".")
                        {
                            tres = "X";
                        }
                    }
                }
                catch (Exception ex)//Si marca una excepcion quiere decir que solo tiene un nombre
                {
                    tres = Convert.ToString(c[0]);
                    if (tres == "Ñ" || uno == "-" || uno == "/" || uno == ".")
                    {
                        tres = "X";
                    }
                }
            }
            if (tres == "-" || tres == "/" || tres == ".")
            {
                tres = "X";
            }
            //Letra inicial del nombre (validar lo restante del if apartir de "J")--------------------------------------------------------------------------------------------
            try //Validacion con try catch por si tiene dos nombres
            {
                primerNombre = nombre.Split(' ');
                char[] a2 = primerNombre[1].ToArray(); //Validacion para palabras "groseras".
                if (primerNombre[0] == "MARIA" || primerNombre[0] == "MA." || primerNombre[0] == "MA" || primerNombre[0] == "JOSE" ||
                    primerNombre[0] == "J." || primerNombre[0] == "J" || primerNombre[0] == "DA" || primerNombre[0] == "DAS" ||
                    primerNombre[0] == "DE" || primerNombre[0] == "DEL" || primerNombre[0] == "DER" || primerNombre[0] == "DI" ||
                    primerNombre[0] == "DIE" || primerNombre[0] == "DD" || primerNombre[0] == "EL" || primerNombre[0] == "LA" ||
                    primerNombre[0] == "LOS" || primerNombre[0] == "LAS" || primerNombre[0] == "LE" || primerNombre[0] == "LES" ||
                    primerNombre[0] == "MAC" || primerNombre[0] == "MC" || primerNombre[0] == "VAN" || primerNombre[0] == "VON")
                {
                    cuatro = Convert.ToString(a2[0]);
                    if (cuatro == "Ñ" || cuatro == "-" || cuatro == "/" || cuatro == ".")
                    {
                        cuatro = "X";
                    }
                }
                else
                    cuatro = Convert.ToString(a2[0]);
            }
            catch (Exception ex)
            {
                cuatro = Convert.ToString(a[0]);
                if (cuatro == "Ñ" || cuatro == "-" || cuatro == "/" || cuatro == ".")
                {
                    cuatro = "X";
                }
            }
            //Concatenar Letras/Numeros para formar RFC--------------------------------------------------------------------------
            if (validacionA == 1) //Validacion en caso de que no tenga apellido paterno.
                RFC = tres + dos + "X" + cuatro;
            else
            //RFC = uno + this.dos + tres + cuatro;
            if (validacionB == 1) //Validacion en caso de que no tenga apellido materno.
                RFC = uno + dos + "X" + cuatro;
            else
                RFC = uno + dos + tres + cuatro;
            if (RFC == "BACA" || RFC == "LOCO" || RFC == "BAKA" || RFC == "LOKA" || RFC == "BUEI" ||
                RFC == "LOKO" || RFC == "BUEY" || RFC == "MAME" || RFC == "CACA" || RFC == "MAMO" ||
                RFC == "CACO" || RFC == "MEAR" || RFC == "CAGA" || RFC == "MEAS" || RFC == "CAGO" ||
                RFC == "MEON" || RFC == "CAKA" || RFC == "MIAR" || RFC == "CAKO" || RFC == "MION" ||
                RFC == "COGE" || RFC == "MOCO" || RFC == "COGI" || RFC == "MOKO" || RFC == "COJA" ||
                RFC == "MULA" || RFC == "COJE" || RFC == "MULO" || RFC == "COJI" || RFC == "NACA" ||
                RFC == "COJO" || RFC == "NACO" || RFC == "COLA" || RFC == "PEDA" || RFC == "CULO" ||
                RFC == "PEDO" || RFC == "FALO" || RFC == "PENE" || RFC == "FETO" || RFC == "PIPI" ||
                RFC == "GETA" || RFC == "PITO" || RFC == "GUEI" || RFC == "POPO" || RFC == "GUEY" ||
                RFC == "PUTA" || RFC == "JETA" || RFC == "PUTO" || RFC == "JOTO" || RFC == "QULO" ||
                RFC == "KACA" || RFC == "RATA" || RFC == "KACO" || RFC == "ROBA" || RFC == "KAGA" ||
                RFC == "ROBE" || RFC == "KAGO" || RFC == "ROBO" || RFC == "KAKA" || RFC == "RUIN" ||
                RFC == "KAKO" || RFC == "SENO" || RFC == "KOGE" || RFC == "TETA" || RFC == "KOGI" ||
                RFC == "VACA" || RFC == "KOJA" || RFC == "VAGA" || RFC == "KOJE" || RFC == "VAGO" ||
                RFC == "KOJI" || RFC == "VAKA" || RFC == "KOJO" || RFC == "VUEI" || RFC == "KOLA" ||
                RFC == "VUEY" || RFC == "KULO" || RFC == "WUEI" || RFC == "LILO" || RFC == "WUEY" ||
                RFC == "LOCA" || RFC == "PVTA" || RFC == "PVTO")
            {
                RFC = uno + "X" + tres + cuatro;
            }

            return RFC;
        }
    }
}