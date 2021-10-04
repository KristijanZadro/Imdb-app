using ImdbAPI.Data;
using ImdbAPI.Models;
using ImdbAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace ImdbAPI.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MoviesResponse>> GetMovies(string search)
        {
            search = HttpUtility.UrlDecode(search);
            var movies = _context.Movies.Where(Filter(search));

            var mappedMovies = movies.Select(m => new MoviesResponse
            {
                Id = m.Id,
                Title = m.Title,
                CoverImage = m.CoverImage,
                Description = m.Description,
                ReleaseDate = m.ReleaseDate,
                Ratings = m.Ratings.Select(r => new Rating {
                    StarRating = r.StarRating
                }),
                AverageRating = m.AverageRating,
                Cast = m.Cast.Select(x => new ActorsResponse
                {
                    Id = x.Actor.Id,
                    Name = x.Actor.Name,
                    Surname = x.Actor.Surname
                })
            });
            return mappedMovies.OrderByDescending(x => x.AverageRating);
        }

        private static Expression<Func<Movie, bool>> Filter(string search)
        {
            search = search?.Trim().ToLower();

            return x => string.IsNullOrEmpty(search) ||
            (
                x.Title.ToLower().Contains(search) ||
                x.Description.ToLower().Contains(search)
            );
            
        }
    }
}
