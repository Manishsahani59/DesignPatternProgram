using System;
using System.Collections.Generic;
using DesignPatternProgram.FactoryDesignPattern;
using DesignPatternProgram.ProtoTypeDesignPattern;

namespace DesignPatternProgram.FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        { bool flag;
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
