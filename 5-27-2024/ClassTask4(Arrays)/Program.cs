namespace ClassTask4_Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAverage();
            //GetMinIndex();
            FindSimpleOrComplex();
        }


        #region GetAverage

        public static void GetAverage()
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
        #endregion

        #region GetMinIndex


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


            Console.WriteLine(Environment.NewLine, Environment.NewLine);

        }
        #endregion


        #region FindSimpleOrComplex


        public static void FindSimpleOrComplex()
        {

            int simpleCount = 0;
            int complexCount = 0;

            Console.Write("Enter size of the array:");
            int arrLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array's elements:");
            int[] nums = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
                nums[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int num in nums)
            {
                if (IsSimple(num))
                    simpleCount++;
                else
                    complexCount++;
            }


            int[] simples = new int[simpleCount];
            int[] complexes = new int[complexCount];

            int complexIndex = 0; int simpleIndex = 0;

            foreach (int num in nums)
            {
                if (IsSimple(num))
                    simples[simpleIndex++] = num;
                else
                    complexes[complexIndex++] = num;
            }
            //Console.Clear();
            Console.WriteLine("Simple numbers:" + String.Join(',', simples));
            Console.WriteLine("Complex numbers:" + String.Join(',', complexes));

        }

        public static bool IsSimple(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i < num; i++)
                if (num % i == 0) return false;

            return true;
        }
        #endregion


    }
}

