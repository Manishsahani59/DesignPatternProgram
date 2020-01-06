using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
   public class ShoppingCartClient
    {
        public void VisitorPattern()
        {
            ItemElements[] item = new ItemElements[] { new Book(20, "1123"), new Book(50, "125"),new Fruit(20,"Banana",1),new Fruit(80,"PineApple",2)};
            int total = CalculatePrice(item);
            Console.WriteLine("Total Price is " + total);
        }
        private static int CalculatePrice(ItemElements[] item)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImp();
            int sum = 0;
            foreach (ItemElements items in item)
            {
                sum = sum + items.Accept(visitor);
            }
            return sum;
        }
    }
}
