using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Hand
    {
        private Dobbelsteen Dice1;
        private Dobbelsteen Dice2;
        private Dobbelsteen Dice3;
        private Dobbelsteen Dice4;
        private Dobbelsteen Dice5;
        private Dobbelsteen Dice6;

        public Hand()
        {
            this.Dice1 = new Dobbelsteen();
        }

        public void Werp()
        {
            this.Dice1.Roll();
            this.Dice2.Roll();
            this.Dice3.Roll();

            // en de rest mag je zelf doen.
        }

        public int GetValue()
        {
            // Geeft de waarde van alle dobbelstenen terug
            int waarde = this.Dice1.GetValue()
                + this.Dice2.GetValue();

            // de rest mag je zelf doen.

            return waarde;
        }
    }
}
