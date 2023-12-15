using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_APS.Models
{
    public class NotaDeVenda
    {
       [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Data")]
        public DateTime Data { get; set; }
        [Display(Name = "Tipo")]
        public bool Tipo { get; set; }



        public Cliente? Cliente { get; set; }
        [Display(Name = "Cliente"), ForeignKey("Cliente")]
        public int? ClienteId { get; set; }


        public Vendedor? Vendedor { get; set; }
        [Display(Name = "Vendedor"), ForeignKey("Vendedor")]
        public int? VendedorId { get; set; }


        public Transportadora? Transportadora { get; set; }
        [Display(Name = "Transportadora"), ForeignKey("Transportadora")]
        public int? TransportadoraId { get; set; }


        public TipoPagamento? TipoPagamento { get; set; }
        [Display(Name = "Tipo de Pagamento"), ForeignKey("TipoDePagamento")]
        public int? TipoDePagamentoId { get; set; }
        public ICollection<Item> Itens { get; set; } = new List<Item>();
        public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        

        public void Cancelar()
        {
            if (this.Tipo == true)
            {
                throw new Exception("Nota de venda  cancelada!");
            }
            else
            {
                this.Tipo = true;
            }
        }

        public void Devolver() 
        {
            if (this.Tipo == false)
            {
                throw new Exception("Nota de Venda  devolvida!");
            }
            else
            {
                this.Tipo = false;
            }
        }

    
    }
}