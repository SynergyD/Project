using Films.Data.Interfaces;
using Films.Data.Models;
using Films.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllFilms _carRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllFilms carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);

        }

        public RedirectToActionResult aaddToCart(int id)
        {
            var item = _carRep.Films.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
