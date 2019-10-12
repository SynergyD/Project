using Films.Data.Interfaces;
using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Repository
{
    public class GenreRepository : IFilmsGenre
    {
        private readonly AppDBContent appDBContent;

        public GenreRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Genre> AllGenres => appDBContent.Genre;
    }
}
