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
        public string modelo { get; set; }
        public string placas { get; set; }
        public string anyo { get; set; }
        public string color { get; set; }
        public string NSChasis { get; set; }
        public string NSMotor { get; set; }
        public string tipoPlacas { get; set; }
        public string rutaFotos { get; set; }
        public string comentarios { get; set; }
        public bool estatus { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idUsuarioModifico { get; set; }
        public DateTime fechaModifico { get; set; }

        public int idArea{ get; set; }
        public int idDepartamento { get; set; }
        public int idSucursal { get; set; }
        public int idConductor { get; set; }
        public int idExpediente { get; set; }


    }
}
