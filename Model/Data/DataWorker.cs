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
        public static string CreateUser(string nickname, string password)
        {

            //User user = new User() { Nickname = nickname, Password = password };
            using (AppContext db = new())
            {
                bool isNewUser = db.Users.Any(u=> u.Nickname == nickname & u.Password== password);
                if (isNewUser) return "Already exist!";
                User user = new User() { Nickname = nickname, Password = password };
                db.Users.Add(user);
                db.SaveChanges();
                return user.Nickname;
            }
        }
    }
}
