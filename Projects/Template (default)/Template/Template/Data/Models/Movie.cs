using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeOnly Duration { get; set; }
        public string? PosterUrl { get; set; }
        public float Rating { get; set; }   // 0.0 ... 5.0

        public ICollection<MovieAiring> MovieAirings { get; } = [];


        public void SavePoster(Theater theater)
        {
            // TODO: Implement
        }
    }
}