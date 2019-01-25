using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitCard.DesafioPratico.Repositorios.Entity
{
    public class CustomValidationException : Exception
    {
        public string NomeCampo { get; set; }
        public CustomValidationException(string nomeCampo, string message) : base(message)
        {
            this.NomeCampo = nomeCampo;
        }

        
    }
}
