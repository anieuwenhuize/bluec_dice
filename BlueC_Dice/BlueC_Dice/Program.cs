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
                hand.Werp(2, 3, 4, 5, 6);

                Console.WriteLine(hand);
                Console.ReadLine();
            }
        }
    }
}
