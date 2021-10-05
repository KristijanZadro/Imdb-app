using ImdbAPI.Data;
using ImdbAPI.Models;
using ImdbAPI.Models.Enums;
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
    public class MediasService : IMediasService
    {
        private readonly AppDbContext _context;
        public MediasService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MediasResponse>> GetMedias(string search, int num, string mediaType)
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

            var medias = new List<Media>();

            if (mediaType.Equals("movie"))
            {
                medias = await _context.Medias.Include(x => x.Cast).ThenInclude(x => x.Actor).Where(Filter(search, operation, GroupType.Movie)).OrderByDescending(x => x.AverageRating).Take(num).ToListAsync();
            }
            else if (mediaType.Equals("show"))
            {
                medias = await _context.Medias.Include(x => x.Cast).ThenInclude(x => x.Actor).Where(Filter(search, operation, GroupType.TvShow)).OrderByDescending(x => x.AverageRating).Take(num).ToListAsync();
            }
            else
            {
                return null;
            }

            var mappedMedias = medias.Select(m => new MediasResponse
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
            return mappedMedias.OrderByDescending(x => x.AverageRating);
        }

        private static Expression<Func<Media, bool>> Filter(string search, string operation, GroupType mediaType)
        {
            search = search?.Trim().ToLower();
            var numInSearch = new string(search?.Where(char.IsDigit).ToArray());
            double.TryParse(numInSearch, out double num);

            return x => x.GroupType == mediaType
            && (string.IsNullOrEmpty(search)
            || ((search.Contains("stars") && num >= 1 && ((operation.Equals("<") && x.AverageRating <= num) || (operation.Equals(">") && x.AverageRating >= num) || (operation.Equals("=") && x.AverageRating == num)))
            || (search.Contains("years") && num >= 1 && ((operation.Equals("<") && x.ReleaseDate.Year < DateTime.Now.Year - num) || (operation.Equals(">") && x.ReleaseDate.Year > DateTime.Now.Year - num)))
            || (num >= 1000 && ((operation.Equals("<") && x.ReleaseDate.Year < num) || (operation.Equals(">") && x.ReleaseDate.Year > num)))
            || (x.Description.Contains(search) || x.ReleaseDate.Year == num || x.Title.ToLower().Contains(search)))
            );
        }
    }
}
