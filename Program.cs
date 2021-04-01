using System;
using System.Collections.Generic;

namespace TempReader
{
    static class Program
    {
        static void Main(string[] args)
        {
            var data = new ReadTempData().Read(@"/Users/sofia.rokkones/Projects/Code Is King/temperatures.csv");

            var tempCalculations = new List<ITempCalculator>
            {
                new TempCalculatorWarmestDay(), 
                new TempCalculatorColdestDay()
            };
            var averageTempCalculations = new List<ITempAverage>
            {
                new TempCalculatorAverageTemp(),
                new TempCalculatorAverageTempDayTime(new TimeSpan(8, 0, 0), new TimeSpan(17, 0, 0)),
                new TempCalculatorAverageTempNightTime(new TimeSpan(0, 0, 0), new TimeSpan(5, 0, 0))
            };
            
            
            foreach (var cal in tempCalculations)
            {
                Console.WriteLine(PresentDateTempData.PresentData(cal.CalculateTempByTime(data), cal));
            }
            foreach (var cal in averageTempCalculations)
            {
                Console.WriteLine(PresentDateTempData.PresentAverageData(cal.CalculateTempByTime(data), cal));
            }
        }
    }
}