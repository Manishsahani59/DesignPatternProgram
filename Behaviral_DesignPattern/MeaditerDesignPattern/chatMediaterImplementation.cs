using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern
{
   public class chatMediaterImplementation:ChatMeaditor
    {
        private List<User> users;
        public chatMediaterImplementation()
        {
            users = new List<User>();
        }
        public void addUser(User user)
        {
            this.users.Add(user);
        }

        void ChatMeaditor.sendMessage(string msg, User user)
        {
            foreach (User u in users)
            {
                if (u != user)
                {
                    u.receive(msg);
                }
                
            }
        }

    }
}
