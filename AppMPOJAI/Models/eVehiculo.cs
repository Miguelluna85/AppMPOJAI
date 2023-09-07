using System;
using System.Collections.Generic;
using System.Text;

namespace AppMPOJAI.Models
{
    public class eVehiculo
    {
        public int id { get; set; }
        public string eco { get; set; }
        public string descripcion { get; set; }
        public string placas { get; set; }
        public string modelo { get; set; }
        public string anyo { get; set; }
        public string color { get; set; }
        public string NSChasis { get; set; }
        public string NSMotor { get; set; }
        public decimal precioFactura { get; set; }
        public decimal precioCompra { get; set; }
        public string uso { get; set; }
        public string comentarios { get; set; }
        public bool estatus { get; set; }
        public string idTipoPlacas { get; set; }
        public int idConductorVehiculo { get; set; }
        public int idArea{ get; set; }
         public int idSucursal { get; set; }       
        public int idExpediente { get; set; }

        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idUsuarioModifico { get; set; }
        public DateTime fechaModifico { get; set; }

        public bool arrendado { get; set; }

        public string eco_descripcion 
        {
            get; set;
        }
    }
}
