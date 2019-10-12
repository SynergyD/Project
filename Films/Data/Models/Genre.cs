using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Models
{
    public class Genre
    {
        public int id { get; set; }
        public string GenreName { get; set; }

        //public string desc { get; set; }
        public List<Film> Films { get; set; }
    }
}
