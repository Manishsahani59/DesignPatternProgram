using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.AdapterDesignPattern
{
    class AdapterClass
    {
        public void Apdapterclass()
        {
            CreaditCard targetInterface = new BankCustomer();
            targetInterface.getBankDetails();
            Console.WriteLine(targetInterface.getCrearitCard());
        }
    }
}
