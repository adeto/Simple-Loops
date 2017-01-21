using System;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var left = 0;
            for (int i = 0; i < n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }

            var right = 0;
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }

            if (left == right)
            {
                Console.WriteLine("Yes, sum =" + left);
            }
            else 
            {
                Console.WriteLine("No, diff =" + Math.Abs(right - left));
            }

        }
    }
}
