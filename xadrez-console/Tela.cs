using System;
using tabuleiro;
namespace xadrez_console {
    class Tela {

        public static void imprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i < tab.numLinhas; i++){
                for(int j = 0; j < tab.numColunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("o ");
                    }
                    else {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
