using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Models
{
    public enum Role
    {
        Client,     // can buy movie tickets.
        Worker,     // Can add/update/delete Movies, but needs to be Authorized by "Manager".
        Manager,    // Needs to autorize Worker. Autorize bought tickets. Can also add/update/delete movies.
        Admin,      // Has full controll over everything.
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public decimal Credit { get; set; }
        public Role Role { get; set; }

        public int? TheaterId { get; set; }
        public Theater? Theater { get; set; }


        public string GetFormatedCredit()
        {
            if (Credit == -1.0m) { return "$ inf.";  }

            return Credit.ToString("C", new CultureInfo("nl-NL"));
        }
    }
}
