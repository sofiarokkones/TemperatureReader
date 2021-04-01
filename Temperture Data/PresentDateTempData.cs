namespace TempReader
{
    public static class PresentDateTempData
    {
        public static string PresentData(TempData data, ITempCalculator cal)
        {
            switch (cal)
            {
                case TempCalculatorWarmestDay _:
                    return
                        $"WARMEST temperature: {data.Temperature} °C - measured {data.DateTime.Date:dddd, dd MMMM yyyy} at {data.DateTime.TimeOfDay}.";
                case TempCalculatorColdestDay _:
                    return
                        $"COLDEST temperature: {data.Temperature} °C - measured {data.DateTime.Date:dddd, dd MMMM yyyy} at {data.DateTime.TimeOfDay}.";
                default:
                    return "";
            }
        }

        public static string PresentAverageData(decimal data, ITempAverage typeOfAverage)
        {
            switch (typeOfAverage)
            {
                case TempCalculatorAverageTemp _:
                    return $"Average temperature of the data set: {data} °C.";
                case TempCalculatorAverageTempDayTime _:
                    return $"Average DAY temperature: {data} °C.";
                case TempCalculatorAverageTempNightTime _:
                    return $"Average NIGHT temperature: {data} °C.";
                default:
                    return "";
            }
        }
        
    }
}