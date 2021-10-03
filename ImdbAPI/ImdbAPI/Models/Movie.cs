using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<MovieActor> Cast { get; set; }
    }
}
