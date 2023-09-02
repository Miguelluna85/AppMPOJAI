using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.Models;

namespace AppMPOJAI.Data
{
    public class Vehiculo
    {
        public async Task<List<eVehiculo>> getVehiculosAsync(string filtro = "")
        {
            List<eVehiculo> list = new List<eVehiculo>();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("filtro",System.Data.SqlDbType.VarChar){ Value=filtro}
            };

            DataTable dtVehiculos = await BDD.getInstancia().executeDataTableAsync(parameters, "usp_getVehiculosFiltro");
            foreach (DataRow item in dtVehiculos.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }
        public List<eVehiculo> getVehiculos(string filtro = "")
        {
            List<eVehiculo> list = new List<eVehiculo>();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("filtro",System.Data.SqlDbType.VarChar){ Value=filtro}
            };

            DataTable dtVehiculos =  BDD.getInstancia().executeDataTable(parameters, "usp_getVehiculosFiltro");
            foreach (DataRow item in dtVehiculos.Rows)
            {
                list.Add(dataRowAObj(item));
            }
            return list;
        }
        public eVehiculo dataRowAObj(DataRow item)
        {
            try
            {


                eVehiculo vehiculo = new eVehiculo()
                {
                    id = Convert.ToInt32(item["id"].ToString()),
                    eco = item["eco"].ToString(),
                    descripcion = item["descripcion"].ToString(),
                    modelo = item["modelo"].ToString(),
                    placas = item["placas"].ToString(),
                    anyo = item["anyo"].ToString(),
                    color = item["color"].ToString(),
                    NSChasis = item["NSChasis"].ToString(),
                    NSMotor = item["NSMotor"].ToString(),
                    idTipoPlacas = item["idtipoPlaca"].ToString(),
                    //rutaFotos = item["rutaFotos"].ToString(),
                    comentarios = item["comentarios"].ToString(),
                    estatus = System.Convert.ToBoolean(item["estatus"].ToString()),
                    /*idUsuarioAlta = System.Convert.ToInt32(item["idUsuarioAlta"].ToString()),
                   fechaAlta = System.Convert.ToDateTime(item["fechaAlta"].ToString()),
                   idUsuarioModifico = System.Convert.ToInt32(item["idUsuarioModifico"].ToString()),
                   fechaModifico = System.Convert.ToDateTime(item["fechaModifico"].ToString()),
                   idArea = System.Convert.ToInt32(item["idArea"].ToString()),
                   idDepartamento = System.Convert.ToInt32(item["idDepartamento"].ToString()),
                   idSucursal = System.Convert.ToInt32(item["idSucursal"].ToString()),
                   idConductor = System.Convert.ToInt32(item["idConductor"].ToString()),
                   idExpediente = System.Convert.ToInt32(item["idExpediente"].ToString())
                   */
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
