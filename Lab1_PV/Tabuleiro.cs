using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_PV
{
    public class Tabuleiro
    {
        private Peca[,] tabuleiro;

        public Tabuleiro()
        {
            tabuleiro = new Peca[8, 8];

            for (int x = 0; x < 8; x++)
            {
                tabuleiro[x, 1] = new Peao(true, new Posicao((char)('a' + x), 2));
                tabuleiro[x, 6] = new Peao(false, new Posicao((char)('a' + x), 7));
            }
            int line = 1;
            bool isBranca = true;
            tabuleiro[0, 0] = new Torre(isBranca, new Posicao('a', line));
            tabuleiro[1, 0] = new Cavalo(isBranca, new Posicao('b', line));
            tabuleiro[2, 0] = new Bispo(isBranca, new Posicao('c', line));
            tabuleiro[3, 0] = new Rainha(isBranca, new Posicao('d', line));
            tabuleiro[4, 0] = new Rei(isBranca, new Posicao('e', line));
            tabuleiro[5, 0] = new Bispo(isBranca, new Posicao('f', line));
            tabuleiro[6, 0] = new Cavalo(isBranca, new Posicao('g', line));
            tabuleiro[7, 0] = new Torre(isBranca, new Posicao('h', line));

            line = 8;
            isBranca = false;
            tabuleiro[0, 7] = new Torre(isBranca, new Posicao('a', line));
            tabuleiro[1, 7] = new Cavalo(isBranca, new Posicao('b', line));
            tabuleiro[2, 7] = new Bispo(isBranca, new Posicao('c', line));
            tabuleiro[3, 7] = new Rainha(isBranca, new Posicao('d', line));
            tabuleiro[4, 7] = new Rei(isBranca, new Posicao('e', line));
            tabuleiro[5, 7] = new Bispo(isBranca, new Posicao('f', line));
            tabuleiro[6, 7] = new Cavalo(isBranca, new Posicao('g', line));
            tabuleiro[7, 7] = new Torre(isBranca, new Posicao('h', line));
        }

        public void Mostrar()
        {
            for (int y = 7; y >= 0; y--)
            {
                Console.Write(y + 1 + "  ");
                for (int x = 0; x < 8; x++)
                {
                    Peca peca = tabuleiro[x, y];
                    if (peca == null)
                    {
                        Console.Write("  ");
                        continue;
                    }
                    if (peca.corBranca)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca.simbolo + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
        }

        public void AtualizarTabuleiro()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tabuleiro[i, j] != null)
                    {
                        int x = tabuleiro[i, j].posicao.x - 97;
                        int y = tabuleiro[i, j].posicao.y - 1;
                        if (x != i || y != j)
                        {
                            tabuleiro[x, y] = tabuleiro[i, j];
                            tabuleiro[i, j] = null;
                        }
                    }
                }
            }
        }

        public void PecaMovimentada(Peca p)
        {
            Console.Clear();
            AtualizarTabuleiro();
            Mostrar();
        }

        public Peca this[char x, int y]
        {
            get { return tabuleiro[x-97, y]; }
            set { tabuleiro[x, y] = value; }
        }
    }


}
