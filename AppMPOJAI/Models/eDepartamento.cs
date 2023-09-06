
namespace AppMPOJAI.Models
{
    public class eDepartamento
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estatus { get; set; }
        public int idUsuarioAlta { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioModifico { get; set; }
        public System.DateTime? fechaModifico { get; set; }
        public int idArea { get; set; }
    }
}
