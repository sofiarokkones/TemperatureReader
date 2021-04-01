using System;
using System.Collections.Generic;

namespace TempReader
{
    public interface ITempAverage
    {
        decimal CalculateTempByTime(List<TempData> data);
    }
}