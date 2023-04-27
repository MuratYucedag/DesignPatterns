using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.DAL
{
    public class WelcomeMessage
    {
        public int WelcomeMessageID { get; set; }
        public string NameSurname { get; set; }
        public string Content { get; set; }
    }
}
