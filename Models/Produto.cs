using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_APS.Models
{
    public class Produto
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Descricao { get; set; } = string.Empty;
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Marca")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Descrição")]
        public Marca? Marca { get; set; } 
        [Display(Name = "Marca"), Required(), ForeignKey("Marca")]

        
        public int MarcaId { get; set; }
        [Display(Name = "Itens")]
        public ICollection<Item> Itens { get; set; } = new List<Item>();
    }
}