using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
   interface ItemElements
    {
        public int Accept(ShoppingCartVisitor Visitor);

    }
}
