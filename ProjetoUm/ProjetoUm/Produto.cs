using System;
using System.Globalization;

namespace ProjetoUm {
    class Produto {

        //public string Nome;
        //public double Preco;
        //public int Quantidade;

        
        //atributos privados
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }



        //construtor padrao
        public Produto() {

        }

        // construtor
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }

            }
        }


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }


        public override string ToString() {
            return _nome
                    + ", $ "
                    + Preco.ToString("f2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantidade
                    + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);

        }

    }
}
