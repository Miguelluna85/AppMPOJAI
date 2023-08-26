using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AppMPOJAI.Data
{
    public class BDD
    {
        private static BDD instancia = null;
        private SqlConnection conn;
        private SqlCommand cmd;
        private System.Data.DataTable dt;

        private BDD()
        {
            conn = new SqlConnection("Server=SQL5104.site4now.net;Database=db_a9ba88_mpcloud;Uid=db_a9ba88_mpcloud_admin;Pwd=ojai.042017");
            cmd = new SqlCommand("", conn);
            dt = new System.Data.DataTable();
        }
        public static BDD getInstancia()
        {
            
            if (instancia == null)
            {
                instancia = new BDD();
            }
            return instancia;
        }

        public async Task<System.Data.DataTable> executeDataTableAsync(string sp)
        {
            try
            {
                dt = new System.Data.DataTable();
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dt.Clear();
                dt.Load(await cmd.ExecuteReaderAsync());
                conn.Close();
            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt.Copy();
        }
        public System.Data.DataTable executeDataTable(string sp)
        {
            try
            {
                dt = new System.Data.DataTable();
                conn.Open();
                cmd.CommandText = sp;
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dt.Clear();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt.Copy();
        }
        public async Task<System.Data.DataTable> executeDataTableAsync(List<SqlParameter> lstParametros, string sp)
        {
            try
            {
                dt = new System.Data.DataTable();
                cmd.Parameters.Clear();

                await conn.OpenAsync();

                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(lstParametros.ToArray());
                dt.Clear();
                dt.Load(await cmd.ExecuteReaderAsync());
                conn.Close();
            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt.Copy();
        }
        public async Task<int> executeNonQueryAsync(string sp)
        {
            int resultado = 0;
            try
            {
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                resultado = await cmd.ExecuteNonQueryAsync();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }
        public async Task<int> executeNonQueryAsync(List<SqlParameter> lstParametros, string sp)
        {
            int resultado = 0;
            try
            {
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(lstParametros.ToArray());
                resultado = await cmd.ExecuteNonQueryAsync();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }

        public async Task<int> deleteAsync(int id, string sp)
        {
            int resultado = 0;
            try
            {
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                resultado = await cmd.ExecuteNonQueryAsync();
                cmd.Parameters.AddWithValue("@id", id);
                conn.Close();

            }
            catch (System.Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }
        public async Task<object> executeScalarAsync(string sp)
        {
            object obj = new object();
            try
            {
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                obj = await cmd.ExecuteScalarAsync();
                conn.Close();

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }
        public async Task<object> ExecuteScaralarParamAsync(List<SqlParameter> lstParametros, string sp)
        {
            object obj = new object();
            try
            {
                await conn.OpenAsync();
                cmd.CommandText = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(lstParametros.ToArray());
                obj = await cmd.ExecuteScalarAsync();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }
    }

}
