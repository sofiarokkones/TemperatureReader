using System;
using System.Collections.Generic;
using System.Linq;

namespace TempReader
{
    public class TempCalculatorAverageTemp :ITempAverage
    {
        public decimal CalculateTempByTime(List<TempData> data)
        {
            return decimal.Round(data.Sum(t => t.Temperature) / data.Count, 1);
        }
    }
}