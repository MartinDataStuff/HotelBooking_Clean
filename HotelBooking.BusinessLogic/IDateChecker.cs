using System;

namespace HotelBooking.BusinessLogic
{
    public interface IDateChecker
    {
        /// <summary>
        /// Validate date range, throws ArgumentException if invalid otherwise returns true.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        bool DateRangeIsValid(DateTime startDate, DateTime endDate);
    }
}