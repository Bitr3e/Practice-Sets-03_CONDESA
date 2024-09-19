using System;

namespace LeapYear_or_not
{
    class Program
    //function that determines whether a given year is a leap year or not.
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            if (LeapYear(year))
            {
                Console.Write($"{year} is a leap year.");
            }

            else
            {
                Console.Write($"{year} is not a leap year.");
            }
        }

        static bool LeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
