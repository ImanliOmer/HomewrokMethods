using System;

namespace sum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Info("Omer", "Imanov", 18);
            Console.WriteLine(info);
        }

        static string Info(string name, string surname, int age)
        {
            return ($" {name} {surname} {age} ");
        }
    }
}
