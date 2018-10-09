using System;
using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using HotelBooking.UnitTests.Fakes;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class DateCheckerTests
    {
        //[Fact]
        [Theory]
        [ClassData(typeof(DateChecker_TestDataGenerator))]
        public void DateRangeIsValid_StartdateCanBeInTheFuture_ThrowsArgumentException()
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            DateTime startDate = DateTime.Now.AddDays(14);
            DateTime endDate = DateTime.Today.AddDays(21);
            //Test
            var actualResult = dc.DateRangeIsValid(startDate, endDate);
            var expectedResult = true;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DateRangeIsValid_StartdateCanBeToday_ThrowsArgumentException()
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today.AddDays(7);
            //Test
            var actualResult = dc.DateRangeIsValid(startDate, endDate);
            var expectedResult = true;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DateRangeIsValid_StartDateCannotBeInThePast_ThrowsArgumentException()
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            DateTime startDate = DateTime.Now.AddDays(-14);
            DateTime endDate = DateTime.Today.AddDays(7);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }

        [Fact]
        public void DateRangeIsValid_EndDateCannotBeBeforeStartDate_ThrowsArgumentException()
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            DateTime startDate = DateTime.Today.AddDays(21);
            DateTime endDate = DateTime.Today.AddDays(14);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }

        [Fact]
        public void DateRangeIsValid_EndDateIsNotOnStartDate_ThrowsArgumentException()
        {
            //Object to test
            DateChecker dc = new DateChecker();
            //Test parameters
            DateTime startDate = DateTime.Today.AddDays(14);
            DateTime endDate = DateTime.Today.AddDays(14);
            //Test
            Assert.Throws<ArgumentException>(() => dc.DateRangeIsValid(startDate, endDate));
        }
    }
}
