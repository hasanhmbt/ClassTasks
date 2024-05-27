using System;

namespace LabTask2
{


    internal class Program
    {

        static void Main(string[] args)
        {
             EvenOrOddNumber();
           //IsMinusOrPlus();
           //CalculateGPA();
        }


        public static void EvenOrOddNumber()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
             

            if (num > 0 || num % 2 == 0)
                Console.WriteLine($"{num} is an even number.");
            else
                Console.WriteLine($"{num} is an odd number.");

        }


        public static void IsMinusOrPlus()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num != 0 || num < 0)
                Console.WriteLine($"{num} is a minus number.");
            else if (num == 0)
                Console.WriteLine(" 0 not is a pluse or minus number.");
            else
                Console.WriteLine($"{num} is a pluse number.");
        }

        public static void CalculateGPA()
        {
            Console.WriteLine("Enter a number:");
            int GPA = Convert.ToInt32(Console.ReadLine());

            if (GPA > 90 && GPA <= 100)
                Console.WriteLine($"Your GPA is A");
            else if (GPA > 80 && GPA <= 90)
                Console.WriteLine($"Your GPA is B");
            else if (GPA > 70 && GPA <= 80)
                Console.WriteLine($"Your GPA is C");
            else if (GPA > 60 && GPA <= 70)
                Console.WriteLine($"Your GPA is D");
            else if (GPA > 50 && GPA <= 60)
                Console.WriteLine($"Your GPA is E");
            else if ( GPA<51)
                Console.WriteLine($"Your GPA is F");

        }
    }



}
