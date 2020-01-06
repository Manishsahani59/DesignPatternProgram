using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern
{
    class MyTpoic : Isubject
    {
        private List<IObserver> observer;
        private bool changed;
        private string Message;

        public MyTpoic()
        {
            observer = new List<IObserver>();
        }
        public object getUpdate(IObserver obj)
        {
            return this.Message;
        }

        public void Notify()
        {
            foreach (IObserver observers in observer)
            {
                observers.Update();
            }
        }

        public void Register(IObserver obj)
        {
            observer.Add(obj);
        }

        public void unRegister(IObserver obj)
        {
            observer.Remove(obj);
        }

        public void PostMesage(string msg)
        {
            Console.WriteLine("Message Post to topic " +msg);
            this.Message = msg;
            this.changed = true;
            Notify();
        }
    }
}
