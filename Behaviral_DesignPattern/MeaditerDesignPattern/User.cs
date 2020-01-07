using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.MeaditerDesignPattern
{
	public abstract class User
	{
		protected ChatMeaditor mediator;
		protected String name;
		public User(ChatMeaditor med, String name)
		{
			this.mediator = med;
			this.name = name;
		}
	
		public abstract void send(string msg);

		public abstract void receive(string msg);
	}
}
