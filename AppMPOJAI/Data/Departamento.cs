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
        public async Task<List<eDepartamento>> getDepartamentosAsync()
        {
            List<eDepartamento> list = new List<eDepartamento>();
            DataTable dtVehiculos = await BDD.getInstancia().executeDataTableAsync("usp_getDepartamentos");
            foreach (DataRow item in dtVehiculos.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }

        public async Task<List<eDepartamento>> getDepartamentosActivosXAreaAsync(int idArea)
        {
            List<eDepartamento> list = new List<eDepartamento>();
            list = await getDepartamentosAsync();
            return list.Where(P => P.idArea == idArea).ToList();
        }

        public eDepartamento dataRowAObj(DataRow item)
        {
            try
            {


                eDepartamento vehiculo = new eDepartamento()
                {
                    id = Convert.ToInt32(item["id"].ToString()),
                    nombre = item["eco"].ToString(),
                    descripcion = item["descripcion"].ToString(),
                    estatus = System.Convert.ToBoolean(item["estatus"].ToString()),
                    idUsuarioAlta = System.Convert.ToInt32(item["idUsuarioAlta"].ToString()),
                    fechaAlta = System.Convert.ToDateTime(item["fechaAlta"].ToString()),
                    idUsuarioModifico = System.Convert.ToInt32(item["idUsuarioModifico"].ToString()),
                    fechaModifico = System.Convert.ToDateTime(item["fechaModifico"].ToString()),
                    idArea = System.Convert.ToInt32(item["idArea"].ToString())
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
