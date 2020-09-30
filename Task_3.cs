using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            int a = 0;
            double b = 0;
            long c = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть змінну типу int: ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть змінну типу double: ");
                    double b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введіть змінну типу long: ");
                    long c1 = Convert.ToInt64(Console.ReadLine());
                    a += a1;
                    b += b1;
                    c += c1;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error");
                    continue;
                }
            }
            Console.WriteLine($"a = {a}; b = {b}; с = {c}");
        }
    }
}