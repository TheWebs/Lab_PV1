using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Rei : Peca
    {
        public Rei(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "R";
            this.nome = "Rei";
        }

        public override String ToString()
        {
            return "R" + base.ToString();
        }

        public override void Deslocar(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
