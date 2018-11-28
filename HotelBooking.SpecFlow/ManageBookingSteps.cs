using System;
using System.Collections.Generic;
using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using Moq;
using TechTalk.SpecFlow;
using Xunit;

namespace HotelBooking.SpecFlow
{
    [Binding]
    public class ManageBookingSteps
    { //Inputs
        private int _startDate;
        private int _endDate;

        //Results
        private bool _isCreated;
        private int _roomID;
        private Exception _exception;
        private Booking _booking;
        private IList<DateTime> _dates;

        //Managers
        private readonly BookingManager bm;

        public ManageBookingSteps()
        {

            //mock repos
            var fakeRoomRepo = new Mock<IRepository<Room>>();
            var fakeBookingRepo = new Mock<IRepository<Booking>>();


            //Booking Manager instance
            bm = new BookingManager(fakeBookingRepo.Object, fakeRoomRepo.Object, new DateChecker());


            //Setup of Mock Rooms
            var rooms = new List<Room>
            {
                new Room { Id = 1, Description = "A"},
                new Room { Id = 2, Description = "B"},
                new Room { Id = 3, Description = "C"}
            };


            //Setup of Mock booking
            DateTime date = DateTime.Today.AddDays(4);
            List<Booking> bookings = new List<Booking>
            {
                new Booking { Id = 1, StartDate=DateTime.Today.AddDays(-1), EndDate=date.AddDays(15), IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id = 2, StartDate=date, EndDate=date.AddDays(15), IsActive=true, CustomerId=2, RoomId=2 },
                new Booking { Id = 3, StartDate=date, EndDate=date.AddDays(15), IsActive=true, CustomerId=1, RoomId=3 },
                new Booking { Id = 4, StartDate=date.AddDays(38), EndDate=date.AddDays(62), IsActive=true, CustomerId=1, RoomId=2 },
                new Booking { Id = 5, StartDate=date.AddDays(47), EndDate=date.AddDays(58), IsActive=true, CustomerId=2, RoomId=3 },
                new Booking { Id = 6, StartDate=date.AddDays(122), EndDate=date.AddDays(129), IsActive=true, CustomerId=2, RoomId=1 },
                new Booking { Id = 7, StartDate=date.AddDays(222), EndDate=date.AddDays(229), IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id = 8, StartDate=date.AddDays(222), EndDate=date.AddDays(229), IsActive=true, CustomerId=2, RoomId=2 },
                new Booking { Id = 9, StartDate=date.AddDays(222), EndDate=date.AddDays(229), IsActive=true, CustomerId=1, RoomId=3 }
            };

            //Unit test setup for mock data, with getall rooms
            fakeRoomRepo.Setup(x => x.GetAll()).Returns(rooms);

            //Unit test setup for mock data, with specific room.
            fakeRoomRepo.Setup(y => y.Get(2)).Returns(rooms[1]);

            //Unit test setup for mock data with getall bookings
            fakeBookingRepo.Setup(x => x.GetAll()).Returns(bookings);

            //Unit test setup for mock data with specific booking
            fakeBookingRepo.Setup(y => y.Get(2)).Returns(bookings[1]);

        }

        [Given(@"Startdate for the booking is in (.*) day")]
        public void GivenStartdateForTheBookingIsInDay(int startdate)
        {
            _startDate = startdate;
        }
        
        [Given(@"Enddate for the booking is in (.*) days")]
        public void GivenEnddateForTheBookingIsInDays(int enddate)
        {
            _endDate = enddate;
        }
        
        [Given(@"Startdate for the booking is in (.*) days")]
        public void GivenStartdateForTheBookingIsInDays(int startdate)
        {
            _startDate = startdate;
        }
        
        [Given(@"(.*) is supplied from today as startdate")]
        public void GivenIsSuppliedFromTodayAsStartdate(int startdate)
        {

            _startDate = startdate;
        }
        
        [Given(@"(.*) is also supplied from today as enddate")]
        public void GivenIsAlsoSuppliedFromTodayAsEnddate(int enddate)
        {
            _endDate = enddate;
        }
        
        [When(@"I look for a room")]
        public void WhenILookForARoom()
        {
            try
            {
                _roomID = bm.FindAvailableRoom(DateTime.Today.AddDays(_startDate), DateTime.Today.AddDays(_endDate));
            }
            catch (Exception e)
            {
                ScenarioContext.Current[("Error")] = e;
                //_exception = e;
            }
        }

        //[Then(@"I should a room ID that is not (.*)")]
        //public void ThenIShouldARoomIDThatIsNot(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}


        [When(@"I book a room")]
        public void WhenIBookARoom()
        {
            _booking = new Booking
            {
                Id = 1,
                StartDate = DateTime.Today.AddDays(_startDate),
                EndDate = DateTime.Today.AddDays(_endDate),
                CustomerId = 1,
                IsActive = false
            };

            _isCreated = bm.CreateBooking(_booking);
        }
        
        [When(@"I look for fully booked dates")]
        public void WhenILookForFullyBookedDates()
        {
            _dates=bm.GetFullyOccupiedDates(DateTime.Today.AddDays(_startDate), DateTime.Today.AddDays(_endDate));
        }
        
        [Then(@"I should get an error")]
        public void ThenIShouldGetAnError()
        {
            Assert.True(ScenarioContext.Current.ContainsKey("Error"));
            //Assert.NotNull(_exception);
        }

        [Then(@"I should get a room ID")]
        public void ThenIShouldGetARoomID()
        {
            Assert.NotEqual(-1, _roomID); ;
        }
        
        [Then(@"I should get (.*) instead of a legit room ID")]
        public void ThenIShouldGetInsteadOfALegitRoomID(int badNumber)
        {
            Assert.NotEqual(badNumber, _roomID);
        }

        [Then(@"I should get (.*) as a room ID")]
        public void ThenIShouldGetAsARoomID(int badNumber)
        {
            Assert.Equal(badNumber, _roomID); ;
        }


        [Then(@"return whether the booking is (.*)")]
        public void ThenReturnWhetherTheBookingIsTrue(bool isValid)
        {
            Assert.Equal(isValid, _isCreated);
        }
        
        [Then(@"The booking should be active")]
        public void ThenTheBookingShouldBeActive()
        {
            Assert.True(_booking.IsActive);
        }
        
        [Then(@"a list of fully occupied dates should be given")]
        public void ThenAListOfFullyOccupiedDatesShouldBeGiven()
        {
            Assert.Equal(16,_dates.Count);
        }

        [Then(@"a list of (.*) dates should be given")]
        public void ThenAListOfTrueDatesShouldBeGiven(bool FoundAnyFullyOccupiedDates)
        {
            if (FoundAnyFullyOccupiedDates)
            {
                Assert.NotEmpty(_dates);
            }
            else if (!FoundAnyFullyOccupiedDates) {
                Assert.Empty(_dates);
            }
        }


        [Then(@"an empty list of dates should be returned")]
        public void ThenAnEmptyListOfDatesShouldBeReturned()
        {
            //Assert.Equal(0, _dates.Count);
            Assert.Empty(_dates);
        }

        [Then(@"an empty list of dates shouldnt be returned")]
        public void ThenAnEmptyListOfDatesShouldntBeReturned()
        {
            Assert.NotEmpty(_dates);
        }

        [Then(@"I should get a room ID that is not (.*)")]
        public void ThenIShouldGetARoomIDThatIsNot(int wrongRoomID)
        {
            Assert.NotEqual(_roomID, wrongRoomID);
        }


    }
}
