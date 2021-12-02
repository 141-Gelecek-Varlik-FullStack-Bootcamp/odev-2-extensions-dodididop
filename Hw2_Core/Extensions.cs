using System;

namespace Hw2_Core
{
    public static class Extensions
    {
        public static string ToTurkishDateTime(this DateTime _dateTime)//Created extension method 
        {
            return _dateTime.AddDays(30).ToShortDateString();//To add 30 days from now and then convert to short date string.
        }
    }
}
