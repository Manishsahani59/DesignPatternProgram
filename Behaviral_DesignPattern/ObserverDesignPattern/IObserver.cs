using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProgram.Behaviral_DesignPattern.ObserverDesignPattern
{
    interface IObserver
    {
        public void Update();
        public void Setsubject(Isubject sub);
    }
}
