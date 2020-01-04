using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem
{
    public class CreateAddressBook : AddressBookInterface
    {
        static  string fullName, address, city, _zip, _Mobile, _email, state;
        Utility utility = new Utility();
        public string FullName()
        {
         fullName= utility.FullName();
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
            _zip = utility.Zipvalidation();
            return _zip;
        }
    }
}
