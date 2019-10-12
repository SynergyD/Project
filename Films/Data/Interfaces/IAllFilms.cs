using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Interfaces
{
    public interface IAllFilms
    {
        IEnumerable<Film> Films { get; }
        IEnumerable<Film> GetFavoriteFilms { get; }
        IEnumerable<Film> GetFilmByCountry(string country);
        Film GetObjectCar(int carId);

    }
}
