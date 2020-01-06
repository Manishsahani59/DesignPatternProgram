using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using ConsoleTables;


namespace DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem
{
  
    sealed  class AddressBookOperations
    {
        Utility utility = new Utility();
        private static readonly AddressBookOperations AddressBookinstance = new AddressBookOperations();
        public static AddressBookOperations GetAddressBookInstance
        {
            get
            {
                return AddressBookinstance;
            }
        }

        public AddressBookOperations()
        {
            createAddressBook = new CreateAddressBook();
            UpdateAddressBook = new UpdateAddressBook();
        }

        static string fullName, address, city, _zip, _Mobile, _email, state;
        public static string AddressBookPath=@"C:\Users\User\source\repos\DesignPatternProgram\DesignPatternProgram\StructuralDesignPattern\AddressBookJsonFiles\AddressBook.json";
        public static string AddressBookInfo = File.ReadAllText(AddressBookPath);
        List<AddressBookInfo> AddressBookList;
        AddressBookInfo AddressBook = new AddressBookInfo();
        public  List<AddressBookInfo> ReadFile() {
            var AddressBookjsonData = JsonConvert.DeserializeObject<AddressBookList>(AddressBookInfo);

            if (AddressBookjsonData == null)
            {
                AddressBookList = new List<AddressBookInfo>();
            }
            else
            {
                AddressBookList = AddressBookjsonData.AddressBook;
            }
            return AddressBookList;
         }
        private AddressBookInterface createAddressBook;
        private AddressBookInterface UpdateAddressBook;

        
        /// <summary>
        ///  Create A Address Book And save the Details of A Person in the File
        /// </summary>
        public void CreateAddressBooks()
        {
            try
            {
                var jsonAddressBookData = ReadFile();
                fullName = createAddressBook.FullName();
                address = createAddressBook.Address();
                city = createAddressBook.City();
                state = createAddressBook.State();
                _Mobile = createAddressBook.MobileNumber();
                _zip = createAddressBook.Zip();
                AddressBook.fullName = fullName;
                AddressBook.address = address;
                AddressBook.city = city;
                AddressBook.state = state;
                AddressBook._Mobile = _Mobile;
                AddressBook._zip = _zip;
                AddressBookOperations OPERATION = AddressBookOperations.GetAddressBookInstance;
                List<AddressBookInfo> AddressBookList = OPERATION.ReadFile();
                AddressBookList.Add(AddressBook);
                OPERATION.WriteFile();
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }
        /// <summary>
        ///  Method to Write the Address Book Content in the File
        /// </summary>
        public void WriteFile()
        {
            try
            {
                AddressBookList AddresBook = new AddressBookList()
                {
                    AddressBook = AddressBookList
                };
                string AddressBookdata = JsonConvert.SerializeObject(AddresBook);
                File.WriteAllText(AddressBookPath, AddressBookdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }
        /// <summary>
        /// Update The Address Book Content And Write it in the File
        /// </summary>
        public void UpdateAddressBooks()
        {
            try
            {
                int choice;
                bool flag;
                char input;
                int seq = 1;
                AddressBookOperations OPERATION = AddressBookOperations.GetAddressBookInstance;

                var JsonData = OPERATION.ReadFile();
                var table = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                for (int i = 0; i < JsonData.Count; i++)
                {
                    table.AddRow(seq, JsonData[i].fullName, JsonData[i].address, JsonData[i].city, JsonData[i].state, JsonData[i]._Mobile, JsonData[i]._zip);
                    seq++;
                }
                table.Write();
                Console.WriteLine();
                var SelectedRowtable = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                Console.WriteLine("Select The Record Which You Want to Update ?");
                choice = Utility.choiceValidation();
                SelectedRowtable.AddRow("1", JsonData[choice - 1].fullName, JsonData[choice - 1].address, JsonData[choice - 1].city, JsonData[choice - 1].state, JsonData[choice - 1]._Mobile, JsonData[choice - 1]._zip);
                SelectedRowtable.Write();
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Select What You want to Update");
                    Console.WriteLine("1 .Name");
                    Console.WriteLine("2 .Address");
                    Console.WriteLine("3 .City");
                    Console.WriteLine("4 .State");
                    Console.WriteLine("5 .Zip");
                    Console.WriteLine("6 .Mobile Number");
                    int select = Utility.choiceValidation();
                    switch (select)
                    {
                        case 1:
                            string name = utility.FullName();
                            JsonData[choice - 1].fullName = name;
                            break;
                        case 2:
                            string Address = utility.Addressvalidation();
                            JsonData[choice - 1].address = Address;
                            break;
                        case 3:
                            string City = utility.CityValidation();
                            JsonData[choice - 1].city = City;
                            break;
                        case 4:
                            string State = utility.StateValidation();
                            JsonData[choice - 1].state = State;
                            break;
                        case 5:
                            string Zip = utility.Zipvalidation();
                            JsonData[choice - 1]._zip = Zip;
                            break;
                        case 6:
                            string phoneNumber = utility.phoneNumber();
                            JsonData[choice - 1]._Mobile = phoneNumber;
                            break;
                        default:
                            Console.WriteLine("There is No Other Avaliable Option");
                            break;
                    }
                    Console.WriteLine("Your Information Have been Successfully updated ....... Your Updated List is Given Below ");

                    var updateedTable = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                    updateedTable.AddRow("1", JsonData[choice - 1].fullName, JsonData[choice - 1].address, JsonData[choice - 1].city, JsonData[choice - 1].state, JsonData[choice - 1]._zip, JsonData[choice - 1]._Mobile);
                    updateedTable.Write();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Your File Successfully updated....................");

                    OPERATION.WriteFile();
                    Console.WriteLine("Do You Want to Continue Y/N ?.....");
                    do
                    {
                        flag = char.TryParse(Console.ReadLine(), out input);
                        if (flag)
                            break;
                        Console.WriteLine("Enter The Valid Character !!!");
                    } while (!flag);

                } while (input.Equals('Y') || input.Equals('y'));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        /// <summary>
        /// Delete The Desire Information of the Person from Address Book And Update the File
        /// </summary>
        public void DeleteAddressBook()
        {

            try
            {
                int seq=1;
                AddressBookOperations OPERATION = AddressBookOperations.GetAddressBookInstance;
                var JsonData = OPERATION.ReadFile();
                var table = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                for (int i = 0; i < JsonData.Count; i++)
                {
                    table.AddRow(seq, JsonData[i].fullName, JsonData[i].address, JsonData[i].city, JsonData[i].state, JsonData[i]._Mobile, JsonData[i]._zip);
                    seq++;
                }
                table.Write();
                Console.WriteLine();
               
                Console.WriteLine("Select The Record Which You Want to Delete ?");
                int choice = Utility.choiceValidation();
                JsonData.RemoveAt(choice - 1);

                var UpdatedTable = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                for (int i = 0; i < JsonData.Count; i++)
                {
                    UpdatedTable.AddRow(seq, JsonData[i].fullName, JsonData[i].address, JsonData[i].city, JsonData[i].state, JsonData[i]._Mobile, JsonData[i]._zip);
                    seq++;
                }
                UpdatedTable.Write();
                Console.WriteLine();
                OPERATION.WriteFile();
                Console.WriteLine("Record Deleted SuccessFully .......");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        /// <summary>
        /// Address Book Details Sory By the User Name and update the file
        /// </summary>
        public void SortByName()
        {
            try
            {
                string TempFullName;
                string TempAddress;
                string TempZip;
                string TempMobile;
                string TempCity;
                string TempState;
                int serial = 1;
                AddressBookOperations OPERATION = AddressBookOperations.GetAddressBookInstance;
                var JsonData = OPERATION.ReadFile();
                for (int i = 0; i < JsonData.Count; i++)
                {
                    for (int j = 0; j < JsonData.Count;j++)
                    {
                        if ((JsonData[i].fullName).CompareTo(JsonData[j].fullName) < 0)
                        {
                            TempFullName = JsonData[i].fullName;
                            TempAddress = JsonData[i].address;
                            TempCity = JsonData[i].city;
                            TempState = JsonData[i].state;
                            TempZip = JsonData[i]._zip;
                            TempMobile = JsonData[i]._Mobile;

                            JsonData[i].fullName = JsonData[j].fullName;
                            JsonData[i].address = JsonData[j].address;
                            JsonData[i].city = JsonData[j].city;
                            JsonData[i].state = JsonData[j].state;
                            JsonData[i]._zip = JsonData[j]._zip;
                            JsonData[i]._Mobile = JsonData[j]._Mobile;

                            JsonData[j].fullName = TempFullName;
                            JsonData[j].address = TempAddress;
                            JsonData[j].city = TempCity;
                            JsonData[j].state = TempState;
                            JsonData[j]._zip = TempZip;
                            JsonData[j]._Mobile = TempMobile;
                        }
                    }
                }
                OPERATION.WriteFile();
                Console.WriteLine("Your Sorted Address Book By Name is");
                var UpdatedTable = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                for (int i = 0; i < JsonData.Count; i++)
                {
                    UpdatedTable.AddRow(serial, JsonData[i].fullName, JsonData[i].address, JsonData[i].city, JsonData[i].state, JsonData[i]._Mobile, JsonData[i]._zip);
                    serial++;
                }
                UpdatedTable.Write();
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Address Book Information sort By the Zip and Update the File
        /// </summary>
        public void SortByZip()
        {

            try
            {
                string TempFullName;
                string TempAddress;
                string TempZip;
                string TempMobile;
                string TempCity;
                string TempState;
                int serial = 1;
                AddressBookOperations OPERATION = AddressBookOperations.GetAddressBookInstance;
                var JsonData = OPERATION.ReadFile();
                for (int i = 0; i < JsonData.Count; i++)
                {
                    for (int j = 0; j < JsonData.Count; j++)
                    {
                        if ((JsonData[i]._zip).CompareTo(JsonData[j]._zip) <0)
                        {
                            TempFullName = JsonData[i].fullName;
                            TempAddress = JsonData[i].address;
                            TempCity = JsonData[i].city;
                            TempState = JsonData[i].state;
                            TempZip = JsonData[i]._zip;
                            TempMobile = JsonData[i]._Mobile;

                            JsonData[i].fullName = JsonData[j].fullName;
                            JsonData[i].address = JsonData[j].address;
                            JsonData[i].city = JsonData[j].city;
                            JsonData[i].state = JsonData[j].state;
                            JsonData[i]._zip = JsonData[j]._zip;
                            JsonData[i]._Mobile = JsonData[j]._Mobile;

                            JsonData[j].fullName = TempFullName;
                            JsonData[j].address = TempAddress;
                            JsonData[j].city = TempCity;
                            JsonData[j].state = TempState;
                            JsonData[j]._zip = TempZip;
                            JsonData[j]._Mobile = TempMobile;
                        }
                    }
                }
                OPERATION.WriteFile();
                Console.WriteLine("Your Sorted Address Book By Zip Is -");
                var UpdatedTable = new ConsoleTable("Seq", "Full Name", "Address", "City", "State", "Mobile Number", "Zip");
                for (int i = 0; i < JsonData.Count; i++)
                {
                    UpdatedTable.AddRow(serial, JsonData[i].fullName, JsonData[i].address, JsonData[i].city, JsonData[i].state, JsonData[i]._Mobile, JsonData[i]._zip);
                    serial++;
                }
                UpdatedTable.Write();
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

          
        }
    }
}
