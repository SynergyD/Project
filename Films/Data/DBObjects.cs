using Films.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            

            if (!content.Genre.Any())
            {
                content.Genre.AddRange(Genres.Select(c => c.Value));
            }
            if (!content.Film.Any())
            {
                content.AddRange(
                    new Film
                    {
                        Name = "Мстители",
                        EnglishName = "Avengers",
                        Year = 2012,
                        Img = "/img/avengers.jpg",
                        Price = 7.5,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = Genres["Фантастика"]
                    },
                    new Film
                    {
                        Name = "Облачный атлас",
                        EnglishName = "Cloud Atlas",
                        Year = 2012,
                        Img = "/img/atlas.jpg",
                        Price = 6.3,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Фантастика"]
                    },
                    new Film
                    {
                        Name = "Мир Юрского периода",
                        EnglishName = "Jurassic World",
                        Year = 2015,
                        Img = "/img/jurassic.jpg",
                        Price = 9.3,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Фантастика"]
                    },
                    new Film
                    {
                        Name = "Джон Картер",
                        EnglishName = "John Carter",
                        Year = 2012,
                        Img = "/img/john.jpg",
                        Price = 4.7,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Фантастика"]
                    },
                    new Film
                    {
                        Name = "Лига справедливости",
                        EnglishName = "Justice League",
                        Year = 2017,
                        Img = "/img/justice.jpg",
                        Price = 10.4,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = Genres["Фантастика"]
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
                        Genre = Genres["Драма"]
                    },
                    new Film
                    {
                        Name = "Маска",
                        EnglishName = "The Mask",
                        Year = 1994,
                        Img = "/img/mask.jpg",
                        Price = 4.5,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = Genres["Комедия"]
                    },
                    new Film
                    {
                        Name = "Всегда говори ДА",
                        EnglishName = "Yes Man",
                        Year = 2008,
                        Img = "/img/yes.jpg",
                        Price = 7.1,
                        IsFavorite = true,
                        CountryName = "США",
                        Genre = Genres["Комедия"]
                    },
                    new Film
                    {
                        Name = "Тупой и еще тупее",
                        EnglishName = "Dumb and Dumber",
                        Year = 1994,
                        Img = "/img/dumb.jpg",
                        Price = 7.2,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Комедия"]
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
                        Genre = Genres["Драма"]
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
                        Genre = Genres["Ужасы"]
                    },
                    new Film
                    {
                        Name = "Астрал",
                        EnglishName = "Insidious",
                        Year = 2010,
                        Img = "/img/insidious.jpg",
                        Price = 4.5,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Ужасы"]
                    },
                    new Film
                    {
                        Name = "Жизнь",
                        EnglishName = "One Life",
                        Year = 2011,
                        Img = "/img/one.jpg",
                        Price = 4.9,
                        IsFavorite = false,
                        CountryName = "Великобритания",
                        Genre = Genres["Документальный"]
                    },
                    new Film
                    {
                        Name = "Живое",
                        EnglishName = "Life",
                        Year = 2017,
                        Img = "/img/life.jpg",
                        Price = 6.2,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Ужасы"]
                    },
                    new Film
                    {
                        Name = "Алиса в стране чудес",
                        EnglishName = "Alice in Wonderland",
                        Year = 2010,
                        Img = "/img/alice.jpg",
                        Price = 2.2,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Приключение"]
                    },
                    new Film
                    {
                        Name = "Сплит",
                        EnglishName = "Split",
                        Year = 2017,
                        Img = "/img/split.jpg",
                        Price = 5.5,
                        IsFavorite = false,
                        CountryName = "США",
                        Genre = Genres["Ужасы"]
                    }
                    ) ;
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Genre> Genre;
        public static Dictionary<string, Genre> Genres
        {
            get
            {
                if (Genre == null)
                {
                    var list = new Genre[]
                    {
                    new Genre{GenreName = "Ужасы"},
                    new Genre{GenreName = "Комедия"},
                    new Genre{GenreName = "Фантастика"},
                    new Genre{GenreName = "Документальный"},
                    new Genre{GenreName = "Драма"},
                    new Genre{GenreName = "Приключение"},
                    };
                    Genre = new Dictionary<string, Genre>();
                    foreach (Genre el in list)
                    {
                        Genre.Add(el.GenreName, el);
                    }
                }
                return Genre;
            }
        }
    }
}
