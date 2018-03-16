using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of first array.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input length of second array.");
            int m = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("First array, Element {0}", (i + 1));
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Second array, Element {0}", (i + 1));
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            { Console.Write(firstArr[i] + " "); }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            { Console.Write(secondArr[i] + " "); }
            Console.WriteLine();
            Console.WriteLine("Equal elements: ");
            Console.WriteLine();
            
            var ressult = firstArr.Intersect(secondArr);
            int[] kray = ressult.ToArray();
            int lenght = kray.Length;
            if (lenght > 0)
            {
                foreach (var v in ressult)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.WriteLine();
            
        }
    }
}
