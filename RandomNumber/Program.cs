using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on 5, programm l6petab oma t66d ja soovib kasutajale "kena p2eva"
            //kui genereeritud number on midagi muud, siis programm j2tkab oma t66d.

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena P2eva!");

        }
    }
}
