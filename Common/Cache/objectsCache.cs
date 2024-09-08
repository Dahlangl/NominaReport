using System.Data;

namespace Common.Cache
{
    public static class ObjectsCache
    {
        public static DataTable Empleados { get; set; }
        public static DataTable RazonSocial { get; set; }
        public static DataTable NominaTipos { get; set; }
        public static DataTable NominaConceptos { get; set; }
    }
}
