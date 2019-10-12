using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Film> FavFilms { get; set; }
    }
}
