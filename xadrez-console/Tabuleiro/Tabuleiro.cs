
namespace tabuleiro {
    class Tabuleiro {

        public int numLinhas { get; set; }
        public int numColunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int numLinhas, int numColunas) {
            this.numLinhas = numLinhas;
            this.numColunas = numColunas;
            pecas = new Peca[numLinhas, numColunas];
        }
    }
}
