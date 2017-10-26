using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.Data.Models;
using GolfDeptAppp.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfDeptAppp.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: /<controller>/
        private readonly IClubRepository _clubRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IClubRepository clubRepository, ShoppingCart shoppingCart)
        {
            _clubRepository = clubRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int clubId)
        {
            var selectedClub = _clubRepository.Clubs.FirstOrDefault(p => p.ClubId == clubId);
            if (selectedClub != null)
            {
                _shoppingCart.AddToCart(selectedClub, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int clubId)
        {
            var selectedClub = _clubRepository.Clubs.FirstOrDefault(p => p.ClubId == clubId);
            if (selectedClub != null)
            {
                _shoppingCart.RemoveFromCart(selectedClub);
            }
            return RedirectToAction("Index");
        }

    }
    }
