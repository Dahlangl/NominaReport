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
        public DataTable cargarEmpleados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbColabores", connection);
                dtAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
        }
        public DataTable cargarRazonSocial()
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbSucursales", connection);
                dtAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
        }
        public DataTable cargarNominaTipos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbNominaTipo", connection);
                dtAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
        }
        public DataTable cargarNominaConceptos()
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM dtNominaConceptos", connection);
                dtAdapter.SelectCommand.CommandType= CommandType.Text;
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
        }
    }
}
