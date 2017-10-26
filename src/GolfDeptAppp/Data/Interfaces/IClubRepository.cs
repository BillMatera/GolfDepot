using GolfDeptAppp.Data.Models;
using System.Collections.Generic;

namespace GolfDeptAppp.Data.Interfaces
{
    public interface IClubRepository
    {
        IEnumerable<Club> Clubs { get; }
        IEnumerable<Club> PreferredClubs { get; }
        Club GetClubById(int clubId);

    }
}
