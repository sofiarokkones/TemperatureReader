using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TempReader
{
    public interface ITempCalculator
    {
        TempData CalculateTempByTime(List<TempData> data);
    }
}