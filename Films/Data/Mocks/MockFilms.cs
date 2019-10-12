using Films.Data.Interfaces;
using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Mocks
{
    public class MockFilms : IAllFilms
    {
        private readonly IFilmsGenre GenreFilms = new MockGenre();
        public IEnumerable<Film> Films
        {
            get
            {
                return new List<Film>
                {
                    new Film
                    {
                        Name = "Мстители",
                        EnglishName = "Avengers",
                        Year = 2012,
                        Img = "/img/avengers.jpg",
                        Price = 7.5,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = GenreFilms.AllGenres.ElementAtOrDefault(2)
                    },
                    new Film
                    {
                        Name = "Побег из Шоушенка",
                        EnglishName = "The Shawshank Redemption",
                        Year = 1994,
                        Img = "/img/redem.jpg",
                        Price = 11.5,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = GenreFilms.AllGenres.ElementAtOrDefault(4)
                    },
                    new Film
                    {
                        Name = "Маска",
                        EnglishName = "The Mask",
                        Year = 1994,
                        Img = "/img/mask.jpg",
                        Price = 4.5,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = GenreFilms.AllGenres.ElementAtOrDefault(1)
                    },
                    new Film
                    {
                        Name = "1+1",
                        EnglishName = "Intouchables",
                        Year = 2011,
                        Img = "/img/plus.jpg",
                        Price = 8.5,
                        IsFavorite = true,
                        CountryName = "Франция",
                        Genre = GenreFilms.AllGenres.ElementAtOrDefault(1)
                    },
                    new Film
                    {
                        Name = "Оно",
                        EnglishName = "It",
                        Year = 2017,
                        Img = "/img/it.jpg",
                        Price = 5,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = GenreFilms.AllGenres.ElementAtOrDefault(0)
                    }                       
                };
            }
        }

        public IEnumerable<Film> GetFavoriteFilms { get; }

        public IEnumerable<Film> GetFilmByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public Film GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
