using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string username, string password) 
        {
            return userDao.Login(username, password);
        } 
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
        public bool editPassword(string username, string password)
        {
            if (username == UserCache.userLogin)
            {
               
            }
            return true;
        }
    }
}
