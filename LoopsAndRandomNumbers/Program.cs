using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada PIN-koodi
            //programm v6rdleb sisestatud pin-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti"
            //Kasutajal on kolm katset. i < 3

            int i = 0; //i - iteration

            while(i < 3) //while-loop
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    //(i = i + 1) == i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on j22nud.");
                }
            }
            Console.WriteLine("Kena p2eva!");
        }
    }
}
