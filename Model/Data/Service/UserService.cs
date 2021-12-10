using System.Collections.Generic;
using System.Linq;

namespace CourseWork.Model.Data.Service
{
    public class UserService
    {

        readonly static Dictionary<int, User> users = new();
        public static bool AuthUser(string nickname, string password)
        {
            using (ApplicationContext db = new())
            {
                foreach (var item in db.Users)
                    users.Add(item.Id, item);

                bool isAuthenticated = db.Users.Any(u => u.Nickname == nickname & u.Password == password);
                if (isAuthenticated) return true;
            }
            return false;

        }
    }
}
