using System;
using System.Collections.Generic;

namespace TempReader
{
    public class TempCalculatorAverageTempNightTime : ITempAverage
    {
        private readonly TimeSpan _start;
        private readonly TimeSpan _end;
        
        public TempCalculatorAverageTempNightTime(TimeSpan start, TimeSpan end)
        {
            _start = start;
            _end = end;
        }                                                                     
        public decimal CalculateTempByTime(List<TempData> data)
        {
            decimal sumTemps = 0;
            var nbr = 0;
            
            foreach (var temp in data)
            {
                if (-1 == TimeSpan.Compare(_start,temp.DateTime.TimeOfDay) && 1 == TimeSpan.Compare(_end, temp.DateTime.TimeOfDay) )
                {
                    sumTemps += temp.Temperature;
                    nbr++;
                }
            }
            return decimal.Round(sumTemps / nbr, 1);                         
        }                                                                                            
    }
}