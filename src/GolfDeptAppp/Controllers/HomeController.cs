using Microsoft.AspNetCore.Mvc;
using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfDeptAppp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClubRepository _clubRepository;
        public HomeController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredClubs = _clubRepository.PreferredClubs
            };
            return View(homeViewModel);
        }
    }
}