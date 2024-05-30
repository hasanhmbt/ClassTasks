using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace ClassTask_Loops_
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*   DigitsOfNumber();
                 Task1();
                 Task3();
                 Task4();
                 Task5();
                 FindRandomNumber();
                 Task7();
            */
            Task8();

        }


        //sayısal bir dizi tanımlayınız, (içeriğine siz karar verin) Array sınıfı kullanmadan enküçük ve enbüyük
        //elemanı mb içerisinde kulanıcıya gösteriniz..
        public static void Task1()
        {
            Console.Write("Enter array's size:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Console.Write("Enter array's elements:");

            for (int i = 0; i < l; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = nums[0], max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
                if (nums[i] > max)
                    max = nums[i];
            }
            Console.WriteLine("Minimum number: {0}\nMaximum Number: {1}", min, max);
        }

        //kullanıcıdan aldığınız sayısal değerin toplamını kullanıcıya gösteriniz.örn. 123 -> 6
        static void DigitsOfNumber()
        {

            Console.Write("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int sum = 0;


            while (num > 0)
            {
                sum += num % 10;
                // num /= 10;
                num = (num - num % 10) / 10;
                counter++;
            }

            Console.WriteLine($"Count of digits {counter}\nSum of digits {sum}");

        }



        //sayısal bir dizi tanımlayınız ve içerisindeki tek ve çift sayıların adedini kullanıcıya gösteriniz.
        public static void EvenAndOddNums()
        {
            Console.Write("Enter array's size:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Console.Write("Enter array's elements:");

            for (int i = 0; i < l; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int oddCount = 0, evenCount = 0;

            foreach (int i in nums)
            {
                if (i % 2 == 0) evenCount++;
                else oddCount++;
            }

            Console.WriteLine($"Even numbers count: {evenCount}, odd numbers count: {oddCount}");
        }


        static void Task2()
        {

            int num = Convert.ToInt32(Console.ReadLine());




        }



        //verilen değere göre Kare çizdiriniz.
        static void Task3()
        {
            Console.Write("Enter the height of the square:");
            int squareHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width of the square:");
            int squareWidth = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < squareHeight; i++)
            {
                for (int j = 0; j < squareWidth; j++)
                {
                    Console.Write(" X");
                }
                Console.WriteLine();
            }

        }



        //X ile dik kenar üçgen çiziniz
        static void Task4()
        {

            Console.Write("Enter the height of the triangle:");
            int triangleHeight = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= triangleHeight; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }


        }


        //X ile boş kare çiziniz
        static void Task5()
        {
            Console.Write("Enter width of square:");
            int width = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < width; i++)
            {
                Console.Write('X');
            }
            Console.WriteLine();

            for (int i = 0; i < width - 2; i++)
            {
                Console.Write('X');

                for (int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine('X');
            }

            for (int i = 0; i < width; i++)
            {
                Console.Write('X');
            }
            Console.WriteLine();

        }



        //Çarpım Tablosu 1 ile 10 (dahil) format 1 X 1 = 1 1 X 2 = 2 1 X 10 = 10
        static void Task6()
        {
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int answer = j * i;
                    Console.Write($"{j}*{i}={answer}\t");

                }
                Console.WriteLine();
            }


        }



        //OTP
        static void FindRandomNumber()
        {


            Random random = new Random();
            int rnd = random.Next(10000000, 99999999);
            int num;

            Console.WriteLine(rnd);


            for (int attemptsLeft = 3; attemptsLeft > 0; attemptsLeft--)
            {
                Console.Write("Enter the number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == rnd)
                {
                    Console.WriteLine("Correct number!");
                    return;
                }
                else
                {

                    Console.WriteLine($"Wrong number! You have {attemptsLeft - 1} attempts left.");

                }

            }

            Console.WriteLine($"You've used all your attempts. The correct number was {rnd}.");
            Console.WriteLine("The console will close in 10 seconds...");

            for (int i = 10; i > 0; i--)
            {
                Console.Write($"\rClosing in {i} seconds...");
                Thread.Sleep(1000);
            }

            Environment.Exit(0);
        }






        //sayısal bir dizi tanımlayınız dizi içerisinde hem 2 hem 3' e bölünenlerin sayısını kullanıcıya console üzerinde gösteriniz.
        static void Task7()
        {
            //  Doesn't work

            int[] nums = { 2, 3, 21, 33, 24, 18, 6, 9, 16, 17, 23, 31, 43, 47 };

            int count3 = 0, count2 = 0, count6 = 0, notDivisibleCount = 0;

            foreach (var num in nums)
            {
                if (num % 6 == 0) count6++;
                else if (num % 3 == 0) count3++;
                else if (num % 2 == 0) count2++;
                else notDivisibleCount++;
            }

            int[] divideby2 = new int[count2];
            int[] divideby3 = new int[count3];
            int[] divideby6 = new int[count6];
            int[] notDivisible = new int[notDivisibleCount];

            int divideby2Index = 0, divideby3Index = 0, divideby6Index = 0, notDivisibleIndex = 0;

            foreach (var num in nums)
            {
                if (num % 6 == 0) divideby6[divideby6Index++] = num;
                else if (num % 3 == 0) divideby3[divideby3Index++] = num;
                else if (num % 2 == 0) divideby2[divideby2Index++] = num;
                else notDivisible[notDivisibleIndex++] = num;
            }


            Console.WriteLine("Numbers divisible by 2: " + String.Join(", ", divideby2));
            Console.WriteLine("Numbers divisible by 3: " + String.Join(", ", divideby3));
            Console.WriteLine("Numbers divisible by both 2 and 3: " + String.Join(", ", divideby6));
            Console.WriteLine("Numbers that are not divisible by 2 or 3: " + String.Join(", ", notDivisible));
        }


        static void Task8()
        {
            string defaultPassword = "12345", defaultUsername = "admin";


            while (true)
            {

                Console.Write("Enter Username:");
                string userName = Console.ReadLine();


                Console.Write("Enter Password:");
                string password = Console.ReadLine();
                if (userName == userName && password == defaultPassword)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Access granted.");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong credentials, try again!");
                }
            }

        }

    }








 
}



