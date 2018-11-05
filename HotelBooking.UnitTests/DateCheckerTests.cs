using System;
using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using HotelBooking.UnitTests.Fakes;
using HotelBooking.UnitTests.TestDataGenerators.DateChecker;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class DateCheckerTests
    {
        //[Fact]
        [Theory]
        [ClassData(typeof(DateChecker_ValidDates_TestDataGenerator))]
        public void DateRangeIsValid_StartdateCanBeInTheFuture_ThrowsArgumentException(DateTime startDate, DateTime endDate)
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            //DateTime startDate = DateTime.Now.AddDays(14);
            //DateTime endDate = DateTime.Today.AddDays(21);
            //Test
            var actualResult = dc.DateRangeIsValid(startDate, endDate);
            var expectedResult = true;
            Assert.Equal(expectedResult, actualResult);
        }

        //[Fact]

        [Theory]
        [ClassData(typeof(DateChecker_StartDateToday_TestDataGenerator))]
        public void DateRangeIsValid_StartdateCanBeToday_ThrowsArgumentException(DateTime startDate, DateTime endDate)
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            //DateTime startDate = DateTime.Today;
            //DateTime endDate = DateTime.Today.AddDays(7);
            //Test
            var actualResult = dc.DateRangeIsValid(startDate, endDate);
            var expectedResult = true;
            Assert.Equal(expectedResult, actualResult);
        }

        //[Fact]
        [Theory]
        [ClassData(typeof(DateChecker_StartDateInPast_TestDataGenerator))]
        public void DateRangeIsValid_StartDateCannotBeInThePast_ThrowsArgumentException(DateTime startDate, DateTime endDate)
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            //DateTime startDate = DateTime.Now.AddDays(-14);
            //DateTime endDate = DateTime.Today.AddDays(7);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }

        //[Fact]
        [Theory]
        [ClassData(typeof(DateChecker_EndDatesBeforeStartDates_TestDataGenerator))]
        public void DateRangeIsValid_EndDateCannotBeBeforeStartDate_ThrowsArgumentException(DateTime startDate, DateTime endDate)
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            //DateTime startDate = DateTime.Today.AddDays(21);
            //DateTime endDate = DateTime.Today.AddDays(14);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }

        //[Fact]
        [Theory]
        [ClassData(typeof(DateChecker_StartDateEqualToEndDate_TestDataGenerator))]
        public void DateRangeIsValid_EndDateIsNotOnStartDate_ThrowsArgumentException(DateTime startDate, DateTime endDate)
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            //DateTime startDate = DateTime.Today.AddDays(14);
            //DateTime endDate = DateTime.Today.AddDays(14);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }
    }
}
