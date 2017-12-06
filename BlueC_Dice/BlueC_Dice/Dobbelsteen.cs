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

        public bool IsVerschilVan1(Dobbelsteen dobbelsteen)
        {
            int verschil = dobbelsteen.GetValue() - this.GetValue();
            return verschil == 1 || verschil == -1;
        }

        public override string ToString()
        {
            string[] displaynumbers = new string[]
            {
                $" -----\n\r "
              + " |1  |\n\r "
              + " |   |\n\r "
              + " |  o|\n\r "
              + " -----",

                " ----- "
              + " |o  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |3  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |4  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |5  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |o o|"
              + " |o o|"
              + " |o o|"
              + " -----"
            };

            int index = this.GetValue() - 1;

            return displaynumbers[index];
        }
    }
}
