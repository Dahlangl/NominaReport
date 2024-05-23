using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer
{
    public class ObjectsDao:ConnectionToSql
    {
        public DataTable cargarEmpleadosCbox()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter dtAdapter = new SqlDataAdapter("SP_OBTNRCOLAB", connection);
                dtAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
        }
    }
}
