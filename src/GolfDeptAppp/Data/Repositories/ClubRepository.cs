using GolfDeptAppp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfDeptAppp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GolfDeptAppp.Data.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly AppDbContext _appDbContext;
        public ClubRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Club> Clubs => _appDbContext.Clubs.Include(c => c.Category);

        public IEnumerable<Club> PreferredClubs => _appDbContext.Clubs.Where(p => p.IsPreferredClub).Include(c => c.Category);

        public Club GetClubById(int clubId) => _appDbContext.Clubs.FirstOrDefault(p => p.ClubId == clubId);
    }
}
