using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
        }
        static void Swap(ref int getal1, ref int getal2)
        {
            int tempSwap = getal1;
            getal1 = getal2;
            getal2 = tempSwap;
            Console.WriteLine("{0} is nu getal1, {1} is nu getal2", getal1, getal2);
        }
    }
}
