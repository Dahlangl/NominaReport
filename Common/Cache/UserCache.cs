using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {
        public static int userId {  get; set; }
        public static string userLogin { get; set; }
        public static string userNombre { get; set; }
        public static string userApellidoPat { get; set; }
        public static string userApellidoMat {  get; set; }
        public static int userEdad { get; set;}
        public static string userGenero { get; set;}
        public static int userRol { get; set;}
        public static string userEmail { get; set;}
    }
}
