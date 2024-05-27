namespace ClassTask4_Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAvareage();

        }





        public static void SimpleOrComplex()
        {
            int[] numbers = { 4, 5, 6, 7 };
            int[] simple;
            int[] complex;


            for (int i = 0; i < numbers.Length; i++)
            {




            }



        }











        public static void GetAvareage()
        {

            int[] numbers = { 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Array average is: {average}");
        }











        public static void GetMinIndex()
        {

            int[] numbers = { 1, 0, 50, -11, 23, 18 };

            int min = numbers[0];
            int minIndex = 0;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"The minimum number is: {min} \n");
            Console.WriteLine($"The index of the minimum number is: {minIndex}\n ");




            Console.Write($"Numbers of Array:");

            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]}, ");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }




    }
}

