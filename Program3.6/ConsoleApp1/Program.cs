using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123");
            int result = MathCore.Add(5, 6);
            Console.WriteLine("5 + 6 =" + result);

            Console.ReadKey();
#if DEBUG
            Console.WriteLine(1);
#endif


#if RELEASE
            Console.WriteLine(1);
#endif
        }

        static void GOGOGO()
        {
            int result = MathCore.Add(5, 6);
        }

    }
}
