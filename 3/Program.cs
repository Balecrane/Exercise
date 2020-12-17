using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine();
            Console.WriteLine(new string(x.Reverse().ToArray()));
        }
    }
}
