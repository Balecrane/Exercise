using System;
using System.Globalization;
using System.Linq;

namespace exercise2
{
    class Program
    {
     
        

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var  monthIndex = Int32.Parse(input);
            var month = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthIndex);
            Console.WriteLine(month);
        }
    }
}
