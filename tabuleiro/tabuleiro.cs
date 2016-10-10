using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class tabuleiro
    {
        private peca[,] pecas;
        public int linhas { get; set; }
        public int colunas { get; set; }

        public tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new peca[linhas, colunas];
        }
        public peca pp(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
