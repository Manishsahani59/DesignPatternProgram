using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.FactoryDesignPattern
{
    public abstract class Computer
    {

        public abstract String getRam();
        public abstract String  getRom();
        public abstract String getHDD();


       public override string ToString()
        {
           return "RAM = \t" + this.getRam() + ", ROM \t" + this.getRom() + ", HardDisk " + this.getHDD();
        }
    }
}
