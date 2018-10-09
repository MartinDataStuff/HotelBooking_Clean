using HotelBooking.UnitTests.TestDataGenerators.DateChecker;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HotelBooking.UnitTests
{
    public class DateChecker_StartDateToday_TestDataGenerator : IDateChecker_TestGenerator
    {

        private readonly List<object[]> _GetStartDateToday = new List<object[]>
        {
            new object[] { DateTime.Today, DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today, DateTime.Today.AddDays(14) },
            new object[] { DateTime.Today, DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today, DateTime.Today.AddDays(35) },
            new object[] { DateTime.Today, DateTime.Today.AddDays(37) },
            new object[] { DateTime.Today, DateTime.Today.AddDays(5) },
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _GetStartDateToday.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}