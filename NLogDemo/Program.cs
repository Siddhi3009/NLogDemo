using System;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \nEnter a & b values");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            AddNumber add = new AddNumber();
            Console.WriteLine("Result : " + add.Sum(a,b));
        }
    }
}
