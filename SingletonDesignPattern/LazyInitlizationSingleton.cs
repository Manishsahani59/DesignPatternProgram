using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.SingletonDesignPattern
{
   public sealed  class LazyInitlizationSingleton
    {
        private static int counter = 1;
        private static readonly Lazy<LazyInitlizationSingleton> instance = new Lazy<LazyInitlizationSingleton>();

        public static LazyInitlizationSingleton getInstance {
            get {
                return instance.Value;
            }
        }

        public LazyInitlizationSingleton()
        { 
            
        }
        public void DisplayMeg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
