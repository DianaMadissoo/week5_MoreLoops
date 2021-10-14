using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus osaleb kaks mangijat - arvuti (cpu) ja kasutaja (user);
            //molemad mangijad viskavad taringuid;
            //programm kontrollib, kumb mangija viskas rohkem;
            //mangija, kes viskab rohkem ongi mangu voitja;
            //*taringuid visatakse kolm korda;
            //programm kuulutab voitja;

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore = cpuScore + 1;
                }

            }

            if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mangu voitnud.");
            }
            else if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja on mangu voitnud. Palju onne!");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
            
        }
    }
}
