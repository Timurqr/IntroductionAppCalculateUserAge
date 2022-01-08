using System;

namespace IntroductionAppCalculateUserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of your birth:");
            var yearOfBirch = Convert.ToInt32(Console.ReadLine());
            var currentYear = DateTime.Today.Year;
            var userAge = currentYear - yearOfBirch;
            var adultMarker = 18;

            if (userAge >= adultMarker)
                Console.WriteLine(userAge + " years, you are adult.");
            if (userAge < adultMarker)
                Console.WriteLine(userAge + " years, you are not adult.");
        }
    }
}