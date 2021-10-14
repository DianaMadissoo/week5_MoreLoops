using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //i will not skateboard in the halls;

            for (int i = 0; i < 10; i++) //int i = 0; - start; i < 10; end, i++ = i = i+ - stop
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena paeva!");
        }
    }
}
