using System;
using System.Globalization;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            long d1 = new DateTime(1996,12,21, 20, 00, 00, new CultureInfo("en-US", false).Calendar).Ticks;
            DateTime d = new DateTime(d1);
            string format = "{0} 's Birthday is at {1:dd/MM/yyyy hh:mm:ss tt}";
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(" {0:c}", 123456);
            Console.WriteLine(format, "kirill", d);
        }
    }
}
