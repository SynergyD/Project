using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.ViewModels
{
    public class FilmsListViewModel
    {
        public IEnumerable<Film> AllFilms { get; set; }
        public string CurrGenre { get; set; }
    }
}
