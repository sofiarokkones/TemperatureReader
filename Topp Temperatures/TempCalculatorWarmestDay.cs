using System.Collections.Generic;
using System.Linq;

namespace TempReader
{
    public class TempCalculatorWarmestDay : ITempCalculator
    {
        public TempData CalculateTempByTime(List<TempData> data)
        {
            return data.OrderByDescending(item => item.Temperature).FirstOrDefault();
        }
    }
}