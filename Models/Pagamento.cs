using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_APS.Models
{
    public class Pagamento
    {
         [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        [Display(Name = "Pago")]
        public bool Pago { get; set; }

        
        public NotaDeVenda? NotaDeVenda { get; set; } = null!;
        [Display(Name = "Nota de Venda"), ForeignKey("NotaDeVenda")]
        public int? NotaDeVendaId { get; set; }  = null!;
    }
}