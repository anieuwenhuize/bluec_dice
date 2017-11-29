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
            this.Dice2 = new Dobbelsteen();
            this.Dice3 = new Dobbelsteen();
            this.Dice4 = new Dobbelsteen();
            this.Dice5 = new Dobbelsteen();
            this.Dice6 = new Dobbelsteen();
        }

        public void Werp()
        {
            this.Dice1.Roll();
            this.Dice2.Roll();
            this.Dice3.Roll();
            this.Dice4.Roll();
            this.Dice5.Roll();
            this.Dice6.Roll();
        }

        public int GetValue()
        {
            // Geeft de waarde van alle dobbelstenen terug
            int waarde = this.Dice1.GetValue()
                + this.Dice2.GetValue()
                + this.Dice3.GetValue()
                + this.Dice4.GetValue()
                + this.Dice5.GetValue()
                + this.Dice6.GetValue();

            // de rest mag je zelf doen.

            return waarde;
        }
    }
}
