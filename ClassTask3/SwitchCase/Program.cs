using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchCaseExpression();
        }



        public static void SwitchCase()
        {
            Console.Write("Enter the season name in english :");
            string monthEn = Console.ReadLine().ToLower();

            switch (monthEn)
            {
                case "spring":
                    Console.WriteLine("Yaz");
                    break;

                case "winter":
                    Console.WriteLine("Qis");
                    break;
                case "summer":
                    Console.WriteLine("Yay");
                    break;
                case "Fall":
                    Console.WriteLine("Payiz");
                    break;
                default:
                    Console.WriteLine("this season does not exist");
                    break;


            }
        }


        public static void SwitchCaseExpression()
        {
            Console.Write("Enter the season name in english :");
            string month = Console.ReadLine().ToLower();


            string monthAz = month switch
            {
                "spring" => "Yaz",
                "winter" => "Qis",
                "summer" => "Yay",
                "fall" => "Payiz",
                _ => "this season does not exist"
            };

            Console.WriteLine(monthAz);

        }







    }
}
