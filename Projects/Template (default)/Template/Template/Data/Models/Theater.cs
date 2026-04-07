using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Models
{

    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public ICollection<User> Employees { get; } = [];
        public ICollection<MovieAiring> MovieAirings { get; } = [];
    }
}
