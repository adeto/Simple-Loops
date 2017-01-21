using System;

namespace _04.SumNumbers
{
    class SumNums
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = num + sum;

            }
            Console.WriteLine(""+ sum);
        }
    }
}
