using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kolm numbrit
            //programm kuvab nende numbrite summat

            int sum = 0;

            for(int i = 0; i <3; i++)
            {
                Console.WriteLine("sisestage number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;
            }

            Console.WriteLine($"Your total is: {sum}");
        }
    }
}
