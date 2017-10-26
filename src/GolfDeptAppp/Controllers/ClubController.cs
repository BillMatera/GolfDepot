using GolfDeptAppp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfDeptAppp.Controllers
{
    public class ClubController : Controller
    {
        
        private readonly IClubRepository _clubRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ClubController(ICategoryRepository categoryRepository, IClubRepository clubRepository)
        {
       
            _clubRepository = clubRepository;
            _categoryRepository = categoryRepository;

        }


        public ViewResult List(int categoryId)
        {
            int _categoryId = categoryId;
            IEnumerable<Club> clubs;

            string currentCategory = string.Empty;

            if (int.Equals(categoryId, 0))
            {
                clubs = _clubRepository.Clubs.OrderBy(n => n.ClubId);
                currentCategory = "All Clubs";
            }
            else
            {
                if (int.Equals(categoryId, 1))
                {
                    clubs = _clubRepository.Clubs.Where(p => p.Category.CategoryId.Equals(1)).OrderBy(p => p.Name);
                    currentCategory = "Driver";
                }
                else
                {
                    clubs = _clubRepository.Clubs.Where(p => p.Category.CategoryId.Equals(2)).OrderBy(p => p.Name);
                    currentCategory = "Putter";
                }

            }

            return View(new ClubListViewModel
            {
                Clubs = clubs,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Details(int clubId)
        {
            var club = _clubRepository.Clubs.FirstOrDefault(d => d.ClubId == clubId);
            if (club == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(club);
        }
    }
}
