using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.ProxyDesignPattern
{
    class RealInternetaccess:OfficeInterNetAccess
    {
        private string username;
        public RealInternetaccess(string name)
        {
            this.username = name;
        }

        public void GrantInterNetAccess()
        {
            Console.WriteLine("The InterNet Access is Granted for User " + username);
        }
    }
}
