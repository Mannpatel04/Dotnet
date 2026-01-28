using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{


    class TemperatureSensor
    {
        private double absoluteTempareture = -273.15;

        private double currentTemp;
        private readonly List<double> temparatureHistory = new List<double>();

        public double temparature
        {
           get { return absoluteTempareture; }
            set
            {
                if(value < absoluteTempareture)
                {
                    Console.WriteLine("Error: Temperature cannot be below absolute zero.");
                    return;
                }
                currentTemp = value;
                temparatureHistory.Add(currentTemp);
            }

        }

        public IReadOnlyList<double> TemperatureHistory
        {
            get { return temparatureHistory.AsReadOnly(); }
        }

    }
    
    class Ass1
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.temparature = 25;
            sensor.temparature = 100;
            sensor.temparature = 75; 
            sensor.temparature = 0;

            Console.WriteLine("Temperature History:");
            foreach (var temp in sensor.TemperatureHistory)
            {
                Console.WriteLine(temp);
            }

        }
    }
}
