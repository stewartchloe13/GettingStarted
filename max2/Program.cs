using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max2
{
    class max2
    {
        static void Main(string[] args)
        { 
                int min = 0;
                int max = 100000;

                int[] numbers = new int[5000];

                Random r = new Random();
                for (int i = 0; i < numbers.Length; i++)
                { numbers[i] = r.Next(min, max); }

                int max2 = numbers.Max();
                Console.WriteLine("The largest number in the array is: " + max2);
                int secondHighest = (from number in numbers orderby number descending select number).Distinct().Skip(1).First();
                Console.WriteLine("The second largest number in the array is: " + secondHighest);
            }
        }
    }


