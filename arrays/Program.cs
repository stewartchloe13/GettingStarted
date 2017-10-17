using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
            static void Main(string[] args)
            {
                Enumerable.Range(1, 100).ToList()
                    .ForEach(x =>
                    {
                        Console.WriteLine("{0}{1}{2}",
                            x % 3 == 0 ? "Fizz" : "",
                            x % 5 == 0 ? "Buzz" : "",
                            x % 3 != 0 && x % 5 != 0 ? x.ToString() : "");
                    });
            }
        
    }
}
