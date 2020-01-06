using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.ProxyDesignPattern
{
    class ProxyInternetaccess:OfficeInterNetAccess
    {
        private string username;
        private RealInternetaccess Realaccess;
        public ProxyInternetaccess(string Name)
        {
            this.username = Name;
        }

        public void GrantInterNetAccess()
        {
            if (getRole(username) < 4)
            {
                Realaccess = new RealInternetaccess(username);
                Realaccess.GrantInterNetAccess();
            }
            else
            {
                Console.WriteLine("No Internet Access For Your Job Level is Below 5");
            }
        }

        public int getRole(string username)
        { 
            return 6;
        }
    }
}
