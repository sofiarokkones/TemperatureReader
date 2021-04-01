using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TempReader
{
    public class ReadTempData
    {
        public List<TempData> Read(string file)
        {
            return File.ReadAllLines(file)
                .Select(v => TempData.FromCsv(v))
                .ToList();
        }
    }
}