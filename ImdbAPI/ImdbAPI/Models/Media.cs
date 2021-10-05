using ImdbAPI.Models.Base;
using ImdbAPI.Models.Enums;
using System;
using System.Collections.Generic;

namespace ImdbAPI.Models
{
    public class Media : BaseEntity
    {
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AverageRating { get; set; }
        public GroupType GroupType { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public IEnumerable<MediaActor> Cast { get; set; }
    }
}
