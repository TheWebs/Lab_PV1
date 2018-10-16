using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Peao : Peca
    {
        public Peao(bool corBranca, Posicao posicao) : base(corBranca, posicao)
        {
            this.simbolo = "P";
            this.nome = "Peão";
        }      

        public override void Deslocar(int dx, int dy)
        {
            posicao.y = (posicao.y + dy);
        }

        public static Peao operator ++(Peao peao)
        {
            peao.Deslocar(0, 1);
            return peao;
        }
    }
}
