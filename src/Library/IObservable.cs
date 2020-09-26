using System;
using System.Text;
using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    {        
        void Subscribe(IObserver Observer);
        void Unsubscribe (IObserver Observer);

    }
}