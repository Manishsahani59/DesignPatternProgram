using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
    public class ShoppingCartVisitorImp : ShoppingCartVisitor
    {
        public int visit(Book book)
        {
            int cost = 0;
            if (book.getPrice() > 50)
            {
                cost = book.getPrice() - 5;
            }
            else
            {
                cost = book.getPrice();
            }
            Console.WriteLine("Book ISBN " +book.getIsbnNumber() + " Cost = " +cost );
            return cost;
        }

        public int visit(Fruit fruit)
        {
            int cost = fruit.getPrice() * fruit.getWeight();
            Console.WriteLine(fruit.FruitName() + " Price  =  "+cost );
            return cost;
        }
    }
}
