using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    class Bispo : Peca
    {
        public Bispo(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "B";
            this.nome = "Bispo";
        }

        public override String ToString()
        {
            return "B" + base.ToString();
        }

        // Desafio

        public override void Deslocar(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
