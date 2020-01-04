using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern
{
   public class ShopKeepar
    {
        private MobileShop Iphone;
        private MobileShop Samsung;
        private MobileShop BlackBerry;

        public ShopKeepar()
        {
            Iphone = new iphone();
            Samsung = new Samsung();
            BlackBerry = new BlackBerry();
        }

        public void IphoneSale()
        {
            Iphone.MobileName();
            Iphone.MobileModel();
            Iphone.MobilePrice();
        }
        public void SamsungSale()
        {
            Samsung.MobileName();
            Samsung.MobileModel();
            Samsung.MobilePrice();
        }
        public void BlackberrySale()
        {
            BlackBerry.MobileName();
            BlackBerry.MobileModel();
            BlackBerry.MobilePrice();
        }


    }
}
