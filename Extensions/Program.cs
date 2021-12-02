using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//To get current date and time type data.
            Console.WriteLine("After 30 days, the date of the day will be {0}", Hw2_Core.Extensions.ToTurkishDateTime(dateTime));//The extension method was used to get the date after 30 days.
                                                                                                                                 //And printed on console.
        } 
    }
}
