using GolfDeptAppp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfDeptAppp.ViewModels
{
    public class ClubListViewModel
    {
        public IEnumerable<Club> Clubs { get; set; }
        public string CurrentCategory { get; set; }

    }
}
