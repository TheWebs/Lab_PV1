﻿using System;
using Lab1_PV;

namespace Lab1_PV
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nível 1
            Console.WriteLine("    Nível 1    \n");

            Posicao pos1 = new Posicao { x = 'e', y = 7 }; //posicao x e y
            Posicao pos2 = new Posicao { };

            Console.WriteLine("Posicao: " + pos1);
            Console.WriteLine("Posicao: " + pos2.x + pos2.y);

            Console.ReadKey();

            // Nível 2
            Console.Clear();
            Console.WriteLine("    Nível 2    \n");

            Peao p1 = new Peao(false, new Posicao('e', 5));
            Peao p2 = new Peao(true, new Posicao());
            p2.SetPosicao('d', 2);

            Console.WriteLine("Peão 1 - " + p1);
            Console.WriteLine("Peão 2 - " + p2);

            Console.Write("Peão 1 na posicao: ");
            Console.WriteLine("" + p1.posicao.x + p1.posicao.y);

            Console.Write("Peão 2 na posicao: ");
            Console.WriteLine("" + p2.posicao.x + p2.posicao.y);

            Torre t1 = new Torre(true, pos2);

            Console.WriteLine("Torre - " + t1);
            Console.ReadKey();

            // Nível 3
            Console.Clear();
            Console.WriteLine("    Nível 3    \n");

            Peca[] pecas = new Peca[] { p1, p2, t1 };
            Console.WriteLine("Peças no array:");

            foreach (Peca peca in pecas)
                Console.WriteLine(peca.nome);

            Console.ReadKey();

            // Nível 4
            Console.Clear();
            Console.WriteLine("    Nível 4    \n");

            Console.WriteLine("Torre - " + t1);
            Console.WriteLine("Mover a Torre dx=2");
            t1.Deslocar(2, 0);
            Console.WriteLine("Torre - " + t1);
            Console.WriteLine("Mover a Torre dy=1");
            t1.Deslocar(0, 1);
            Console.WriteLine("Torre - " + t1);
            Console.WriteLine("Mover a Torre dx=3 e dy=3");
            t1.Deslocar(3, 3);
            Console.WriteLine("Torre - " + t1);

            Console.WriteLine("Peão - " + p1);
            Console.WriteLine("Mover o Peão dx=1");
            p1.Deslocar(1, 0);
            Console.WriteLine("Peão - " + p1);
            Console.WriteLine("Mover o Peão dy=1");
            p1.Deslocar(0, 1);
            Console.WriteLine("Peão - " + p1);
            Console.WriteLine("Mover o Peão dx=1 e dy=1");
            p1.Deslocar(1, 1);
            Console.WriteLine("Peão - " + p1);

            Console.ReadKey();

            // Nível 5
            Console.Clear();
            Console.WriteLine("    Nível 5    \n");

            Console.WriteLine("Peão - " + p1);
            Console.WriteLine("Mover o Peão p1++");
            p1++;
            Console.WriteLine("Peão - " + p1);

            Console.ReadKey();

            // Desafio
            Console.Clear();
            Console.WriteLine("    Desafio    \n");

            Tabuleiro tabuleiro = new Tabuleiro();
            tabuleiro.Mostrar();

            Console.ReadKey();
            Console.Clear();

            Peca pica = new Torre(true, pos1);
            string nome = pica.nome;
            Console.WriteLine(nome.AppendColor(pica));

            Console.ReadKey();
            Console.Clear();

            for (char i = 'a'; i < 'h'; i++)
                Console.Write(tabuleiro[i, 0].nome + " ");

            Console.ReadKey();
            Console.Clear();

            Peca.Moved m = p1.Move;
            m(p1);
            m(t1);

            Console.ReadKey();
            Console.Clear();

            m += tabuleiro.PecaMovimentada;
            m(p1);
            tabuleiro['e', 1].Deslocar(0, 2);
            Console.ReadKey();
            m(t1);


            Console.ReadKey();
            Console.Clear();
        }
    }
}
