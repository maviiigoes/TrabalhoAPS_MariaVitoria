using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_APS.Models
{
    public class PagamentoComCheque : TipoPagamento 
    {
         [Display(Name = "Número do Cheque")]
        public int Banco { get; set; }
        [Display(Name = "Nome do Banco")]
        public string NomeDoBanco { get; set; } = string.Empty;
    }
}