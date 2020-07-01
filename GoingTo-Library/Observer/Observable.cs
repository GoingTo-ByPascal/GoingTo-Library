using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.Observer
{
    public interface IObservable
    {
        void RegisterObserver(IObserver Observer);
        void RemoveObserver(IObserver Observer);
        void NotifyObservers();
    }
}
