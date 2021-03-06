using ImdbAPI.Models;
using System;
using System.Collections.Generic;

namespace ImdbAPI.Response
{
    public class MediasResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AverageRating { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public IEnumerable<ActorsResponse> Cast { get; set; }
    }
}
