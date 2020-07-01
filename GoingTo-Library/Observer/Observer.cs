using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.Observer
{
    public interface IObserver
    {
        void Update(object Target);
        void StartListening(IObservable Server);
        void StopListening();
    }
}
