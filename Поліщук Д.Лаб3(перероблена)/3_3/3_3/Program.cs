using System;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Послiдовнiсть А:");
            int d = 5;
            int[] a = { -73, -45, -8, 4, 51, 29, 45 };
            Console.WriteLine(string.Join(" ", a));

            var result = a.FirstOrDefault(x => x > 0 && x % 10 == d);
            Console.WriteLine("Результат: {0}", result);

            Console.ReadLine();
        }
    }
}
