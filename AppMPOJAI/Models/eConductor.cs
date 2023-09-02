namespace AppMPOJAI.Models
{
    public class eConductor
    {
        public int id { get; set; }
        public int idEmpleado { get; set; }
        public int idLicencia { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public string comentarios { get; set; }
        public bool estatus { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioAlta { get; set; }
        public System.DateTime fechaModifico { get; set; }
        public int idUsuarioModifico { get; set; }
    }
}
