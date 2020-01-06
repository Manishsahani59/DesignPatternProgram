using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern
{
    class ChatmeaditoDemo
    {
        public void chatMedaitordemo()
        {
			ChatMeaditor mediator = new chatMediaterImplementation();
			User user1 = new UserImplementation(mediator, "Pankaj");
			User user2 = new UserImplementation(mediator, "Lisa");
			User user3 = new UserImplementation(mediator, "Saurabh");
			User user4 = new UserImplementation(mediator, "David");
			mediator.addUser(user1);
			mediator.addUser(user2);
			mediator.addUser(user3);
			mediator.addUser(user4);
			user1.send("Hi All");
			
		}
    }
}
