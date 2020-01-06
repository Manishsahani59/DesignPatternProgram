using System;

namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
    public interface ShoppingCartVisitor
    {
       public int visit(Book book);
        public int visit(Fruit fruit);
    }
}