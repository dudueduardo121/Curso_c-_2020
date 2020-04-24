using System.Collections.Generic;
using System.Text;
using ExercicioComposicao.Entidades.Enums;

namespace ExercicioComposicao.Entidades {
    class Trabalhador {
        public string Nome { get; set; }
        public Cargos TipoCargos { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } // Assoiciar duas classes diferentes Departamento ao Trabalhador
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>(); //Associar lista de trabalhador ao contratos e ja instancia para não ser vazia

        public Trabalhador() {
        }

        public Trabalhador(string nome, Cargos tipoCargos, double salarioBase, Departamento departamento) {
            Nome = nome;
            TipoCargos = tipoCargos;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        // Operação para adicionar contrato para cada trabalhador.
        public void AddContrato(HorasContrato Contrato) {
            Contratos.Add(Contrato);
        }

        // Operação para remover contrato do trabalhador
        public void RemoveContrato(HorasContrato Contrato) {
            Contratos.Remove(Contrato);
        }

        public double GanhoSalarial(int Ano, int Mes) {
            double soma = SalarioBase;
            // Para cada Horas de Contratos na lista de contratos executa...
            foreach(HorasContrato Contrato in Contratos) {
                // Se o ano e o mês for igual ao passado no argumento contrato entra na soma
                if(Contrato.Data.Year == Ano && Contrato.Data.Month == Mes) {
                    soma += Contrato.TotalValor();
                }
            }

            return soma;

        }
    }
}
