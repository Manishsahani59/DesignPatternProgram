using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.SingletonDesignPattern
{
   public sealed  class LazyInitlizationSingleton
    {
        private static int counter = 1; 
        private static LazyInitlizationSingleton instance = null;

        public static LazyInitlizationSingleton getInstance {
            get {
                if (instance == null)
                    instance = new LazyInitlizationSingleton();
                return instance;
            }
        }

        private LazyInitlizationSingleton()
        { 
            
        }
        public static void DisplayMeg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
