using System;

namespace void_method_divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region


            Console.WriteLine(Divide(8, 6));

            #endregion
        }
        #region

        static int Divide(int num1,int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }



        #endregion
    }
}
