using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternProgram.FactoryDesignPattern;

namespace DesignPatternProgram.FactoryDesignPattern
{
    public class PC : Computer
    {
       private string Ram;
       private string Rom;
       private string HDD;

        public PC(string Ram, string Rom, string HDD)
        {
            this.Ram = Ram;
            this.Rom = Rom;
            this.HDD = HDD;
        }

        public override string getHDD()
        {
            return this.HDD;
        }

        public override string getRam()
        {
            return this.Ram;
        }

        public override string getRom()
        {
           return this.Rom;
        }
    }
}
