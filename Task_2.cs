using System;


namespace readline
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите переменую типа int");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите переменую типа double");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменую типа long");
            long c = long.Parse(Console.ReadLine());

            Console.WriteLine($"a={a};b={b};c={c}");
        }
    }
}