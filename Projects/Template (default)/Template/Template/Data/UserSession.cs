using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Data.Models;

namespace Template.Data
{
    public class UserSession
    {
        public static User? User { get; private set; }


        public static void SetSession(User user)
        {
            User = user;
        }

        public static void ClearSession()
        {
            User = null;
        }

        public static bool AuthenticateUser(string userName, string password, out User? authenticatedUser)
        {
            using (var db = new AppDbContext())
            {
                User? foundUser = db.Users.SingleOrDefault(u => u.UserName == userName);
                if (foundUser == null)
                {
                    authenticatedUser = null;
                    return false;
                }

                if (BCrypt.Net.BCrypt.Verify(password, foundUser.Password))
                {
                    authenticatedUser = foundUser;
                    return true;
                }

                authenticatedUser = null;
                return false;
            }
        }
    }
}
