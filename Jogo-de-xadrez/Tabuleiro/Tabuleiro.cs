using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_de_xadrez
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunha { get; set; }
        private Peca [,] pecas;

        public Tabuleiro(int linhas, int colunhas)
        {
            this.linha = linha;
            this.colunha = colunha;
            pecas = new Peca [linhas, colunhas];
        }
        


    }
}
