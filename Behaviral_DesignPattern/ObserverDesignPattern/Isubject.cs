using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern
{
   interface Isubject
    {
        public void Register(IObserver obj);
        public void unRegister(IObserver obj);
        public void Notify();
        public object getUpdate(IObserver obj);
    }
}
