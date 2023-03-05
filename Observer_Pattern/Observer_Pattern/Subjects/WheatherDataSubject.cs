using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern.Abstracts;
using Observer_Pattern.Observers;

namespace Observer_Pattern.Subjects
{
    public class WheatherDataSubject
    {
        private WheatherData wheatherData= null;
        private IList<IObserver> observers = null;

        public WheatherDataSubject()
        {
            wheatherData = new WheatherData();
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(decimal temp, decimal humidity, decimal pressure)
        {
            this.wheatherData.Temperature = temp;
            this.wheatherData.Humidity = humidity;
            this.wheatherData.Pressure = pressure;
            this.MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            foreach(var observer in observers)
            {
                observer.Update(this.wheatherData);
            }
        }
    }
}
