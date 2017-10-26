using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfDeptAppp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GolfDeptAppp.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<Club> Clubs { get; set; }
            public DbSet<Category> Categories { get; set; }
            
            public DbSet<ShoppingCart> ShoppingCarts { get; set; }
            public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

            public DbSet<Order> Orders { get; set; }
            
            public DbSet<OrderDetail> OrderDetails { get; set; }




    }
    }


