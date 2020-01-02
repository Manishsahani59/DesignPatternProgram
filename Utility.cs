using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram
{
   public class Utility
    {
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
    }
}
