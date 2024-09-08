using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer
{
    public class ObjectsDao : ConnectionToSql
    {
        public DataTable cargarEmpleados()
        {
            if (Common.Cache.ObjectsCache.Empleados == null) // Verifica si está en caché
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbColaboradores", connection);
                    dtAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    dtAdapter.Fill(dt);

                    // Guardar en caché
                    Common.Cache.ObjectsCache.Empleados = dt;
                }
            }
            return Common.Cache.ObjectsCache.Empleados; // Devuelve los datos desde el caché
        }

        public DataTable cargarRazonSocial()
        {
            if (Common.Cache.ObjectsCache.RazonSocial == null)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbSucursales", connection);
                    dtAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    dtAdapter.Fill(dt);

                    // Guardar en caché
                    Common.Cache.ObjectsCache.RazonSocial = dt;
                }
            }
            return Common.Cache.ObjectsCache.RazonSocial;
        }

        public DataTable cargarNominaTipos()
        {
            if (Common.Cache.ObjectsCache.NominaTipos == null)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbNominaTipo", connection);
                    dtAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    dtAdapter.Fill(dt);

                    // Guardar en caché
                    Common.Cache.ObjectsCache.NominaTipos = dt;
                }
            }
            return Common.Cache.ObjectsCache.NominaTipos;
        }

        public DataTable cargarNominaConceptos()
        {
            if (Common.Cache.ObjectsCache.NominaConceptos == null)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("SELECT * FROM tbNominaConceptos", connection);
                    dtAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    dtAdapter.Fill(dt);

                    // Guardar en caché
                    Common.Cache.ObjectsCache.NominaConceptos = dt;
                }
            }
            return Common.Cache.ObjectsCache.NominaConceptos;
        }
    }
}