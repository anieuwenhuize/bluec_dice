using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Dobbelsteen
    {
        private int Waarde;
        private int AantalVlakken;
        private Random Rand;

        public Dobbelsteen()
        {
            this.Waarde = 2;
            this.AantalVlakken = 6;
            this.Rand = new Random();
        }

        public void Roll()
        {
            int next = this.Rand.Next(1, 99);
            this.Waarde += next;
        }

        public int GetValue()
        {
            return (this.Waarde % this.AantalVlakken) + 1;
        }

        public override string ToString()
        {
            if(this.GetValue() == 1)
            {
                return $".";
            }

            return $"2-6";
        }
    }
}
