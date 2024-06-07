using System.Data.SqlTypes;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace Void_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name:");
            string lastName = Console.ReadLine();
            Console.Write("Enter domain :");
            string domain = Console.ReadLine();

           // CreateMail(firstName,lastName,domain);


            //Method4(name, surname, domain);
            //ConvertToUpperCase("Test");
            //ChangeTheSymb("hello@",'@','!');
            //ConvertToCapitalLetter("test");

        }





        // Custom .ToUpper method.
        public static string ConvertToUpperCase(string str)
        {
            char[] chars = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                    chars[i] = (char)(str[i] - 32);
                else
                    chars[i] = str[i];

            }
            string newStr = new string(chars);
            return newStr;

        }


        // Custom .Replace method.
        public static string ChangeTheSymb(string str, char oldSymb, char newSymb)
        {

            char[] chars = new char[str.Length];


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldSymb)
                    chars[i] = newSymb;
                else
                    chars[i] = str[i];

            }

            string newStr = new string(chars);
            return newStr;

        }


        // Custom .ToTitle method.
        public static string ConvertToCapitalLetter(string str)
        {
            char[] chars = new char[str.Length];


            if (str[0] >= 'a' && str[0] <= 'z')
                chars[0] = (char)(str[0] - 32);
            else
                chars[0] = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                chars[i] = str[i];
            }

            string newStr = new string(chars);
            return newStr;
        }



        private static void CreateMail(string firstName, string lastName, string? domain = "code.edu.az")
        {
            string mail = $"{ConvertToCapitalLetter(firstName)}.{ConvertToUpperCase(lastName)}@{ChangeTheSymb(domain,'!',' ')}";
            Console.WriteLine(mail);
        }

    }
}
