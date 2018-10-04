using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.BusinessLogic
{
    public class DateChecker : IDateChecker
    {
        public bool DateRangeIsValid(DateTime startDate, DateTime endDate) {
            if (startDate.Date.Day < DateTime.Today.Date.Day || startDate.Date.Day > endDate.Date.Day)
                throw new ArgumentException("The start date cannot be in the past or later than the end date.");

            if (startDate.Date.Day >= endDate.Date.Day)
                throw new ArgumentException("The start date cannot be later than the end date or on end date.");


            return true;
        }
    }
}
