using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Dobbelsteen
    {
        private int Waarde;
        private int AantalVlakken;

        public Dobbelsteen()
        {
            this.Waarde = 2;
            AantalVlakken = 6;
        }

        public void Roll()
        {
            this.Waarde += 1;
        }

        public int GetValue()
        {
            return (Waarde % AantalVlakken) + 1;
        }
    }
}
