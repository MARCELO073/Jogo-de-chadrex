using System;
using System.Collections.Generic;
using System.Text;



namespace Jogo_de_xadrez
{
    class Peca
    {
        public Posicao posicao { get;  set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
    }
}
