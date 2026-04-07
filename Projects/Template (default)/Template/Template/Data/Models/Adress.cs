using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Models
{
    public record Address (
        string Street = "Unknown",
        string City = "Unknown",
        string PostalCode = "Unknown",
        string Country = "Unknown"
    );
}
