using System;
using tabuleiro;

namespace proj
{
    class tela
    {
        public static void imprimirtabuleiro(Tabuleiro tab)
        {
            for(int i=0; i<tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.pp(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tab.pp(i, j) +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
