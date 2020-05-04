
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

        public Peca peca(int numlinha, int numcoluna) {
            return pecas[numlinha, numcoluna];
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        public bool exixtepeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (exixtepeca(pos)) {
                throw new tabuleiroException("Já existe uma peça na posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }



        public bool posicaoValida(Posicao pos) {
            if(pos.linha < 0 || pos.linha >= numLinhas || pos.coluna < 0 || pos.coluna >= numColunas) {
                return false;
            }
            return true;

        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new tabuleiroException("posição invalida!");
            }
        }
    }
}
