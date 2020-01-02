using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.SingletonDesignPattern
{
    public sealed class EagerSingletonDesignPattern
    {
        private static int counter = 1;
          private static readonly EagerSingletonDesignPattern instance = new EagerSingletonDesignPattern();

        private EagerSingletonDesignPattern()
        {
            Console.WriteLine("The value  " + counter.ToString());
            counter++;
        }

           public static EagerSingletonDesignPattern Getinstance
           {
               get
               {
                   return instance;
               }
           }
          
    
        public void printmsg(string msg)
        {
            Console.WriteLine(msg);
        }
        
    

    }
}
