using System;
using System.Collections.Generic;
using System.Linq;
using SistemaCompra.Domain.Entidades;
using SistemaCompra.Domain.Model;

namespace SistemaCompra.Application.ViewModel
{
    public class CompraViewModel
    {
        public Guid Id { get; set; }

        public Money TotalCompra { get; set; }

        public List<Domain.ProdutoAggregate.Produto> Produtos { get; set; }

        public DateTime DataCompra { get; set; }
        
        public IEnumerable<ProdutoViewModel> Produto { get; set; }
    }
    
    public static CompraViewModel Mapear(Compra compra)
    {
        return new CompraViewModel()
        {
            Id = compra.Id,
            TotalCompra = compra.TotalCompra,
             DataCompra = compra.DataCompra,
             Produtos = compra.Produtos.Select(ProdutoViewModel.Mapear)
             
            
        };
    }

}


