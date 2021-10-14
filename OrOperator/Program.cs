﻿using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "tere tulemast";
            //muul juhul konsoolis kuvatakse " vale kasutajatunnus või salasõna. Proovi uuesti!"

            // OR (või) || (pipes)

            // true || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false

            Console.WriteLine("Sisestage kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus voi parool. Proovige uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            // "admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            // "admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
        }
    }
}
