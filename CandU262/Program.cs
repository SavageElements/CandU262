using System;

namespace CandU262
{
    class Program
    {
        public enum DaysOfWeek
        {
            monday = 1,
            tuesday = 2,
            wensday = 3,
            thursday = 4,
            friday = 5,
            saturday = 6,
            sunday = 7
        }

        public string Day { get; set; }

        public int DayInt { get; set; }

        static void Main(string[] args)
        {
            bool isToday = false;

            while (isToday == false)
            { 
            Console.WriteLine("Please enter the current day of the week.");
            string today = Console.ReadLine();
            string lToday = today.ToLower();
                try
                {
                    DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), lToday);

                    if ((int)day < (int)(DaysOfWeek.monday) | (int)day > (int)(DaysOfWeek.sunday))
                    {
                        Console.WriteLine("Please type in a day of the week.");
                    }
                    else if ((int)day >= (int)(DaysOfWeek.monday) | (int)day <= (int)(DaysOfWeek.sunday))
                    {
                        Console.WriteLine("Today is " + today);
                        isToday = true;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine(today + " is not a day of the week.");
                }
            }
        }
    }
}
