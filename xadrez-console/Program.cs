using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {


                Tabuleiro tab = new Tabuleiro(8, 8);


                tab.colocarPeca(new Torre(tab, Cor.Verde), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Amarela), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);
            }catch(tabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
