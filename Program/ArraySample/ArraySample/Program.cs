using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                1,2,3,4,5,6
            };

            foreach(string item in args)
            {
                Console.WriteLine($" {item}");
            }
            Console.Read();
        }
    }
}
