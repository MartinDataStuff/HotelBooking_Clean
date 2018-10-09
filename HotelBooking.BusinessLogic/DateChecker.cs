using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.BusinessLogic
{
    public class DateChecker : IDateChecker
    {
        public bool DateRangeIsValid(DateTime startDate, DateTime endDate) {
            if (startDate.Date < DateTime.Today.Date || startDate.Date > endDate.Date)
                throw new ArgumentException("The start date cannot be in the past or later than the end date."
                    + "Startdate: " + startDate + "- Enddate:" + endDate);

            if (startDate.Date >= endDate.Date)
                throw new ArgumentException("The start date cannot be later than the end date or on end date."
                    +"Startdate: " + startDate + "- Enddate:" + endDate);


            return true;
        }
    }
}
