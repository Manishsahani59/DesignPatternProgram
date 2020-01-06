using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern
{
   public interface ChatMeaditor
    {
        public void sendMessage(string msg, User user);
       public void addUser(User user);
    }
}
