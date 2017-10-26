using GolfDeptAppp.Data.Models;
using System.Collections.Generic;

namespace GolfDeptAppp.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

    }
}
