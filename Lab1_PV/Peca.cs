using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public abstract class Peca : IMover
    {

        public delegate void Moved(Peca p);

        public bool corBranca {get;set;}
        public readonly Posicao posicao;

        // Desafio
        public string simbolo {get;set;} = "";

        public string nome {get;set;} = "";

        public Peca(bool corBranca, Posicao posicao)
        {
            this.corBranca = corBranca;
            if (posicao != null)
            {
                this.posicao = posicao;
            }
            else
            {
                this.posicao = new Posicao();
            }
        }

        public void Move(Peca p)
        {
            Console.WriteLine(p.nome + " moveu-se!");
        }

        public void SetPosicao(char x, int y)
        {
            posicao.x = x;
            posicao.y = y;
        }

        public override String ToString()
        {
            return posicao.ToString();
        }

        // Nível 3
        public virtual string GetNome()
        {
            return "desconhecida";
        }


        // Nível 4
        public abstract void Deslocar(int dx, int dy);

    }
}