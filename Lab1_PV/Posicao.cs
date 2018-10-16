using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Posicao
    {
        public char x {get;set;} = 'a';
        public int y {get;set;} = '1';

        public Posicao(char x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Posicao(){}

        public override String ToString()
        {
            return "" + x + y;
        }

    }
}
