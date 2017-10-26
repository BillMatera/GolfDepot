using GolfDeptAppp.Data.Models;
using System.Collections.Generic;

namespace GolfDeptAppp.Data.Interfaces
{
    public interface IOrderRepository
        {
            void CreateOrder(Order order);
            IEnumerable<Order> Orders { get; }
    }
    }

