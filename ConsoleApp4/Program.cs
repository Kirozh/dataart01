using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        const int nuuum = 9;
        static void Main(string[] args)
        {
            //const int nnuum = 7;
            long d1 = new DateTime(1996,12,21, 20, 00, 00, new CultureInfo("en-US", false).Calendar).Ticks;
            DateTime d = new DateTime(d1);
            string format = "{0} 's Birthday is at {1:dd/MM/yyyy hh:mm:ss tt}";
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(" {0:c}", 123456);
            Console.WriteLine(format, "kirill", d);

            char[] carry = {'e','l','e','v','a','t','o','r' };
            string s =new string(carry);
            string sc = new string("refregerator");
            Console.WriteLine(s.Length);
            Console.WriteLine(s.CompareTo(sc));
                Console.WriteLine(s.Contains("e"));
                Console.WriteLine(s.PadLeft(19, '1'));
            Console.WriteLine(sc.PadRight(10,'1'));
            s = s + ' ' + sc;
            string[] darray = s.Split(' ');
            foreach (string f in darray)
                Console.WriteLine(f);
            StringBuilder sb = new StringBuilder("Операционные системы");
            sb.Append("\n");
            sb.AppendLine("Windows");
            Console.WriteLine(sb.ToString());
            int denum = 33;
            Console.WriteLine(denum>>3);

            int[,] RandomArr = new int[4, 5];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    RandomArr[i, j] = ran.Next(-100, 100);
                    Console.Write("{0}\t", RandomArr[i, j]);
                }
                Console.WriteLine();
            }

            int[][] randomArr = new int[3][];
            randomArr[0] = new int[1];
            randomArr[1] = new int[2];
            randomArr[2] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    if (i != j)
                        randomArr[i][j] = 0;
                    else
                        randomArr[i][j] = 1;
                    Console.Write("{0}\t", randomArr[i][j]);
                }
                Console.WriteLine();
            }

            Array strs = Array.CreateInstance(typeof(int), 3);
            strs.SetValue(2,0);
            strs.SetValue(3, 1);
            strs.SetValue(4, 2);

            Array.Sort(strs);

            (string, int, double) person = ("Tom", 25, 81.23);
            Console.WriteLine("{0}{1}{2}", person.Item1, person.Item2, person.Item3);
        }
    }
}
