using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The reverse of given number is {0}", Reverse(number));
            Console.ReadKey();
        }
        public static int Reverse(int x)
        {
            int rem;
            int rev1 = 0;
            int rev = 0;

            if (x > 0)
            {
                while (x != 0)
                {
                    rem = x % 10;
                    if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && rem > 7)) return 0;
                    if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && rem < -8)) return 0;
                    rev = rev * 10 + rem;
                    x = x / 10;
                }

            }

            if (x < 0)
            {
                int num = -x;
                while (num != 0)
                {
                    rem = num % 10;
                    if (rev1 > Int32.MaxValue / 10 || (rev1 == Int32.MaxValue / 10 && rem > 7)) return 0;
                    if (rev1 < Int32.MinValue / 10 || (rev1 == Int32.MinValue / 10 && rem < -8)) return 0;
                    rev1 = rev1 * 10 + rem;
                    num = num / 10;
                }
                rev = -(rev1);
            }
            return rev;
        }
    }
}
