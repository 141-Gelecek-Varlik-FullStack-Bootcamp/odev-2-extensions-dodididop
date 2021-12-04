using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Hw2_Core
{
    public static class Extensions
    {
        public static string ToTurkishDateTime(this DateTime _dateTime)//Created extension method 
        {
            return _dateTime.AddDays(30).ToShortDateString();//To add 30 days from now and then convert to short date string.
        }

        public static string GetUserDisplayName(this Enum userType)//created extension method.
        {
            var result = userType.GetType()
                                 .GetMember(userType.ToString())
                                 .First()
                                 .GetCustomAttributes<DisplayAttribute>()
                                 .First().Name;//the process should be dynamic. First look the type then progress with the operation.
            return result;
        }

    }
}
