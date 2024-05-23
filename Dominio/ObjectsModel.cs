using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer;
using Common.Cache;
using System.Data;

namespace Dominio
{
    public class ObjectsModel
    {
        ObjectsDao objectsDao = new ObjectsDao();
        public DataTable cargarEmpleadosCbox()
        {
            return objectsDao.cargarEmpleadosCbox();
        }
    }
}
