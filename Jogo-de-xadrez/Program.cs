using System;
using Jogo_de_xadrez.Tabuleiro;
namespace Jogo_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posicao: " + P);

            Console.ReadKey();
        }
    }
}
