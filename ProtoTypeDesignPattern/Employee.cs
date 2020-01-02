using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.ProtoTypeDesignPattern
{
    public class Employee:ICloneable
    {
        private List<string> emplist;
        public Employee()
        {
            emplist = new List<string>();
        }
        public Employee(List<string> list)
        {
            this.emplist = list;
        }

        public void LodaData()
        {
            emplist.Add("jhon");
            emplist.Add("Manish");
            emplist.Add("Nitin");
            emplist.Add("Rahul");
            emplist.Add("Dinesh");
        }
        
        public List<string> GetList(){ 
        return emplist;
        }
        public void ShowList()
        {
            foreach (string s in GetList())
            {
                Console.Write(s+"\t");
            }
            Console.WriteLine();
        }

        public object  Clone()
        {
            List<string> temp = new List<string>();
            foreach (string s in GetList())
            {
                temp.Add(s);
            }
           return new Employee(temp);
        }
    }
}
