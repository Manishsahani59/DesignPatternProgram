using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern
{
    public class Samsung : MobileShop
    {
        public void MobileModel()
        {
            Console.WriteLine("Model Numnber 11 pro");
        }
        public void MobileName()
        {
            Console.WriteLine("Mobile : iPhone");
        }

        public void MobilePrice()
        {
            Console.WriteLine("Price is 99.990");
        }
    }
}
