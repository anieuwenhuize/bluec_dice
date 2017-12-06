using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Hand
    {
        private Dobbelsteen[] Dobbelstenen;

        public Hand()
        {
            // Manier 1: collection initializer
            this.Dobbelstenen = new Dobbelsteen[]
            {
                new Dobbelsteen(),
                new Dobbelsteen(),
                new Dobbelsteen(),
                new Dobbelsteen(),
                new Dobbelsteen(),
                new Dobbelsteen()
            };

            // Manier 2: for-statement
            int aantal = 6;
            this.Dobbelstenen = new Dobbelsteen[aantal];
            for(int i=0; i< aantal; i++)
            {
                this.Dobbelstenen[i] = new Dobbelsteen();
            }
        }

        public void Werp()
        {
            foreach(Dobbelsteen dobbelsteen 
                in this.Dobbelstenen)
            {
                dobbelsteen.Roll();
            }
        }

        public int GetValue()
        {
            // Manier 1: imperatief: HOE
            int totaalwaarde = 0;

            for(int i=0;i<this.Dobbelstenen.Length; i++)
            {
                Dobbelsteen huidigedobbelsteen = this.Dobbelstenen[i];

                totaalwaarde = totaalwaarde + huidigedobbelsteen.GetValue();
            }

            return totaalwaarde;
            
            // Manier 2: declaratief: WAT
            int result =
                this.Dobbelstenen

                    // Geef van iedere dobbelsteen de waarde terug
                    .Select(dobbelsteen => dobbelsteen.GetValue())

                    // Tel al deze waardes op
                    .Count();

            return result;
        }
    }
}
