using ImdbAPI.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Models
{
    public class Rating : BaseEntity
    {
        public int StarRating { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
