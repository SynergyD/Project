using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Models
{
    public class Film
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string EnglishName { set; get; }
        public string Img { set; get; }
        public double Price { set; get; }
        public ushort Year { set; get; }
        public bool IsFavorite { set; get; }
        public string CountryName { set; get; }
        public int GenreID { set; get; }
        public virtual Genre Genre { set; get; }
        
    }
}
