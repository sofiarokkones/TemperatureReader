using System;
using System.Collections.Generic;
using System.Linq;

namespace TempReader
{
    public class TempCalculatorAverageTempDayTime : ITempAverage
    {
        private readonly TimeSpan _start;
        private readonly TimeSpan _end;
        
        public TempCalculatorAverageTempDayTime(TimeSpan start, TimeSpan end)
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
                if (-1 == TimeSpan.Compare(_start, temp.DateTime.TimeOfDay) &&
                    1 == TimeSpan.Compare(_end, temp.DateTime.TimeOfDay))
                {
                    sumTemps += temp.Temperature;
                    nbr++;
                }
            }

            return decimal.Round(sumTemps / nbr, 1);
        }
    }
}