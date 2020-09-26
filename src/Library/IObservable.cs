using System;
using System.Text;
using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    {        
        void Suscribirme(IObserver Observer);
        void Desuscribirse (IObserver Observer);

    }
}