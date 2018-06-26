using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDAGENDA2018
{
    /// <summary>
    /// Clase para popular el cotizador sin generar tablas.
    /// </summary>
    internal class QuotingItem
    {
        public string CodigoProducto { get; set; }
        public string Producto { get; set; }
        public string Sala { get; set; }
        public double VentaMostrador { get; set; }
        public double SectorSalud { get; set; }
        public double Aseguradora { get; set; }
        //public double Precio { get; set; }
    }
}