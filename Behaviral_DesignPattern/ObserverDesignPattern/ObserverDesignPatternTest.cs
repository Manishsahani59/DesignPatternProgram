using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern
{
    class ObserverDesignPatternTest
    {

        public void ObserverDesigntest()
        {
            MyTpoic mytopic = new MyTpoic();
            IObserver obj1 = new MyTopicSubscriber("A");
            IObserver obj2 = new MyTopicSubscriber("B");
            IObserver obj3 = new MyTopicSubscriber("C");
            mytopic.Register(obj1);
            mytopic.Register(obj2);
            mytopic.Register(obj3);

            obj1.Setsubject(mytopic);
            obj2.Setsubject(mytopic);
            obj3.Setsubject(mytopic);
            obj1.Update();
            mytopic.PostMesage("Tom & Jerry New Vidoes");
        }
    }
}
