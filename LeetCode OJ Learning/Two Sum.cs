using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode_OJ_Learning
{
    public delegate void FunctionDelegate(int[] array,int target);//用委托将算法作为参数传递
    class Two_Sum
    {
        public Two_Sum()
        {
            GetArray();
        }

        /// <summary>
        /// 检测某一算法时间消耗
        /// </summary>
        /// <param name="Function">指定算法</param>
        private void TimeCost(FunctionDelegate Function)
        {
            Console.WriteLine("请输入数组中的数字，数字间以空格分隔，以回车结束：\r\n");
           int[] arr= GetArray();
            Console.WriteLine("请输入一个数字，作为targe");
            int tar = GetTarget();
            Stopwatch sw = new Stopwatch();
            sw.Start(); //监视算法耗时
            Function(arr,tar);
            sw.Stop();
            TimeSpan tp = sw.Elapsed;
            double ms = tp.TotalMilliseconds;
            Console.WriteLine("该算法耗时"+ms.ToString()+"ms\r\n");
        }

        /// <summary>
        /// 验证引用成功
        /// </summary>
        public void print()
        {
            Console.WriteLine("这里是 Two Sum\r\n");
            Program.mainstram();
        }

        /// <summary>
        /// 获取数组
        /// </summary>
        /// <returns></returns>
        private int[] GetArray()
        {
            // int[] input = new int[5];
            char[] s = new char[] { ' ' };
            int[] input=new int[1];
            try
            {          
            string[] arr = Console.ReadLine().Split(s);
            int[] arry1 = new int[arr.Length];
            arry1 = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
            }
            catch
            {
               Console.WriteLine("输入错误，请重新输入");
               input= GetArray();
            }
            return input;
        }

        /// <summary>
        /// 获得目标值
        /// </summary>
        /// <returns></returns>
        private int GetTarget()
        {
            Console.WriteLine("请输入一个数字，作为targe");
            int input=0;
            try
            {
                string arr=Console.ReadLine();
                input = System.Int32.Parse(arr);
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入");
                input = GetTarget();
            }
            return input;
        }

    }
}
