using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem
{
    class FacadeAddressBook
    {
        AddressBookOperations AddressBookData = AddressBookOperations.GetAddressBookInstance;
        static int choice;
        private static readonly FacadeAddressBook facedeDesign = new FacadeAddressBook();
        public static FacadeAddressBook GetFacadeAddressBook
        {
            get{
                return facedeDesign; 
            }
        }

        public void FacadeAddressBookPattern()
        {
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("1 . Create AddressBook");
            Console.WriteLine("2 . Update AddressBook");
            Console.WriteLine("3 . Delete AddressBook Records");
            Console.WriteLine("4 . Address Book Sort By Name");
            Console.WriteLine("5 . Sort By ZipCode");
            Console.WriteLine("6 . Exit");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Enter the Your Choice To Continue Program .............");
                Console.WriteLine();
               choice = Utility.choiceValidation();
           
                switch (choice)
                {
                    case 1:
                        AddressBookData.CreateAddressBooks();
                        break;
                    case 2:
                        AddressBookData.UpdateAddressBooks();
                        break;
                    case 3:
                        AddressBookData.DeleteAddressBook();
                        break;
                    case 4:
                        AddressBookData.SortByName();
                        break;
                    case 5:
                        AddressBookData.SortByZip();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("You Select the Wrong Options");
                        Console.WriteLine();
                        break;
                }
            } while (choice != 6);

        }


    }
}
