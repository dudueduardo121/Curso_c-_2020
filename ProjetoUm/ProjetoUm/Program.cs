using System;
using System.Globalization;


namespace ProjetoUm {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numconta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Hávera depósito? (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                double vlDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numconta, titular, vlDeposito);
           
            }else if (resp == 'n' || resp == 'N') {
                conta = new ContaBancaria(numconta, titular);
            }
            else {
                Console.WriteLine("Opção invalida!");
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Entre com o valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor para Saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);



































            // ECERCICI ALUNOS

            //Aluno al = new Aluno();

            //Console.Write("Digite o nome do aluno: ");
            //al.NomeAluno = Console.ReadLine();
            //Console.WriteLine("Digite as três notas do aluno:");
            //al.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //al.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //al.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("NOTA FINAL = " + al.NotaFinal() + " pontos");

            //if (al.Aprovado()) {
            //    Console.WriteLine("APROVADO");
            //}
            //else {
            //    Console.WriteLine("REPROVADO");
            //    Console.WriteLine("FALTARAM " + al.NotaRestante().ToString("f2", CultureInfo.InvariantCulture) + " PONTOS");
            //}






            // EXERCICIO FUNCIONARIO

            //Funcionario func = new Funcionario();

            //Console.Write("Entre com o nome do funcionario: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Entre com o salário bruto: ");
            //func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Entre com o valor do imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //func.SalarioLiquido();

            //Console.WriteLine();
            //Console.WriteLine("Funcionário: " + func);

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagemExtra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //func.AumentarSalario(porcentagemExtra);

            //Console.WriteLine();
            //Console.WriteLine("Dados Funcionário Atualizados: " + func);




















            // Exercicio Retangulo

            //Retangulo ret = new Retangulo();

            //Console.Write("Entre com a largura: ");
            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Entre com a Altura: ");
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Area();
            //ret.Perimetro();
            //ret.Diagonal();

            //Console.WriteLine(ret);




            //Console.WriteLine("Entre com os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////Console.Write("Quantidade no estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome,preco);

            //Produto p1 = new Produto();

            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados Atualizados: " + p);

            //Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.Write("Dados Atualizados: " + p);



            //Encapisulamento

            //Produto p = new Produto("tv", 500.00, 10);

            //p.Nome = "T";

            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Preco);
            //Console.WriteLine(p.Quantidade);




        }
    }
}
