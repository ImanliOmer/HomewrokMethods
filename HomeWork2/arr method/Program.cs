using System;

namespace arr_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = SumMasiveElement(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);
        }

        static int SumMasiveElement(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
