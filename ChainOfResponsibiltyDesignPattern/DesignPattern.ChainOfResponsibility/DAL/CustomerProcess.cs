using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
