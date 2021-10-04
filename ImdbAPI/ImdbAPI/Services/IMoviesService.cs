using ImdbAPI.Models;
using ImdbAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<MoviesResponse>> GetMovies(string search);
    }
}
