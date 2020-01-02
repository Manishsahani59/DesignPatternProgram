using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.ProtoTypeDesignPattern
{
   public sealed class PrototypeDesignPattren
    {
        private static int counter = 1;
        private static readonly PrototypeDesignPattren instance = new PrototypeDesignPattren();
        /// <summary>
        /// Eager Initlization Singleton Design Pattern
        /// </summary>
        public static PrototypeDesignPattren GetInstance {
            get {
                return instance;
            }
        }
        private PrototypeDesignPattren()
        {
            
            Console.WriteLine(counter);
            counter++;
        }

        public void protoTypeDesignPattern()
        {
            Employee employees = new Employee();
            employees.LodaData();
            Employee newEmployees = (Employee)employees.Clone();
            Employee RemoveEmployees = (Employee)employees.Clone();
            List<string> AddEmployee = newEmployees.GetList();
            AddEmployee.Add("Hurry");            
            List<string> deleteEmployee = RemoveEmployees.GetList();
            deleteEmployee.Remove("Manish");
            Console.WriteLine("The Original Employee List is");
            employees.ShowList();
            Console.WriteLine("Add New Employee list ");
            newEmployees.ShowList();
            Console.WriteLine("Remove one Employee list");
            RemoveEmployees.ShowList();
        }


        public void Display()
        {
            Console.WriteLine("Hello World");
        }



    }
}
