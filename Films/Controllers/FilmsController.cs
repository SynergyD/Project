using Films.Data.Interfaces;
using Films.Data.Models;
using Films.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IAllFilms allFilms;
        private readonly IFilmsGenre allGenres;

        public FilmsController(IAllFilms allFilms, IFilmsGenre allGenres)
        {
            this.allFilms = allFilms;
            this.allGenres = allGenres;
        }

        [Route("Films/List")]
        [Route("Films/List/{genre}")]
        public ViewResult List(string genre)
        {
            string _genre = genre;
            IEnumerable<Film> films = null;
            string currGenre = "";
            if (string.IsNullOrEmpty(genre))
            {
                films = allFilms.Films.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("horror",genre,StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Ужасы")).OrderBy(i => i.id);
                    currGenre = "Ужасы";
                }
                if (string.Equals("comedy", genre, StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Комедия")).OrderBy(i => i.id);
                    currGenre = "Комедия";
                }
                if (string.Equals("documentary", genre, StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Документальный")).OrderBy(i => i.id);
                    currGenre = "Документальный";
                }
                if (string.Equals("drama", genre, StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Драма")).OrderBy(i => i.id);
                    currGenre = "Драма";
                }
                if (string.Equals("adventure", genre, StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Приключение")).OrderBy(i => i.id);
                    currGenre = "Приключение";
                }
                if (string.Equals("fantasy", genre, StringComparison.OrdinalIgnoreCase))
                {
                    films = allFilms.Films.Where(i => i.Genre.GenreName.Equals("Фантастика")).OrderBy(i => i.id);
                    currGenre = "Фантастика";
                }
            }
            var carObj = new FilmsListViewModel
            {
                AllFilms = films,
                CurrGenre = currGenre
            };
            ViewBag.Title = "Страница с фильмами";
            return View(carObj);
        }

    }
}
