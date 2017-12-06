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
                hand.Werp();

                Console.WriteLine(hand);
                Console.ReadLine();
            }
        }
    }
}
