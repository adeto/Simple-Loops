using System;

namespace _05.MaxNumber
{
    class MaxNums
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var max = -10000000000000;

            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
                {
                    Console.WriteLine("" + max);
                }
              
            }
        }
    }
}
