using System;


namespace Jogo_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
     
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);
            
            Console.ReadKey();
        }
    }
}
