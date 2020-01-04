using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern
{
    public class iphone : MobileShop
    {
        public void MobileModel()
        {
            Console.WriteLine(" Model : Galaxy J2");
        }

        public void MobileName()
        {
            Console.WriteLine("Mobile : Samsug ");
        }

        public void MobilePrice()
        {
            Console.WriteLine("Price : 7000");
        }
    }
}
