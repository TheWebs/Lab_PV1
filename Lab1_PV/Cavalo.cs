using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    class Cavalo : Peca
    {
        public Cavalo(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "C";
            this.nome = "Cavalo";
        }

        public override String ToString()
        {
            return "C" + base.ToString();
        }

        public override void Deslocar(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
