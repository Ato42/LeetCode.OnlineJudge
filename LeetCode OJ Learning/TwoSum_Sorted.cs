using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_OJ_Learning
{
    class TwoSum_Sorted
    {
        private int[] arr;
        private int tar;
        /// <summary>
        /// 构造函数
        /// </summary>
        public TwoSum_Sorted()
        {
            Console.WriteLine("请输入有序的数组：");
            arr = GetArray();
            Console.WriteLine("请输入目标");
            tar = GetTarget();
            RuntimeDetect rd = new RuntimeDetect(TwoSum);
            int[] result = TwoSum();
            Console.WriteLine("解为[{0},{1}]",result[0],result[1]);
        }
        /// <summary>
        /// 从键盘输入有序数组
        /// </summary>
        /// <returns></returns>
        private int[] GetArray()
        {
            char[] s = new char[] { ' ' };
            int[] input = new int[1];  
            try
            {
                string[] arr = Console.ReadLine().Trim().Split(s);
                input = new int[arr.Length];
                input = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
                if (arr.Length < 2)
                {
                    Console.WriteLine("输入的数组长度最小为2，请重新输入：");
                    input = GetArray();
                }
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (input[i] > input[i+1])
                    {
                        Console.WriteLine("输入的内容无序，请重新输入");
                        input = GetArray();
                        break;
                    }
                }               
                return input;
            }
            catch
            {
                Console.WriteLine("输入内容中存在非数字内容，请重新输入");
                return GetArray();
            }
        }
        /// <summary>
        /// 从键盘输入目标
        /// </summary>
        /// <returns></returns>
        private int GetTarget()
        {
            try
            {
                int target = System.Int32.Parse(Console.ReadLine());
                return target;
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入");
                return GetTarget();
            }
        }

        private int[] TwoSum()
        {
            int[] array = arr;
            int target = tar;
            int i = 0, j = array.Length - 1;
            while(i<j)
            {
                if(array[i]+array[j]<target)
                {
                    i++;
                }
                else if(array[i]+array[j]>target)
                {
                    j--;
                }
                else
                {
                    return new int[] { i, j };
                }
            }
            throw new Exception("无解");
        }
    }
}
