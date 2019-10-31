using System;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;

            //DateTime date = new DateTime(year, month, day);
            var birthday = new DateTime(1991, 5, 6);
            var next = birthday.AddYears(today.Year - birthday.Year);
            // Count the days of your next birthday
            
            //Console.WriteLine(today);
            //Console.WriteLine(birthday);
            //Console.WriteLine(next);
            if (next < today)
            next = next.AddYears(1);

            int numDays = (next - today).Days;

            Console.WriteLine($"{numDays} days remaining to my next birthday.");
        }
    }
}
