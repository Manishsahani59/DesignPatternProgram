using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.StructuralDesignPattern.FacadeDesignPattern
{
  public sealed  class FacadePatternClient
    {
        private static int counter;
        ShopKeepar _shopKeepear = new ShopKeepar();
        private static readonly FacadePatternClient FacadeInstance = new FacadePatternClient();
        public static FacadePatternClient GetFacedeInstance{
            get {
                return FacadeInstance;
            }
        }
        private FacadePatternClient()
        {
            Console.WriteLine(counter);
            counter++;
        }


        public void FacadeDesignPatternClinet()
        {
            try
            {
                int choice;
                do {
                    Console.WriteLine("__________________________________________________________");
                    Console.WriteLine("1 . iPhone");
                    Console.WriteLine("2 . Samsung");
                    Console.WriteLine("3 . BlackBerry");
                    Console.WriteLine("4 . Exit");
                    Console.WriteLine("__________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Select The Mobile");
                    choice= Utility.choiceValidation();
                    switch (choice)
                    {
                        case 1:
                            _shopKeepear.IphoneSale();
                            break;
                        case 2:
                            _shopKeepear.SamsungSale();
                            break;
                        case 3:
                            _shopKeepear.BlackberrySale();
                            break;
                        case 4:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine(" I Have No Product To Shell");
                            break;
                    }

                } while (choice!=4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
