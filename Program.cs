using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TempReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"/Users/sofia.rokkones/Projects/Code Is King/temperatures.csv";

            List<TempData> data = File.ReadAllLines(file)
                .Select(v => TempData.FromCsv(v))
                .ToList();
        }
    }
}