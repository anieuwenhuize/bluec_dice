using System;

namespace BlueC_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var hand = new Hand();

            while (true)
            {
                hand.Werp(1, 1, 6, 1, 1);

                Console.WriteLine(hand);
                Console.ReadLine();
            }
        }
    }
}
