using System;
using System.Linq;

namespace exercise
{
    class Program
    {

        static string AppendFirstCharacterToFrontAndBack(string input)
        {
            return input.First() + input + input.First();
        }
    
        static void Main(string[] args)
        {
            var sakinys = "Happy Holidays!";
            Console.WriteLine(AppendFirstCharacterToFrontAndBack(sakinys));
        }
    }
}
