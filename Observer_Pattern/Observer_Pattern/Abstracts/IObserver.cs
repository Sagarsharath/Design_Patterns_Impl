using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern.Abstracts;

namespace Observer_Pattern.Observers
{
    public interface IObserver
    {
        void Subscribe();
        void UnSubscribe();
        void Update(WheatherData data);

    }
}
