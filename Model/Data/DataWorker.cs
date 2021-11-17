using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model.Data
{
    public class DataWorker
    {

        public static string AuthUser(string nickname, string password)
        {
            using (AppContext db = new())   
            {
                bool isAuthenticated = db.Users.Any(u => u.Nickname == nickname & u.Password == password);
                if (isAuthenticated) return "You are in!";
            }
            return "Wrong data!";

        }
        public static List<User> GetAllUsers()
        {
            using AppContext db = new();
            List<User> users = db.Users.ToList();
            return users;

        }
    }
}
