using System;
using System.Collections.Generic;
using HotelBooking.Models;
using HotelBooking.BusinessLogic;
using System.Linq;
using Moq;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class BookingManagerTests
    {
        private Mock<IRepository<Room>> FakeRoomRepo;
        private Mock<IRepository<Booking>> FakeBookingRepo;

        IBookingManager bm;

        public BookingManagerTests()
        {

            //mock repos
            FakeRoomRepo = new Mock<IRepository<Room>>();
            FakeBookingRepo = new Mock<IRepository<Booking>>();


            //Booking Manager instance
            bm = new BookingManager(FakeBookingRepo.Object, FakeRoomRepo.Object, new DateChecker());


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
            FakeRoomRepo.Setup(x => x.GetAll()).Returns(rooms);

            //Unit test setup for mock data, with specific room.
            FakeRoomRepo.Setup(y => y.Get(2)).Returns(rooms[1]);

            //Unit test setup for mock data with getall bookings
            FakeBookingRepo.Setup(x => x.GetAll()).Returns(bookings);

            //Unit test setup for mock data with specific booking
            FakeBookingRepo.Setup(y => y.Get(2)).Returns(bookings[1]);

        }


        [Fact]
        public void FindAvailableRoom_StartDateNotInFuture_ThrowException()
        {
            DateTime date = DateTime.Today;
            Assert.Throws<ArgumentException>(() => bm.FindAvailableRoom(date, date));
        }

        [Fact]
        public void FindAvailableRoom_RoomAvailable_RoomNotMinusOne()
        {
            //Arrange
            DateTime date = DateTime.Today.AddDays(1);


            int Roomid = bm.FindAvailableRoom(date, date.AddDays(1));


            Assert.NotEqual(-1, Roomid);


        }



        [Fact]
        public void CreateBooking_StartDateNotInFuture_ThrowException()
        {
            var booking = new Booking
            {
                Id = 1,
                StartDate = DateTime.Today.AddDays(-1),
                EndDate = DateTime.Today.AddDays(5),
                CustomerId = 1,
                IsActive = false
            };

            Assert.Throws<ArgumentException>(() => bm.CreateBooking(booking));
        }


        [Fact]
        public void CreateBooking_Booking_IsTrue()
        {

            var booking = new Booking
            {
                Id = 1,
                StartDate = DateTime.Today.AddDays(1),
                EndDate = DateTime.Today.AddDays(3),
                CustomerId = 1,
                IsActive = false
            };

            Assert.True(bm.CreateBooking(booking));


        }


        [Fact]
        public void CreateBooking_Booking_IsFalse()
        {
            var booking = new Booking
            {
                Id = 1,
                StartDate = DateTime.Today.AddDays(1),
                EndDate = DateTime.Today.AddDays(6),
                CustomerId = 1,
                IsActive = false
            };

            Assert.False(bm.CreateBooking(booking));


        }


        [Fact]
        public void CreateBooking_Booking_IsActiveIsTrue()
        {
            var booking = new Booking
            {
                Id = 1,
                StartDate = DateTime.Today.AddDays(1),
                EndDate = DateTime.Today.AddDays(3),
                CustomerId = 1,
                IsActive = false
            };

            bm.CreateBooking(booking);

            Assert.True(booking.IsActive);
        }
    }
}