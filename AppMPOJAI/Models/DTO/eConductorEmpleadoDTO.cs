using System;
using System.Collections.Generic;
using System.Text;

namespace AppMPOJAI.Models.DTO
{
    public class eConductorEmpleadoDTO
    {

        public eConductorEmpleadoDTO()
        {
            eEmpleado = new eEmpleado();
            eConductor = new eConductor();
        }

        public eEmpleado eEmpleado { get; set; }
        public eConductor eConductor { get; set; }
        public string NombreCompleto { get; set; }
    }
}
