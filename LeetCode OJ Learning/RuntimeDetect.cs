using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_OJ_Learning
{
    public delegate object RuntimeDetectDelegate();
    class RuntimeDetect
    {
        /// <summary>
        /// 检测算法耗时
        /// </summary>
        /// <param name="m">算法方法</param>

        public RuntimeDetect(RuntimeDetectDelegate m)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start(); //监视算法耗时
            m();
            sw.Stop();
            TimeSpan tp = sw.Elapsed;
            double ms = tp.TotalMilliseconds;
            Console.WriteLine("该算法耗时" + ms.ToString() + "ms\r\n");
        }
    }
}
