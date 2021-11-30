using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model.Data
{
    public class DataWorker
    {

        public static bool AuthUser(string nickname, string password)
        {
            using (ApplicationContext db = new())
            {
                bool isAuthenticated = db.Users.Any(u => u.Nickname == nickname & u.Password == password);
                if (isAuthenticated) return true;
            }
            return false;

        }
        public static List<User> GetAllUsers()
        {
            using ApplicationContext db = new();
            List<User> users = db.Users.ToList();
            return users;
        }
        public static void CreateReservation(int gridRow, int gridColumn, string page)
        {
            using (ApplicationContext db = new())
            {
                Reservation reservation = new() { GridColumn = gridColumn, GridRow = gridRow, Page = page };
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
        }
        public static bool isReservationExist(int gridRow, int gridColumn, string page)
        {
            using (ApplicationContext db = new())
            {
                bool isExist = db.Reservations.Any(r => r.GridRow == gridRow && r.GridColumn == gridColumn && r.Page.ToLower() == page.ToLower());
                if (isExist) return true;
            }
            return false;
        }
    }
}
