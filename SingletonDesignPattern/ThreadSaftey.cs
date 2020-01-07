using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.SingletonDesignPattern
{
    class ThreadSaftey
    {
        private static int counter =1;
        private static ThreadSaftey instance;
        private static readonly object obj = new object();

        public static ThreadSaftey Getinstance
        {
            get{
                lock(obj){
                    if (instance == null)
                       instance = new ThreadSaftey();
                       }
                
                return instance;
            }   
        }

        private ThreadSaftey()
        {
          
            Console.WriteLine(" Value of Counter is " + counter.ToString());
            counter++;

        }

        public void printDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
