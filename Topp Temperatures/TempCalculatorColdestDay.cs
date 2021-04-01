using System.Collections.Generic;
using System.Linq;

namespace TempReader
{
    public class TempCalculatorColdestDay : ITempCalculator
    {
        public TempData CalculateTempByTime(List<TempData> data)
        {
            return data.OrderBy(item => item.Temperature).FirstOrDefault();
        }
    }
}