using System;
using System.Collections.Generic;
using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using HotelBooking.UnitTests.Fakes;
using Moq;
using TechTalk.SpecFlow;
using Xunit;

namespace HotelBooking.SpecFlow
{
    [Binding]
    public class ManageBookingSteps
    {
        //Inputs
        private int _startDate;
        private int _endDate;

        //Results
        private bool _isCreated;
        private int _roomID;
        private Exception _exception;
        private Booking _booking;

        //Managers
        private readonly BookingManager bm;
        private readonly Mock<IRepository<Room>> _fakeRoomRepo;
        private readonly Mock<IRepository<Booking>> _fakeBookingRepo;
        //private readonly IRepository<Room> _fakeRoomRepo;
        //private readonly IRepository<Booking> _fakeBookingRepo;

        public ManageBookingSteps()
        {

            //mock repos
            _fakeRoomRepo = new Mock<IRepository<Room>>();//new FakeRoomRepository();//new Mock<IRepository<Room>>();
            _fakeBookingRepo = new Mock<IRepository<Booking>>();//new FakeBookingRepository(DateTime.Today.AddDays(4), DateTime.Today.AddDays(10));//new Mock<IRepository<Booking>>();


            //Booking Manager instance
            bm = new BookingManager(_fakeBookingRepo.Object, _fakeRoomRepo.Object, new DateChecker());


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
                new Booking { Id = 1, StartDate=date, EndDate=date.AddDays(14), IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id = 2, StartDate=date, EndDate=date.AddDays(14), IsActive=true, CustomerId=2, RoomId=2 },
                new Booking { Id = 3, StartDate=date, EndDate=date.AddDays(14), IsActive=true, CustomerId=1, RoomId=3 }
            };


            //Unit test setup for mock data, with getall rooms
            _fakeRoomRepo.Setup(x => x.GetAll()).Returns(rooms);

            //Unit test setup for mock data, with specific room.
            _fakeRoomRepo.Setup(y => y.Get(2)).Returns(rooms[1]);

            //Unit test setup for mock data with getall bookings
            _fakeBookingRepo.Setup(x => x.GetAll()).Returns(bookings);

            //Unit test setup for mock data with specific booking
            _fakeBookingRepo.Setup(y => y.Get(2)).Returns(bookings[1]);

        }


        [Given(@"Startdate for the booking is in (.*) days")]
        public void GivenStartdateForTheBookingIsInDays(int startdate)
        {
            _startDate = startdate;
        }

        [Given(@"Enddate for the booking is also in (.*) days")]
        public void GivenEnddateForTheBookingIsAlsoInDays(int endate)
        {
            _endDate = endate;
        }

        [Given(@"Enddate is in (.*) day")]
        public void GivenEnddateIsInDay(int endate)
        {
            _endDate = endate;
        }

        [Given(@"Endate for the booking is in (.*) days")]
        public void GivenEndateForTheBookingIsInDays(int endate)
        {
            _endDate = endate;
        }

        [Given(@"(.*) is surplied from today")]
        public void GivenIsSurpliedFromToday(int startdate)
        {
            _startDate = startdate;
        }

        [Given(@"(.*) is also surplied from today")]
        public void GivenIsAlsoSurpliedFromToday(int endate)
        {
            _endDate = endate;
        }

        [Given(@"Startdate for the booking is in (.*) day")]
        public void GivenStartdateForTheBookingIsInDay(int startdate)
        {
            _startDate = startdate;
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

        [Then(@"I should get an error")]
        public void ThenIShouldGetAnError()
        {
            Assert.True(ScenarioContext.Current.ContainsKey("Error"));
            //Assert.NotNull(_exception);
        }

        [Then(@"I should get a room ID")]
        public void ThenIShouldGetARoomID()
        {
            Assert.NotEqual(-1, _roomID);
        }

        [Then(@"I should get (.*) instead of a legit room ID")]
        public void ThenIShouldGetInsteadOfALegitRoomID(int badNumber)
        {
            Assert.NotEqual(badNumber, _roomID);
        }

        [Then(@"return whether the booking is (.*)")]
        public void ThenReturnWhetherTheBookingIs(bool isValid)
        {
            Assert.Equal(isValid, _isCreated);
        }

        [Then(@"The booking should be active")]
        public void ThenTheBookingShouldBeActive()
        {
            Assert.True(_booking.IsActive);
        }
    }
}
