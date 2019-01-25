using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitCard.DesafioPratico.Dominio
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataCadastro { get; set; }
        public Categoria? Categoria { get; set; }
        public Status? Status { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    }
}
