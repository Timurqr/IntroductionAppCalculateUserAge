using System;

namespace IntroductionAppCalculateUserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            const int adultMarker = 18;

            Console.Write("Enter year of your birth:");
            int yearOfBirch = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Today.Year;
            int userAge = currentYear - yearOfBirch;           

            if (userAge >= adultMarker)
                Console.WriteLine(userAge + " years, you are adult.");
            if (userAge < adultMarker)
                Console.WriteLine(userAge + " years, you are not adult.");
        }
    }
}