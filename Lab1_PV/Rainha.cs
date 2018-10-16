using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Rainha : Peca
    {
        public Rainha(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "D";
            this.nome = "Rainha";
        }

        public override String ToString()
        {
            return "D" + base.ToString();
        }

        public override void Deslocar(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
