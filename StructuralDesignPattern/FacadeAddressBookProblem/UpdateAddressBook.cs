using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem
{
    class UpdateAddressBook : AddressBookInterface
    {
        static string fullName, address, city, _zip, _Mobile, _email, state;
        Utility utility = new Utility();
        public string FullName()
        {
            fullName = utility.FullName();
            return fullName;
        }
        public string Address()
        {
            address = utility.Addressvalidation();
            return address;
        }

        public string City()
        {
            city = utility.CityValidation();
            return city;
        }

        public string MobileNumber()
        {
            _Mobile = utility.phoneNumber();
            return _Mobile;
        }

        public string State()
        {
            state = utility.StateValidation();
            return state;
        }

        public string Zip()
        {
            throw new NotImplementedException();
        }
    }
}
