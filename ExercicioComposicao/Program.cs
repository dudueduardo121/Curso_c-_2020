using System;
using ExercicioComposicao.Entidades;
using System.Globalization;
using ExercicioComposicao.Entidades.Enums;


namespace ExercicioComposicao {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o nome do departamento: ");
            string NomeDepartamento = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Funcionario: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Pleno/Senhor): ");
            Cargos cargo = Enum.Parse<Cargos>(Console.ReadLine());
            Console.Write("Salario Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // instanciar os objetos Departamento e Trabalhador
            Departamento dep = new Departamento(NomeDepartamento);
            Trabalhador func = new Trabalhador(nome, cargo, salarioBase, dep);

            Console.WriteLine("Quantos Contratos irá cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Entre #{i} Contrato data: ");
                Console.WriteLine("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor Hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                // instaciar um contrato
                HorasContrato contrato = new HorasContrato(data, valorHora, horas);
                func.AddContrato(contrato);// adicionar contrato para o trabalhador

            }
            Console.WriteLine();
            Console.Write("Entre com o Mês e Ano para calcular o ganho: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("Nome Funcionario:" + func.Nome);
            Console.WriteLine("Departamento: " + func.Departamento.Name);
            Console.WriteLine("Renda anual: " + mesAno + ": " + func.GanhoSalarial(ano, mes));
        }
    }
}
