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

                int waarde = hand.GetValue();

                Console.WriteLine(waarde);
                Console.ReadLine();
            }
        }
    }
}
