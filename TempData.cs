using System;

namespace TempReader
{
    class TempData
    {
        public int Id { get; private set; }
        public decimal Temperature { get; private set; }
        public DateTime DateTime { get; private set; }

        public static TempData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            TempData tempData = new TempData();
            
            tempData.Id = Convert.ToInt32(values[0]);
            tempData.Temperature = Convert.ToDecimal(values[1]);
            tempData.DateTime = Convert.ToDateTime(values[2]);

            return tempData;
        }
    }
}