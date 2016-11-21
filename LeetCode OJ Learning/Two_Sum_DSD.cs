using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_OJ_Learning
{
    class Two_Sum_DSD
    {
        private int[] Data=new int[0];

        public Two_Sum_DSD()
        {
            entry();
        }
        private void Add(int[] num)
        {
            if (Data.Length > 0)
            {
                int[] temp = new int[Data.Length + num.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = Data[i];
                }
                for (int i = 0; i < num.Length; i++)
                {
                    temp[Data.Length + i] = num[i];
                }
                Data = temp;
            }
            else
            {
                Data = num;
            }
        }

        private bool FindWay1(int num)
        {
            if(Data.Length<2)
            {
                throw new Exception("数组长度不足2，无法查找元素");
            }
            else
            {
                int[] array = Data;
                int target = num;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == target - array[i])
                        {
                            // Console.WriteLine("结果是：[" + i.ToString() + "," + j.ToString() + "]");
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        private bool FindWay2(int num)
        {
            if (Data.Length < 2)
            {
                throw new Exception("数组长度不足2，无法查找元素");
            }
            else
            {
                int[] array = Data;
                int target = num;
                Dictionary<int, int> hashtable = new Dictionary<int, int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (!hashtable.ContainsKey(array[i]))
                    {
                        hashtable.Add(array[i], i);
                    }
                    else if (array[i] * 2 == target)
                    {
                        return true;
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    int diff = target - array[i];
                    if (hashtable.ContainsKey(diff) && i != hashtable[diff])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private int[] Input(string input)
        {
            try
            {
                char[] space = new char[] { ' ' };
                string[] arr = input.Trim().Split(space);
                int[] result = new int[arr.Length];
                result = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
                return result;
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入：");
                return Input(Console.ReadLine());
            }
        }
        private void entry()
        {
            Console.WriteLine("添加数字，请输入数字1；查找数字，请输入数字2.其他内容跳出程序");
            string input = Console.ReadLine();
            try
            {
                int m = System.Int32.Parse(input);
                if (m == 1)
                {
                    Console.WriteLine("请输入一个或一组数字，作为数组内容");
                    Add(Input(Console.ReadLine()));
                    entry();
                }
                else if (m == 2)
                {
                    Find();
                    entry();
                }
                else
                {
                    throw new Exception("输入非法内容");
                }
            }
            catch
            {
                throw new Exception("输入非法内容");
            }
        }
        private void Find()
        {
            Console.WriteLine("请输入一个数字，以查询结果");
            try
            {
                int num = System.Int32.Parse(Console.ReadLine());
                bool result1 = FindWay1(num);
                if (result1)
                    Console.WriteLine("存在");
                else
                    Console.WriteLine("不存在");
                bool result2 = FindWay2(num);
                if (result2)
                    Console.WriteLine("存在");
                else
                    Console.WriteLine("不存在");
                entry();
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入");
                Find();
            }
        }
    }
}
