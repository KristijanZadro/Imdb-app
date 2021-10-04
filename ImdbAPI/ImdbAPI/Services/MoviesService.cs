using ImdbAPI.Data;
using ImdbAPI.Models;
using ImdbAPI.Response;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<MoviesResponse>> GetMovies(string search, int num)
        {
            search = HttpUtility.UrlDecode(search);

            List<string> greaterComparison = new()
            {
                "at least",
                "more than",
                "greater than",
                "younger than",
                "after"
            };
            List<string> lesserComparison = new()
            {
                "at most",
                "less than",
                "fewer than",
                "older than",
                "before"
            };
            string operation = "=";

            if (!string.IsNullOrEmpty(search) && lesserComparison.Any(x => search.Contains(x)))
            {
                operation = "<";
            }
            else if (!string.IsNullOrEmpty(search) && greaterComparison.Any(x => search.Contains(x)))
            {
                operation = ">";
            }

            var movies = await _context.Movies.Include(x => x.Cast).ThenInclude(x => x.Actor).Where(Filter(search, operation)).OrderByDescending(x => x.AverageRating).Take(num).ToListAsync();

            var mappedMovies = movies.Select(m => new MoviesResponse
            {
                Id = m.Id,
                Title = m.Title,
                CoverImage = m.CoverImage,
                Description = m.Description,
                ReleaseDate = m.ReleaseDate,
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

        private static Expression<Func<Movie, bool>> Filter(string search, string operation)
        {
            search = search?.Trim().ToLower();
            var numInSearch = new string(search?.Where(char.IsDigit).ToArray());
            double.TryParse(numInSearch, out double num);

            return x => string.IsNullOrEmpty(search)
            || ((search.Contains("stars") && num >= 1 && ((operation.Equals("<") && x.AverageRating <= num) || (operation.Equals(">") && x.AverageRating >= num) || (operation.Equals("=") && x.AverageRating == num)))
            || (search.Contains("years") && num >= 1 && ((operation.Equals("<") && x.ReleaseDate.Year < DateTime.Now.Year - num) || (operation.Equals(">") && x.ReleaseDate.Year > DateTime.Now.Year - num)))
            || (num >= 1000 && ((operation.Equals("<") && x.ReleaseDate.Year < num) || (operation.Equals(">") && x.ReleaseDate.Year > num)))
            || (x.Description.Contains(search) || x.ReleaseDate.Year == num || x.Title.Contains(search))
            );
        }
    }
}
