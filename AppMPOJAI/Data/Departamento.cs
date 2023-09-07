using AppMPOJAI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMPOJAI.Data
{
    public class Departamento
    {
        public List<eDepartamento> getDepartamentos()
        {
            List<eDepartamento> list = new List<eDepartamento>();
            DataTable dtVehiculos = BDD.getInstancia().executeDataTable("usp_getDepartamentos");
            foreach (DataRow item in dtVehiculos.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }

        public List<eDepartamento> getDepartamentosActivosXArea(int idArea)
        {
            List<eDepartamento> list = new List<eDepartamento>();
            list = getDepartamentos();
            return list.Where(P => P.idArea == idArea).ToList();
        }

        public eDepartamento dataRowAObj(DataRow item)
        {
            try
            {
                eDepartamento vehiculo = new eDepartamento()
                {
                    id = Convert.ToInt32(item["id"].ToString()),
                    nombre = item["nombre"].ToString(),
                    descripcion = item["descripcion"].ToString(),
                    estatus = System.Convert.ToBoolean(item["estatus"].ToString()),
                    idUsuarioAlta = System.Convert.ToInt32(item["idUsuarioAlta"].ToString()),
                    fechaAlta = System.Convert.ToDateTime(item["fechaAlta"].ToString()),
                    idUsuarioModifico = System.Convert.ToInt32(item["idUsuarioModifico"].ToString()),
                    //fechaModifico = System.Convert.ToDateTime(item["fechaModifico"].ToString()),
                    idArea = System.Convert.ToInt32(item["idArea"].ToString()),
                    
                };
                return vehiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
