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

        public DataTable cargarEmpleados()
        {
            if (Common.Cache.ObjectsCache.Empleados == null)
            {
                Common.Cache.ObjectsCache.Empleados = objectsDao.cargarEmpleados();
            }
            return Common.Cache.ObjectsCache.Empleados;
        }

        public DataTable cargarRazonSocial()
        {
            if (Common.Cache.ObjectsCache.RazonSocial == null)
            {
                Common.Cache.ObjectsCache.RazonSocial = objectsDao.cargarRazonSocial();
            }
            return Common.Cache.ObjectsCache.RazonSocial;
        }

        public DataTable cargarNominaTipos()
        {
            if (Common.Cache.ObjectsCache.NominaTipos == null)
            {
                Common.Cache.ObjectsCache.NominaTipos = objectsDao.cargarNominaTipos();
            }
            return Common.Cache.ObjectsCache.NominaTipos;
        }

        public DataTable cargarNominaConceptos()
        {
            if (Common.Cache.ObjectsCache.NominaConceptos == null)
            {
                Common.Cache.ObjectsCache.NominaConceptos = objectsDao.cargarNominaConceptos();
            }
            return Common.Cache.ObjectsCache.NominaConceptos;
        }
    }
}