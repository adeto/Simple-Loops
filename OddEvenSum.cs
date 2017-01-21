using System;

namespace _08.Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var odd = 0;
            var even = 0;

            for(var i=0; i <n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) odd += element;
                else even += element;
            }
            if (odd == even)
            {
                Console.WriteLine("Yes, sum = " + odd);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(odd - even));
            }
        }
    }
}
