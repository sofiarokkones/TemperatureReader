using System;
using System.Collections.Generic;
using NUnit.Framework;
using TempReader;

namespace TempReaderTest
{
    public class AverageTempTest
    {
        private ITempAverage _tempCal;
        private List<TempData> _testTempData;
        
        [SetUp]
        public void Setup()
        {
            _testTempData = new List<TempData>
            {
                new TempData
                {
                    DateTime = new DateTime(2021,03,29, 08,08,08),
                    Temperature = 2,
                },
                new TempData
                {
                    DateTime = new DateTime(2021,03,30, 09,09,09),
                    Temperature = 10,
                },
                new TempData
                {
                    DateTime = new DateTime(2021,03,31, 09,09,09),
                    Temperature = 6,
                },
                new TempData
                {
                    DateTime = new DateTime(2021,04,1, 00,10,10),
                    Temperature = 4,
                }
            };
        }

        [Test]
        public void Should_be_correct_calculation_of_average_temp()
        {
            _tempCal =  new TempCalculatorAverageTemp();
            var result = _tempCal.CalculateTempByTime(_testTempData);

            Assert.AreEqual(5.5, result);
        }
        
        [Test]
        public void Should_be_correct_calculation_of_average_day_temp()
        {
            var dayStart = new TimeSpan(8, 0, 0);
            var dayEnd = new TimeSpan(17, 0, 0);
            
            _tempCal =  new TempCalculatorAverageTempDayTime(dayStart,dayEnd);
            var result = _tempCal.CalculateTempByTime(_testTempData);
            
            Assert.AreEqual(6, result);
        }
        
        [Test]
        public void Should_be_correct_calculation_of_average_night_temp()
        {
            var nightStart = new TimeSpan(0, 0, 0);
            var nightEnd = new TimeSpan(5, 0, 0);
            
            _tempCal = new TempCalculatorAverageTempNightTime(nightStart,nightEnd);
            var result = _tempCal.CalculateTempByTime(_testTempData);
            
            Assert.AreEqual(4, result);
        }
    }
}