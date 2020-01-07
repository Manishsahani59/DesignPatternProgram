using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternProgram.SingletonDesignPattern
{
   public class SingletonDesignpattern
    {
        public void SingleTonDesignPattern()
        {
            try
            {

                int choice;
                char input;
                bool flag;
                do
                {

                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine(" 1. Eager Intitliation");
                    Console.WriteLine(" 2. Lazy Initlization");
                    Console.WriteLine(" 3. Thread Saftry");
                    Console.WriteLine(" 4. static Block ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Enter the Your Choice");
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        if (flag)
                            break;
                        Console.WriteLine("You Enter the Wrong Input Please Enter Valid Input");
                    } while (!flag);
                    switch (choice)
                    {
                        case 1:
                            EagerSingletonDesignPattern EagerIntit = EagerSingletonDesignPattern.Getinstance;
                            EagerIntit.printmsg("Eager Intitlization");
                            break;
                        case 2:
                            LazyInitlizationSingleton lazy = LazyInitlizationSingleton.getInstance;
                            lazy.DisplayMeg("Lazy Intitlization");
                            break;
                        case 3:
                            Parallel.Invoke(
                                () => StudnetPrintDetails(),
                                () => EmployeeDetails()
                                );
                            break;
                        default:
                            Console.WriteLine("No option Avaliable");
                            break;
                    }
                    Console.WriteLine("Do You Want to Continue Y/N");
                    do
                    {
                        flag = char.TryParse(Console.ReadLine(), out input);
                        if (flag)
                            break;
                        Console.WriteLine("You Enrtered The Wrong Character");
                    } while (!flag);

                } while (input.Equals('Y') || input.Equals('y'));
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private static void EmployeeDetails()
        {
            ThreadSaftey threadItitEmployee = ThreadSaftey.Getinstance;
            threadItitEmployee.printDetails("For Employee");
        }

        private static void StudnetPrintDetails()
        {
            ThreadSaftey threadItitStudent = ThreadSaftey.Getinstance;
            threadItitStudent.printDetails("For Student");
        }
    }
}
