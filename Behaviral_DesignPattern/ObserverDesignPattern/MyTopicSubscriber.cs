using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern
{
    class MyTopicSubscriber : IObserver
    {
        private string name;
        private Isubject topic;
        public MyTopicSubscriber(string subscribername)
        {
            this.name = subscribername;
        }

        public void Setsubject(Isubject sub)
        {
            this.topic = sub;
        }

        public void Update()
        {
            string msg = (string)topic.getUpdate(this);
            if (msg == null)
            {
                Console.WriteLine(name + " No Consume message");
            }
            else
            {
                Console.WriteLine(name + " Consuming Msg " + msg);
            }
            
        }
    }
}
