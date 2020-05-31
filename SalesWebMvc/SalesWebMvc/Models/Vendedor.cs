using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo Nome deve ser preenchido.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do nome deve ser entre 3 e 60 caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]

        [Required(ErrorMessage = "Campo Email deve ser preenchido.")]
        [EmailAddress(ErrorMessage = "Entre com um Email valido")]
        public string Email { get; set; }


        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]
        [Required(ErrorMessage = "Campo Data Nascimento deve ser preenchido.")]
        public DateTime DataNascimento { get; set; }


        [Display(Name ="Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "Campo Salario Base deve ser preenchido.")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} e {2}")]
        public double SalarioBase { get; set; }


        public Departamento Departamento { get; set; }
        [Display(Name ="Departamento")]


        public int DepartamentoId { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }
        public void RemoveVenda(RegistroVendas venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            // filtra a venda por data e calcula soma das vendas
            return Vendas.Where(venda => venda.Data >= inicial && venda.Data <= final).Sum(venda => venda.Montante);
        }
    }
}
