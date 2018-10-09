using HotelBooking.UnitTests.TestDataGenerators.DateChecker;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HotelBooking.UnitTests
{
    public class DateChecker_ValidDates_TestDataGenerator : IDateChecker_TestGenerator
    {
        private readonly List<object[]> _GetValidDates = new List<object[]>
        {
            new object[] { DateTime.Today.AddDays(14), DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today.AddDays(7), DateTime.Today.AddDays(14) },
            new object[] { DateTime.Today.AddDays(14), DateTime.Today.AddDays(21) },
            new object[] { DateTime.Today.AddDays(15), DateTime.Today.AddDays(35) },
            new object[] { DateTime.Today.AddDays(7), DateTime.Today.AddDays(12) },
            new object[] { DateTime.Today.AddDays(15), DateTime.Today.AddDays(35) },
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _GetValidDates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}