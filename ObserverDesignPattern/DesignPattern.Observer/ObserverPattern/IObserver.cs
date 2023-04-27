using DesignPattern.Observer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
