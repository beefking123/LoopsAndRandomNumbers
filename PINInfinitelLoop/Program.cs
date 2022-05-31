﻿using System;

namespace PINInfinitelLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada PIN-koodi
            //programm v6rdleb sisestatud pin-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti"
            //katsete arv on piiramatu.

            bool loopactive = true; //boolean --> true/false
            int i = 0;

            while(loopactive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw + double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    i++; // i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud");
                }
            }
            Console.WriteLine("Kena P2eva!");
        }
    }
}
