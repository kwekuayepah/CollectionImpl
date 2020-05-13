using System;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning C# collections - Array");
            string [] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            Console.WriteLine("Enter the day you want to display on console.");
            Console.Write("Day (e.g Monday etc > ");
            var day = Console.ReadLine();
            var iDay = DisplayDay(day);

            var value = daysOfWeek[iDay];
            Console.WriteLine($"The day is {value}");
            // foreach (var days in daysOfWeek)
            // {
            //     Console.WriteLine(days);
            // }
        }

        static int DisplayDay(string day)
        {
            switch (day.ToLower())
            {
                case "monday":
                    return 0;
                case "tuesday":
                    return 1;
                case "wednesday":
                    return 2;
                case "thursday":
                    return 3;
                case "friday":
                    return 4;
                case "saturday":
                    return 5;
                case "sunday":
                    return 6;
            }

            return -1;
        }
    }
}