using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern.Abstracts;
using Observer_Pattern.Subjects;

namespace Observer_Pattern.Observers
{
    class StatisticsDisplay : IObserver
    {
        private WheatherData wheatherData;
        private WheatherDataSubject wheatherDataSubject;

        public StatisticsDisplay(WheatherDataSubject wds)
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
            Console.WriteLine("Tempearture : " + this.wheatherData.Temperature + " Humidity : " + this.wheatherData.Humidity + " Pressure : " + this.wheatherData.Pressure);
        }
    }
}
