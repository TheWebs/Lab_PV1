using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Torre : Peca
    {
        public Torre(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "T";
            this.nome = "Torre";
        }

        public override String ToString()
        {
            return simbolo + base.ToString();
        }

        // Nível 4
        public override void Deslocar(int dx, int dy)
        {
            if (dx != 0 && dy != 0)
                return;
            posicao.x = ((char)(posicao.x + dx));
            posicao.y = (posicao.y + dy);
        }

    }
}
