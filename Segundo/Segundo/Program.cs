using System;
using System.Globalization;

namespace Segundo {
    class Program {
        static void Main(string[] args) {

            //Funcionarios func1, func2;

            //func1 = new Funcionarios();
            //func2 = new Funcionarios();
            //double salarioMedio;

            //Console.WriteLine("Cadastro 01");
            //Console.Write("Nome do funcionario:");
            //func1.nome = Console.ReadLine();
            //Console.Write("Salário do funcionario:");
            //func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("\n");

            //Console.WriteLine("Cadastro 02");
            //Console.Write("Nome do funcionario:");
            //func2.nome = Console.ReadLine();
            //Console.Write("Salário do funcionario:");
            //func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("\n");

            //salarioMedio = (func1.salario + func2.salario) / 2;

            //Console.WriteLine("primeiro cadastro: ");
            //Console.WriteLine("nome: " + func1.nome);
            //Console.WriteLine("salario: " + func1.salario.ToString("f2", CultureInfo.InvariantCulture));

            //Console.WriteLine("\n");

            //Console.WriteLine("segundo cadastro: ");
            //Console.WriteLine("nome: " + func2.nome);
            //Console.WriteLine("salario: " + func2.salario.ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine("\n");
            //Console.WriteLine("Salário médio = " + salarioMedio.ToString("f2", CultureInfo.InvariantCulture));










            //--------------------------------------------------------------------------------------------------------------------------------------------

            //Pessoas p1, p2;

            //p1 = new Pessoas();
            //p2 = new Pessoas();


            //Console.WriteLine("Cadatro 01:");
            //Console.Write("Digite um nome: ");
            //p1.nome = Console.ReadLine();
            //Console.Write("Digite a idade: ");
            //p1.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");

            //Console.WriteLine("Cadatro 02:");
            //Console.Write("Digite um nome: ");
            //p2.nome = Console.ReadLine();
            //Console.Write("Digite a idade: ");
            //p2.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n");

            //Console.WriteLine("Dados da primeira Pessoa:");
            //Console.WriteLine($"Nome: {p1.nome}");
            //Console.WriteLine($"Idade: {p1.idade}");

            //Console.WriteLine("\n");

            //Console.WriteLine("Dados da segunda Pessoa:");
            //Console.WriteLine($"Nome: {p2.nome}");
            //Console.WriteLine($"Idade: {p2.idade}");

            //if (p1.idade > p2.idade) {
            //    Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            //}
            //else {
            //    Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            //}


            //-----------------------------------------------------------------------------------------------------------------------------------



            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaX) {
                Console.WriteLine("area maior triangulo X");
            }
            else {
                Console.WriteLine("area maior triangulo Y");
            }


        }
    }
}
