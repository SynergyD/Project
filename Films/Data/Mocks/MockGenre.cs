using Films.Data.Interfaces;
using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Mocks
{
    public class MockGenre : IFilmsGenre
    {
        public IEnumerable<Genre> AllGenres
        {
            get
            {
                return new List<Genre>
                {
                    new Genre{GenreName = "Ужасы"},
                    new Genre{GenreName = "Комедия"},
                    new Genre{GenreName = "Фантастика"},
                    new Genre{GenreName = "Документальные"},
                    new Genre{GenreName = "Драма"},
                    new Genre{GenreName = "Боевик"},
                };
            }
        }
    }
}
