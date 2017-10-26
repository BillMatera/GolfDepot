using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfDeptAppp.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ClubId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Club Club { get; set; }
        public virtual Order Order { get; set; }
    }
}
