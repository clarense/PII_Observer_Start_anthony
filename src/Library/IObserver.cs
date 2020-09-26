using Observer;
using System;
using System.Text;
using System.Collections.Generic;


namespace Observer
{
    public interface IObserver
    {
        void Actualizar(Temperature temperature);
    }
}