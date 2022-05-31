using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit 2ra arvama;
            //kui kasutaja suutis seda numbrit 2ra arvata, siis ta on m2ngu v6itnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit 2ra arvuti;
            //siis arvuti v6idab.
            //programm genereerib juhuslikku numbrit yhte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == cpuNumber)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. Teil on {3 - i} katset j22nud.");
                }
            }
            Console.WriteLine("Olete parooli sisestanud 3 korda valesti. Head aega!");
        }
    }
}

        
    

