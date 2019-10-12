using Films.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Interfaces
{
    public interface IFilmsGenre
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
