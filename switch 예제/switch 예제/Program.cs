using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c샵예제
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
