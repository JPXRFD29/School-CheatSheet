using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Models
{
    public class MovieAiring
    {
        public int Id { get; set; }

        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime Airing { get; set; }
    }
}
