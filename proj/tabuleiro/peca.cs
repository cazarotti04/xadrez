using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class peca
    {
        public posicao pos { get; set; }
        public tabuleiro tab { get; protected set; }
        public cor cc { get; protected set; }
        public int qtmov { get; protected set; }

        public peca(posicao pos, tabuleiro tab, cor cc)
        {
            this.pos = pos;
            this.tab = tab;
            this.cc = cc;
            this.qtmov = 0;
        }
    }
}
