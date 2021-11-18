using System;

namespace Epam.Developmentand.Tools;
class SetOfString
{
    static void Main(string[] args)
    {
        SortedSet<char> set_args = new SortedSet<char>();

        for(int i = 0; i < args.Length; i++)
        {
            foreach (char arg in args[i])
            {
                set_args.Add(arg);
            }
        }

        foreach (char arg in set_args) { Console.WriteLine(arg); }
    }
}