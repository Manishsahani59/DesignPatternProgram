using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatternProgram
{
   public class Utility
    {
        string fullName, address, city, _zip, _Mobile, _email, state;

        Regex Name = new Regex(@"^[A-Z][\sa-zA-z]{3,30}$");
        Regex Address = new Regex(@"^[A-za-z0-9 .,()]*$");
        Regex City = new Regex(@"^[A-za-z .]*$");
        Regex Zip = new Regex(@"^[0-9]{6}$");
        Regex Phone = new Regex(@"^\d{10}$");
        Regex Email = new Regex(@"[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");

        static bool flag;
       static int choice;
        static char input;
        public static int choiceValidation()
        {
         
            do {
                flag = int.TryParse(Console.ReadLine(), out choice);
                if (flag)
                    break;
                Console.WriteLine("Enter the Proper input to select The Option");
            } while (!flag);
            return choice;
        }
        public static char CharValidation()
        {
            do
            {
                flag = char.TryParse(Console.ReadLine(), out input);
                if (flag)
                    break;
                Console.WriteLine("Enter the Proper Input...");
            } while (!flag);
            return input;
        }

        /// <summary>
        /// Validation of Name of user
        /// </summary>
        public string FullName()
        {
            Console.WriteLine("Enter Your Full Name !!! ");
            do
            {
                fullName = Console.ReadLine();
                flag = Name.IsMatch(fullName);
                if (flag)
                    break;
                Console.WriteLine("Enter the Name Properly...");

            } while (!flag);
            return fullName;
        }
        /// <summary>
        /// Any User Name FullName Validation
        /// </summary>
        public string CustomName()
        {

            do
            {
                fullName = Console.ReadLine();
                flag = Name.IsMatch(fullName);
                if (flag)
                    break;
                Console.WriteLine("Enter the Name Properly...");

            } while (!flag);
            return fullName;
        }

        public string Addressvalidation()
        {
            Console.WriteLine("Enter Your Address !!!");
            do
            {
                address = Console.ReadLine();
                flag = Address.IsMatch(address);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Address Properly...");

            } while (!flag);
            return address;
        }
        /// <summary>
        /// User City Validation
        /// </summary>
        public string CityValidation()
        {
            Console.WriteLine("Enter Your City !!!");
            do
            {
                city = Console.ReadLine();
                flag = City.IsMatch(city);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the CityName Properly...");

            } while (!flag);
            return city;
        }
        /// <summary>
        ///  User State Validation
        /// </summary>
        public string StateValidation()
        {
            Console.WriteLine("Enter Your State Name !!!");
            do
            {
                state = Console.ReadLine();
                flag = City.IsMatch(state);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the StateName Properly...");

            } while (!flag);
            return state;
        }
        /// <summary>
        /// Validate User Zip Code
        /// </summary>
        public string Zipvalidation()
        {
            Console.WriteLine("Enter the Zip code !!!");
            do
            {
                _zip = Console.ReadLine();
                flag = Zip.IsMatch(_zip);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Zip Code Properly...");
            } while (!flag);
            return _zip;
        }


        public string phoneNumber()
        {
            Console.WriteLine("Enter the Phone Number !!!");
            do
            {
                _Mobile = Console.ReadLine();
                flag = Phone.IsMatch(_Mobile);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Phone Number Properly...");
            } while (!flag);
            return _Mobile;
        }



    }
}
