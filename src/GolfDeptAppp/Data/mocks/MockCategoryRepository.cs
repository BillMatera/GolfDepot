using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.Data.Models;
using System.Collections.Generic;

namespace GolfDeptAppp.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
        {
            public IEnumerable<Category> Categories
            {
                get
                {
                return new List<Category>
                     {
                         new Category { CategoryName = "Drivers", Description = "All Drivers" },
                         new Category { CategoryName = "Woods", Description = "All Woods" },
                         new Category { CategoryName = "Irons", Description = "All Irons" },
                         new Category { CategoryName = "Putters", Description = "All Putters" }
                     };
                }
            }

        }
    }

