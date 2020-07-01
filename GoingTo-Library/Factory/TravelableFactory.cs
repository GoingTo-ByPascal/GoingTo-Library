using GoingTo_Library.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.Factory
{
    public abstract class TravelableFactory<T>
    {
        public abstract Travelable CreateTravelable(T t);
    }
}
