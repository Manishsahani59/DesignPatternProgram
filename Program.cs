using System;
using System.Collections.Generic;
using DesignPatternProgram.FactoryDesignPattern;
using DesignPatternProgram.ProtoTypeDesignPattern;
using DesignPatternProgram.StructuralDesignPattern.AdapterDesignPattern;
using DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern;
using DesignPatternProgram.StructuralDesignPattern.FacadeAddressBookProblem;
using DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern;
using DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern;
using DesignPatternProgram.StructuralDesignPattern.ProxyDesignPattern;
using DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern;
using DesignPatternProgram.SingletonDesignPattern;







namespace DesignPatternProgram.FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int choice;
            char input;
            do
            {
                try
                {
                    Console.WriteLine("______________________________  Design Patterns ________________________________");
                    Console.WriteLine();
                    Console.WriteLine("1 Factory Design Pattern For Computer");
                    Console.WriteLine("2 Prototype Design Pattern");
                    Console.WriteLine("3 Structural Design Pattern // Adapter Design Pattern");
                    Console.WriteLine("4 Facade Design Pattern");
                    Console.WriteLine("5 Address Book");
                    Console.WriteLine("6 Proxy Design Pattern");
                    Console.WriteLine("7 Observer Design pattern");
                    Console.WriteLine("8 Meaditor Design Pattern");
                    Console.WriteLine("9 Visitor Design patten");
                    Console.WriteLine("10 Singleton Design Pattern");
                    Console.WriteLine("_________________________________________________________________________________");
                    Console.WriteLine("Enter Your Choice ?...");
                    Console.WriteLine();
                    choice = Utility.choiceValidation();
                    switch (choice)
                    {
                        case 1:
                            Computer Server = ComputerFactory.getComputer("Server", "2GD", "500GB", "3.5GHz");
                            Computer PC = ComputerFactory.getComputer("PC", "5GB", "1000GB", "2.5GHz");
                            Console.WriteLine("Factory Type Server " + Server);
                            Console.WriteLine("Factory Type PC " + PC);
                           
                            break;
                        case 2:
                            PrototypeDesignPattren prototype = PrototypeDesignPattren.GetInstance;
                            prototype.protoTypeDesignPattern();
                            break;
                        case 3:
                            AdapterClass Adapter = new AdapterClass();
                            Adapter.Apdapterclass();
                            break;
                        case 4:
                            FacadePatternClient instance = FacadePatternClient.GetFacedeInstance;
                            instance.FacadeDesignPatternClinet();
                            break;
                        case 5:
                            FacadeAddressBook AddreddBook = FacadeAddressBook.GetFacadeAddressBook;
                            AddreddBook.FacadeAddressBookPattern();
                            break;
                        case 6:
                            OfficeInterNetAccess ProxyDP = new ProxyInternetaccess("Ashwani Rajput");
                            ProxyDP.GrantInterNetAccess();
                            break;
                        case 7:
                            ObserverDesignPatternTest observer = new ObserverDesignPatternTest();
                            observer.ObserverDesigntest();
                            break;
                        case 8:
                            ChatmeaditoDemo demo = new ChatmeaditoDemo();
                            demo.chatMedaitordemo();
                            break;
                        case 9:
                            ShoppingCartClient VisitorDPDemo = new ShoppingCartClient();
                            VisitorDPDemo.VisitorPattern();
                            break;
                        case 10:
                            SingletonDesignpattern singleton = new SingletonDesignpattern();
                            singleton.SingleTonDesignPattern();
                            break;
                        default:
                            Console.WriteLine("You Entered The Wrong Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                Console.WriteLine("Do You Want to Continue Y/N");
                input = Utility.CharValidation();
            } while (input.Equals('y') || input.Equals('Y'));
        }
    }
}