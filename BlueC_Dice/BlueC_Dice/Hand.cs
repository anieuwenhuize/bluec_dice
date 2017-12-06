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
                new Dobbelsteen()
            };

            // Manier 2: for-statement
            //int aantal = 5;
            //this.Dobbelstenen = new Dobbelsteen[aantal];
            //for(int i=0; i< aantal; i++)
            //{
            //    this.Dobbelstenen[i] = new Dobbelsteen();
            //}
        }

        private bool ZijnWaardesAaneengesloten()
        {
            var ordered = this.Dobbelstenen
                .OrderBy(dobbelsteen => dobbelsteen.GetValue());

            Dobbelsteen vorige = null;
            foreach(Dobbelsteen dobbelsteen in this.Dobbelstenen)
            {
                if(vorige == null)
                {
                    vorige = dobbelsteen;
                    continue;
                }

                if(!dobbelsteen.IsVerschilVan1(vorige))
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        private int GeefAantalVerschillende()
        {
            var aantalVerschillende =
                this.Dobbelstenen
                    .GroupBy(x => x.GetValue())
                    .Select(x => x.First())
                    .Count();

            return aantalVerschillende;
        }

        public bool IsYathzee()
        {
            return this.GeefAantalVerschillende() == 1;
        }

        public void Werp()
        {
            foreach(Dobbelsteen dobbelsteen 
                in this.Dobbelstenen)
            {
                dobbelsteen.Roll();
            }
        }

        public void Werp(
            int waarde1,
            int waarde2,
            int waarde3,
            int waarde4,
            int waarde5
            )
        {
            this.Dobbelstenen[0].Roll(waarde1);
            this.Dobbelstenen[1].Roll(waarde2);
            this.Dobbelstenen[2].Roll(waarde3);
            this.Dobbelstenen[3].Roll(waarde4);
            this.Dobbelstenen[4].Roll(waarde5);
        }

        public int GetValue()
        {
            // Manier 1: imperatief: HOE
            //int totaalwaarde = 0;

            //for(int i=0;i<this.Dobbelstenen.Length; i++)
            //{
            //    Dobbelsteen huidigedobbelsteen = this.Dobbelstenen[i];

            //    totaalwaarde = totaalwaarde + huidigedobbelsteen.GetValue();
            //}

            //return totaalwaarde;
            
            // Manier 2: declaratief: WAT
            int result =
                this.Dobbelstenen

                    // Geef van iedere dobbelsteen de waarde terug
                    .Select(dobbelsteen => dobbelsteen.GetValue())

                    // Tel al deze waardes op
                    .Count();

            return result;
        }

        public override string ToString()
        {
            // als er niets bijzonders is
            // alle onafhankelijke waarden laten zien
            var waardes = this.Dobbelstenen
                .Select(dobbelsteen => dobbelsteen.GetValue());

            string result = "";
            foreach(int waarde in waardes)
            {
                result += $" {waarde}";
            }

            if (IsYathzee())
            {
                result += "YATHZEE!!";
            }

            return result;
        }
    }
}
