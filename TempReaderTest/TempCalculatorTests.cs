using System;
using System.Collections.Generic;
using NUnit.Framework;
using TempReader;

namespace TempReaderTest
{
    public class TempCalculatorTests
    {
        private ITempCalculator _tempCal;
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
        public void Should_be_correct_calculation_of_warmest_day()
        {
            _tempCal =  new TempCalculatorWarmestDay();
            var result = _tempCal.CalculateTempByTime(_testTempData);
            Assert.AreEqual(10, result.Temperature);
            Assert.AreEqual( new DateTime(2021,03,30, 09,09,09), result.DateTime);
        }
        
        [Test]
        public void Should_be_correct_calculation_of_coldest_day()
        {
            _tempCal =  new TempCalculatorColdestDay();
            var result = _tempCal.CalculateTempByTime(_testTempData);
            Assert.AreEqual(2, result.Temperature);
            Assert.AreEqual( new DateTime(2021,03,29, 08,08,08), result.DateTime);
        }
    }
}