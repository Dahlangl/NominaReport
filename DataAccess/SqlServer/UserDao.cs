using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Server;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        public bool Login(string username, string password)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tbUsuarios WHERE userLogin=@user and userPassword=@pass";
                    command.Parameters.AddWithValue("@user", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.userId = reader.GetInt32(0);
                            UserCache.userLogin = reader.GetString(1);
                            UserCache.userNombre = reader.GetString(3);
                            UserCache.userApellidoPat = reader.GetString(4);
                            UserCache.userApellidoMat = reader.GetString(5);
                            UserCache.userEdad = reader.GetInt32(6);
                            UserCache.userGenero = reader.GetString(7);
                            UserCache.userEmail = reader.GetString(8);
                            UserCache.userRol = reader.GetInt32(9);
                        }
                        return true;
                    }
                    else
                        return false; 
                }
            }
        }
        //
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tbUsuarios WHERE userLogin=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5);
                        string userMail = reader.GetString(6);
                        string acountPassword = reader.GetString(2);

                        var mailService = new MailService.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Soporte Técnico: Solicitud de recuperación de contraseña",
                            body: "Hola " + userName + "\nSolicitaste recuperar tú contraseña.\n" +
                            "Tú contraseña actual es: " + acountPassword +
                            "¡Listo!, Te sugerimos cambiar la contraseña una vez que vuelvas a iniciar sesión",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola " + userName + "\nSolicitaste recuperar la contraseña.\nPor favor, verifica tú correo: " + userMail;
                    }
                    else
                        return "Lo sentimos, no exite una cuenta con ese nombre de usuario o correo";

                }
            }
        }
    }
}
