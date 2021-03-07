using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ms = r.Next(1, 4);
            DateTime startTime = DateTime.Now; //instantiate a DateTime object. DateTime.Now is a property(like user.firstname)
            Console.WriteLine("Program start.");
            SleepHelper.SleepAWhile(ms); //讓執行緒暫停2秒
           
            DateTime endTime = DateTime.Now;
            TimeSpan ts = endTime - startTime; //instantiate a TimeSpan object. ts.TotalMilliseconds is a property(like user.firstname)
            Console.WriteLine("Program End. Total use " + ts.TotalMilliseconds);
            Console.ReadLine();
            
            //引用namespace System.Diagnostics中的類別Stopwatch 建立名稱為 sw 的物件
            /*System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Program start.");
            sw.Start();  //object method ( like user.talk() )
            SleepHelper.SleepAWhile(3);
            sw.Stop();

            sw.Reset();

            sw.Start();
            SleepHelper.SleepAWhile(6);
            sw.Stop();

            Console.WriteLine("Program End. total use " + sw.ElapsedMilliseconds);
            Console.ReadLine();*/
        }
    }
}
