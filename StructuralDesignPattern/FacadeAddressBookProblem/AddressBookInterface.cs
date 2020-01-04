using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem
{
    public interface AddressBookInterface
    {
        public string FullName();
        public string Address();

        public string City();
        public string State();
        public string MobileNumber();
        public string Zip();

    }
}
