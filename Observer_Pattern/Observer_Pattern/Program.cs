using System;
using Observer_Pattern.Observers;
using Observer_Pattern.Subjects;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WheatherDataSubject wheatherDataSubject = new WheatherDataSubject();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wheatherDataSubject);
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(wheatherDataSubject);
            wheatherDataSubject.SetMeasurements(10, 20, 30);
            wheatherDataSubject.SetMeasurements(20, 20, 60);
            Console.ReadLine();
        }
    }
}
