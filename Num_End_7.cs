using System;

namespace _02.NumbersEnding7
{
    class Num_End_7
    {
        static void Main()
        {
            for (var i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
