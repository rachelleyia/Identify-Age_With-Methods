using System;

namespace IdentifyAge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Get user input -- year of birth
            Console.Write("Enter year of birth: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            // Calculate Age
            int age = 2024 - yearOfBirth;
            string generation = IdentifyGeneration(age);
            string stage = IdentifyStage(age);

            Console.WriteLine($"{age} years old, {generation}, {stage}");
        }

        static string IdentifyGeneration(int age)
        {
            if (age >= 79 && age <= 96)
            {
                return "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                return "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                return "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                return "Millennials";
            }
            else if (age >= 12 && age <= 27)
            {
                return "Gen Z";
            }
            else if (age >= 0 && age <= 11)
            {
                return "Gen Alpha";
            }
            else
            {
                return "Unknown Generation";
            }
        }

        static string IdentifyStage(int age)
        {
            if (age >= 0 && age <= 3)
            {
                return "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                return "Early Childhood";
            }
            else if (age == 7 || age == 8)
            {
                return "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                return "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                return "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                return "Early Adulthood";
            }
            else if (age >= 36 && age <= 50)
            {
                return "Midlife";
            }
            else if (age >= 51 && age <= 80)
            {
                return "Mature Adulthood";
            }
            else if (age > 80)
            {
                return "Late Adulthood";
            }
            else
            {
                return "Unknown Stage";
            }
        }
    }
}