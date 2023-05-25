using System;
using System.Collections.Generic;

namespace OOP_LR_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "Hello", "world", "!", "Glory", "to", "Ukraine", "!!!" };

            Func<string, int> lengthDelegate = s => s.Length;

            foreach (string str in strings)
            {
                int length = lengthDelegate(str);
                Console.WriteLine("{0} - довжина: {1}", str, length);
            }
        }
    }
}
