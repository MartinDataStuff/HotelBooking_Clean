using HotelBooking.UnitTests.TestDataGenerators.DateChecker;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HotelBooking.UnitTests
{
    public class DateChecker_EndDatesBeforeStartDates_TestDataGenerator : IDateChecker_TestGenerator
    {

        private readonly List<object[]> _GetEndDatesBeforeStartDates = new List<object[]>
        {
            new object[] { DateTime.Today.AddDays(45), DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today.AddDays(56), DateTime.Today.AddDays(14) },
            new object[] { DateTime.Today.AddDays(76), DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today.AddDays(54), DateTime.Today.AddDays(35) },
            new object[] { DateTime.Today.AddDays(78), DateTime.Today.AddDays(37) },
            new object[] { DateTime.Today.AddDays(8), DateTime.Today.AddDays(5) },
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _GetEndDatesBeforeStartDates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}