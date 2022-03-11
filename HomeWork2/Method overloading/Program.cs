using System;

namespace Method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //method signature
        //1. methodun adi
        //2. 
        //3. methodun parametrlerinin typy-i 



        //parametrlerinin say ferqi olduqda isleyir.
        static int sum(int num1)
        {
            return 1; 
        }
        static int sum(int num1, int num2)
        {
            return 5;
        }


        //parametrlerinin typy-i ferqli olduqda isleyir.

        static int cem(int num1)
        {
            return 1;
        }
        static int cem(string word)
        {
            return 5;
        }



        //parametrlerinin adi ferqli olduqda
        static int cixma(int num1)
        {
            return 1;
        }
        static int toplama(int num1)
        {
            return 5;
        }
        // arr mentiqi


        static int top(params int[]arr)
        {
            return 1;
        }
        static int top(int num1)
        {
            return 5;
        }
    }
}
