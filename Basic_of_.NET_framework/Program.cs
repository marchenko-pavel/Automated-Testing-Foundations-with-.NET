using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Basic.NETframework
{
    internal class DecimalNumberSystemToAnother
    {
        static void Main(string[] arg_num)
        {
            int ArgumentNumber = Int32.Parse(arg_num[0]);
            int ArgumentBase = Int32.Parse(arg_num[1]);
            string ResultNumber = "";
            Stack<int> StackResults = new Stack<int>();                   

            for(;;)
            {
                if (ArgumentNumber >= ArgumentBase)
                {
                    StackResults.Push(ArgumentNumber % ArgumentBase);
                    ArgumentNumber /= ArgumentBase;
                }
                else
                {
                    StackResults.Push((int)ArgumentNumber);
                    break;
                }
            }            

            for(int i = StackResults.Count(); i > 0; --i)
            {
                ResultNumber += (StackResults.Pop().ToString()) + "_";
            }

            Console.WriteLine($"Преобразовано число {arg_num[0]} из десятичной " +
                $"системы исчисления в число {ResultNumber} системы исчисления - {arg_num[1]}");
        }
    }
}
