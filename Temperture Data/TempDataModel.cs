using System;

namespace TempReader
{
    public class TempData
    {
        public int TimeUnixEpoch { get; set; }
        public decimal Temperature { get; set; }
        public DateTime DateTime { get; set; }

        public static TempData FromCsv(string csvLine)
        {
            var values = csvLine.Split(';');
            var tempData = new TempData
            {
                TimeUnixEpoch = Convert.ToInt32(values[0]),
                Temperature = Convert.ToDecimal(values[1]),
                DateTime = Convert.ToDateTime(values[2])
            };
            
            return tempData;
        }
    }
}