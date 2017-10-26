using GolfDeptAppp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfDeptAppp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Club> PreferredClubs { get; internal set; }
        public IEnumerable<Club> PrefferedClubs { get; set; }
    }
}
