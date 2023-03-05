using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern.Abstracts;
using Observer_Pattern.Subjects;

namespace Observer_Pattern.Observers
{
    class CurrentConditionsDisplay : IObserver
    {
        private WheatherData wheatherData;
        private WheatherDataSubject wheatherDataSubject;

        public CurrentConditionsDisplay(WheatherDataSubject wds)
        {
            this.wheatherDataSubject = wds;
            Subscribe();
        }

        public void Subscribe()
        {
            wheatherDataSubject.RegisterObserver(this);
        }

        public void UnSubscribe()
        {
            wheatherDataSubject.RemoveObserver(this);
        }

        public void Update(WheatherData data)
        {
            this.wheatherData = data;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions are : " + this.wheatherData.Temperature + " : " + this.wheatherData.Humidity + " : " + this.wheatherData.Pressure);
        }
    }
}
