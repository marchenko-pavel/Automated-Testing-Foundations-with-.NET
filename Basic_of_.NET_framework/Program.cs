using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_of_.NET_framework
{
    internal class Program
    {
        static void Main(string[] arg_num)
        {
            Stack<int> stack = new Stack<int>();
            
            int buf_num = Int32.Parse(arg_num[0]);
            int buf_base = Int32.Parse(arg_num[1]);

            for(; ; )
            {
                if (buf_num >= buf_base)
                {
                    stack.Push(buf_num % buf_base);
                    buf_num /= buf_base;
                }
                else
                {
                    stack.Push((int)buf_num);
                    break;
                }
            }

            string result = "";

            for(int i = stack.Count(); i > 0; --i)
            {
                result += (stack.Pop().ToString()) + "_";
            }
            Console.WriteLine($"Преобразовано число {arg_num[0]} из десятичной системы исчисления в число {result} системы исчисления - {arg_num[1]}");
        }
    }
}
