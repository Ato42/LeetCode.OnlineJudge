using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode_OJ_Learning
{
    //public delegate void FunctionDelegate(int[] array,int target);//用委托将算法作为参数传递
    class Two_Sum
    {
        private int[] arr=new int[] { 0};//数组
        private int tar=0;//目标
        /// <summary>
        /// 构造函数，算法具体执行
        /// </summary>
        public Two_Sum()
        {
            Console.WriteLine("请输入数组内数字，数字间以空格分隔：");
            arr=GetArray();
            Console.WriteLine("请输入一个数字，作为targe");
            tar=GetTarget();
            try
            {
                RuntimeDetect rd = new RuntimeDetect(twoSum);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ///// <summary>
        ///// 验证引用成功
        ///// </summary>
        //public void print()
        //{
        //    Console.WriteLine("这里是 Two Sum\r\n");
        //    Program.mainstram();
        //}

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
            string[] arr = Console.ReadLine().Trim().Split(s);
            input = new int[arr.Length];
            input = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
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

        /// <summary>
        /// 算法1
        /// </summary>
        /// <returns></returns>
        private int[] twoSum()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == tar - arr[i])
                    {
                        Console.WriteLine("结果是：[" + i.ToString() + "," + j.ToString() + "]");
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("无解");
        }

    }
}
