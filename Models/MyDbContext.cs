using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_APS.Models
{
     public class MyDbContext: DbContext
    {
  public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
            public DbSet<Cliente>? Clientes { get; set; }
            public DbSet<Item>? Items { get; set; } = null!;

            public DbSet<Marca>? Marcas { get; set; } = null!;

            public DbSet<NotaDeVenda>? NotaDeVendas { get; set; }
            public DbSet<Pagamento>? Pagamentos { get; set; }
            public DbSet<PagamentoComCartao>? PagamentosComCartao { get; set; }
            public DbSet<PagamentoComCheque>? PagamentosComCheque { get; set; }
            public DbSet<Produto>? Produtos { get; set; } = null!;

            public DbSet<TipoPagamento>? TipoPagamentos { get; set; }
            public DbSet<Transportadora>? Tranportadoras { get; set; }
            public DbSet<Vendedor>? Vendedores { get; set; }

        
    }
    
}