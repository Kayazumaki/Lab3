using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj cyfrę, to ją obrócę   ");
            int n = Convert.ToInt32(Console.ReadLine());
            // int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            // string reversedWord = string.Join("", result.Reverse());
            int sum = 0;

            



            int reverse(int num)
            {

                int r = 0;

                if (num > 0)
                {
                    r = num % 10;
                    sum = (sum * 10) + r;
                    reverse(num / 10);
                }
                else
                {
                    return 0;
                }
                return sum;
            }
            int revesed = reverse(n);
            Console.WriteLine(revesed);
            Console.ReadKey();
        }
    }
}
