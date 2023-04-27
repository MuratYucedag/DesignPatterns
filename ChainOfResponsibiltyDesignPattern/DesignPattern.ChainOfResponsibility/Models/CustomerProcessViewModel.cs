using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel
    {
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
