using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "tere tulemast";
            //muul juhul konsoolis kuvatakse " vale kasutajatunnus või salasõna. Proovi uuesti!"
            //kasutajal on kolm katset

            
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisestage kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage salasõna:");
                string userPassword = Console.ReadLine();


                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või vale parool.");
                }
            }
        }
    }
}
