using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                i++;
                int j = 1;
                do
                {
                    Console.WriteLine("j value: {0}", j);
                    j++;
                } while (j < 2);
            } while (i < 4);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}