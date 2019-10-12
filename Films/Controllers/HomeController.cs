using Films.Data.Interfaces;
using Films.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllFilms carRep;

        public HomeController(IAllFilms carRep)
        {
            this.carRep = carRep;

        }
        public ViewResult Index()
        {
            var homeFilms = new HomeViewModel
            {
                FavFilms = carRep.GetFavoriteFilms
            };
            return View(homeFilms);
        }
    }
}
