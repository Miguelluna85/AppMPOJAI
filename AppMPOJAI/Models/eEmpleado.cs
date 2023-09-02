using System;
using System.Collections.Generic;
using System.Text;

namespace AppMPOJAI.Models
{
    public class eEmpleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string celular { get; set; }
        public string telFijo { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string estatus { get; set; }
        public int idUsuarioAlta { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioModifico { get; set; }
        public System.DateTime fechaModifico { get; set; }
        public int idPuesto { get; set; }
        public int idArea { get; set; }
        public int idDepartamento { get; set; }


    }
}
