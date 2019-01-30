using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekParticipation4
{
    class Program
    {
        static void Main(string[] args)
        {
            // First block of code questions
            bool check;
            int val = 35;
            int n = -5;
            Console.WriteLine("3 < 5: {0}", (3 < 5));
            Console.WriteLine(check = val + 3 == 38);
            Console.WriteLine(check = val * 3 > 120);
            Console.WriteLine(check = val - 30 < -5 + 10);
            Console.WriteLine(check = n < 0);
            Console.WriteLine(check = val/n + 8 <= 0);
            Console.WriteLine(check = val % 2 != 0);
            Console.WriteLine();

            //Second block of code questions
            int m = 3;
            int a = 4;
            int b = 5;
            int c = 6;
            char ch = '!';
            Console.WriteLine("m > 10: {0}", (m > 10));
            Console.WriteLine(check = a%2 == 0 && b%2 == 0 && c%2 == 0);
            Console.WriteLine(check = a%2 == 0 || b%2 == 0 || c%2 == 0);
            Console.WriteLine(check = ch >= '0' && ch <= '9');
            Console.WriteLine();

            //Third Block of code question
            int m2 = 4;
            int n2 = 5;
            Console.WriteLine(check = m2 %2 == 0 && n2 == 0);


            //Fourth block of code question
            bool p = true;
            bool q = false;
            bool r = false;

            Console.WriteLine(!r);
            Console.WriteLine( r && p);
            Console.WriteLine(!(r || q) && p);
            Console.WriteLine((r && !r) || (p && !p));
            Console.WriteLine((p && !q) || (!p && q));
            Console.WriteLine((r || !r) && (p || !p));
            Console.WriteLine();


        }
    }
}
