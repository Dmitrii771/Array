using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex2
            //int i, kol = 0;
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //for (i = 0; i < numbers.Length; i++)
            //    if (numbers[i] > 0)
            //        kol++;
            //Console.Write(kol);
            #endregion
            #region Ex3
            int i;
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            for (i = 8; i != 0; i--)
            {
                Console.Write(numbers[i]);
                Console.Write(' ');
                #endregion
            }
        }
    }
}
