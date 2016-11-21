using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_OJ_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            mainstram();
        }

        static public void mainstram()
        {
            string output = "请输入数字，以进入程序：\r\n1:Two Sum;\r\n2:Two Sum Sorted;";
            string input;
            Console.WriteLine(output);
            try
            {
                input = Console.ReadLine().ToString();
               // Console.WriteLine(input);
                switch(input)
                {
                    case "1":
                        Two_Sum twosum = new Two_Sum();
                        break;
                    case "2":
                        TwoSum_Sorted tss = new TwoSum_Sorted();
                        break;                        
                    default:
                        Console.WriteLine("输入错误，请重新输入。\r\n\r\n");
                        mainstram();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入。\r\n\r\n");
                mainstram();
            }
            mainstram();
        }
    }
}
