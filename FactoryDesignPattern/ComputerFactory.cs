using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.FactoryDesignPattern
{
    class ComputerFactory
    {
        public static Computer getComputer(string Type, string Ram, string Rom, string HDD)
        {
            if ("PC".ToUpper().Equals(Type)) 
                return new PC(Ram, Rom, HDD);
            else if ("Server".Equals(Type))
                    return new Server(Ram, Rom, HDD);
            else
            return null;

        }
    }
}
