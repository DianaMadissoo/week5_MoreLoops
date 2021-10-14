using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "tere tulemast";
            //muul juhul konsoolis kuvatakse " vale kasutajatunnus või salasõna. Proovi uuesti!"

            Console.WriteLine("Sisestage kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&) või OR 

            //"admin" AND "admin1234" -- true
            //"admin1" AND "admin1234" -- false
            //"admin" AND "admin12345" -- false
            //"admin2" AND "admin4321" -- false

            if (userName =="admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või vale parool. Proovi uuesti.");
            }
        }
    }
}
