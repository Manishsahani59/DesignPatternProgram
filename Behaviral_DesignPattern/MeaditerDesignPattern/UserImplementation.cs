using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern
{
    public class UserImplementation : User
    {
     
        public UserImplementation(ChatMeaditor med, String name) : base(med, name) {
           // Console.Write(name + "\t");
        }
        
        
        public override void receive(string msg)
        {
            Console.WriteLine(this.name + " :: Recieving Message =" + msg);
                 
        }

        public override void send(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(); 
            Console.WriteLine(name + " :: Sending Message = " +msg);
            Console.ForegroundColor = ConsoleColor.Red;
            mediator.sendMessage(msg, this);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
