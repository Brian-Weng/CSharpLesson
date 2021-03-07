using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureSpeed
{
    class SleepHelper
    {

        /// <summary> 暫停程式數秒鐘 </summary>
        /// <param name="second"></param>
        public static void SleepAWhile(int second)
        {

            int ms = second * 1000; //second 預設為毫秒 * 1000變為秒

            System.Threading.Thread.Sleep(ms); //讓執行續暫停幾秒ig.輸入3-> 3毫秒*1000=3000毫秒 -> 3秒
        }

    }
}
