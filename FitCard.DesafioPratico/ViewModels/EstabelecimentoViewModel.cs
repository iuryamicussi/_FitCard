using FitCard.DesafioPratico.Annotations;
using FitCard.DesafioPratico.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitCard.DesafioPratico.ViewModels
{
    public class EstabelecimentoViewModel
    {
        [ReadOnly(true)]
        public int Id { get; set; }

        [DisplayName("Razão Social")]
        [MaxLength(100)]
        [Required]
        public string RazaoSocial { get; set; }

        [DisplayName("Nome Fantasia")]
        [MaxLength(100)]
        public string NomeFantasia { get; set; }

        [Required]
        [CnpjValidator]
        [MaxLength(18)]
        public string CNPJ { get; set; }

        [DisplayName("E-mail de Contato")]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Telefone { get; set; }

        [EnumDataType(typeof(Categoria))]
        public Categoria? Categoria { get; set; }

        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }
    
        [DisplayName("Agência")]
        [MaxLength(5)]
        public string Agencia { get; set; }

        [MaxLength(8)]
        public string Conta { get; set; }

    }
}