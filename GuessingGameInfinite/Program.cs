using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit 2ra arvama;
            //kui kasutaja suutis seda numbrit 2ra arvata, siis ta on m2ngu v6itnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit yhte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopactive = true;

            while (loopactive)
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
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                }
            }
            Console.WriteLine("Kena P2eva!");
        }
    }
}
