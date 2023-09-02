using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.Models;
using AppMPOJAI.Models.DTO;

namespace AppMPOJAI.Data
{
    public class Conductor
    {
        public async Task<List<eConductorEmpleadoDTO>> getConductoresAsync(string filtro = "")
        {
            List<eConductorEmpleadoDTO> list = new List<eConductorEmpleadoDTO>();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("filtro",System.Data.SqlDbType.VarChar){ Value=filtro}
            };

            DataTable dtConductores = await BDD.getInstancia().executeDataTableAsync(parameters, "usp_getConductoresFiltro");
            foreach (DataRow item in dtConductores.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }
        public List<eConductorEmpleadoDTO> getConductores(string filtro = "")
        {
            List<eConductorEmpleadoDTO> list = new List<eConductorEmpleadoDTO>();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("filtro",System.Data.SqlDbType.VarChar){ Value=filtro}
            };

            DataTable dtConductores = BDD.getInstancia().executeDataTable(parameters, "usp_getConductoresFiltro");
            foreach (DataRow item in dtConductores.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }
        public eConductorEmpleadoDTO dataRowAObj(DataRow item)
        {
            try
            {
                eConductorEmpleadoDTO conductor = new eConductorEmpleadoDTO();

                conductor.eConductor.id = Convert.ToInt32(item["idConductor"].ToString());
                conductor.eConductor.idEmpleado = Convert.ToInt32(item["idEmpleado"].ToString());
                conductor.eConductor.idLicencia = Convert.ToInt32(item["idLicencia"].ToString());
                // conductor.eConductor.fechaIngreso = Convert.ToDateTime(item["fechaIngreso"].ToString());

                //conductor.eEmpleado.nombre = item["nombre"].ToString();
                //conductor.eEmpleado.nombre = item["segundoNombre"].ToString();
                //conductor.eEmpleado.nombre = item["paterno"].ToString();
                //conductor.eEmpleado.nombre = item["materno"].ToString();
                conductor.NombreCompleto = item["nombre"].ToString() +" "+ item["segundoNombre"].ToString()+" " + item["paterno"].ToString()+" "+ item["materno"].ToString();
                conductor.eEmpleado.celular = item["celular"].ToString();
                conductor.eEmpleado.telFijo = item["telFijo"].ToString();
                // conductor.eEmpleado.fechaIngreso = Convert.ToDateTime(item["fechaIngreso"].ToString());
                conductor.eEmpleado.direccion = item["direccion"].ToString();
                conductor.eEmpleado.correo = item["correo"].ToString();
                conductor.eConductor.estatus = System.Convert.ToBoolean(item["estatus"].ToString());
                return conductor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
