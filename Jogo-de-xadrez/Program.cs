﻿using System;


namespace Jogo_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posicao: " + P);
            Tabuleiro tab = new Tabuleiro(8,8);

            Console.ReadKey();
        }
    }
}
