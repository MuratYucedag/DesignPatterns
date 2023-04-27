using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.DAL
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool DiscountCodeStatus{ get; set; }
    }
}
