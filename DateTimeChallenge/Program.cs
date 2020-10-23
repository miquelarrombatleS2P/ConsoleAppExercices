using System;
using System.Globalization;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // i have a question for the user and declre one variable to answer user
            Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();
            
            //question to user if the date format
            Console.Write("What date format do you want to use: ");
            string dateFormat = Console.ReadLine();

            // if the date is less than 1 format date is m/d/yy
            if (dateFormat.Length < 1)
            {
                dateFormat = "M/d/yy";
            }

            //parse to string date to datetime
            DateTime previousDate = DateTime.ParseExact(previousDateString, dateFormat, null);

            // is the difference between the date written by the user with the current date
            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            // ticks is get a number of ticks that represent the date
            if (fromPreviousDate.Ticks < 0)
            {
                Console.WriteLine($"{ previousDateString } is { Math.Round(-fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days in the future.");
            }
            else
            {
                Console.WriteLine($"It has been { Math.Round(fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days since { previousDateString }");
            }

            //Console.WriteLine($"It has been { fromPreviousDate.Days} since { previousDateString }");

            Console.WriteLine("\r\n" + "Press enter to continue¬");
            Console.ReadLine();



            // Time: we collect in the variable the time that the user put
            Console.Write("Give me a time: ");
            string previousTimeString = Console.ReadLine();

            Console.Write("What time format do you want to use: ");
            string timeformat = Console.ReadLine();

            DateTime previousTime = DateTime.ParseExact(previousTimeString, "h:mm tt", CultureInfo.InvariantCulture);
            //new CultureInfo("en-US")
            //CultureInfo.InvariantCulture

            // is the same that date, is the difference between the times
            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            if (fromPreviousTime.Ticks < 0)
            {
                fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            }

            Console.WriteLine($"{ previousTimeString } was { fromPreviousTime.Hours } hours and { fromPreviousTime.Minutes } minutes ago.");

            Console.ReadLine();
        }
    }
}
