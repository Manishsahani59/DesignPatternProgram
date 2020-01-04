using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern
{
    public class BlackBerry : MobileShop
    {
        public void MobileModel()
        {
            Console.WriteLine("Model : 7T Pro");
        }

        public void MobileName()
        {
            Console.WriteLine("Mobile : BlackBerry");
        }

        public void MobilePrice()
        {
            Console.WriteLine("Price : 55.999");
        }
    }
}
