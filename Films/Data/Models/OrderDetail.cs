using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int OrderID { get; set; }
        public int FilmID { get; set; }
        public double Price { get; set; }
        public virtual Film Film { get; set; }
        public virtual Order Order { get; set; }

        
    }
}
