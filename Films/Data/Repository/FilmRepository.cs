using Films.Data.Interfaces;
using Films.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Repository
{
    public class FilmRepository : IAllFilms
    {
        private readonly AppDBContent appDBContent;
        public FilmRepository(AppDBContent appDBContent )
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Film> Films => appDBContent.Film.Include(f => f.Genre);

        public IEnumerable<Film> GetFavoriteFilms => appDBContent.Film.Where(p => p.IsFavorite).Include(c => c.Genre);

        public IEnumerable<Film> GetFilmByCountry(string country) => appDBContent.Film.Where(p => p.CountryName == country).Include(c => c.Genre);

        public Film GetObjectCar(int carId) => appDBContent.Film.FirstOrDefault(p => p.id == carId);

    }
}
