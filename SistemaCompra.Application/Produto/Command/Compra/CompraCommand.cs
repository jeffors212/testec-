using System;
using System.Collections.Generic;
using SistemaCompra.Domain.Model;

namespace SistemaCompra.Application.Produto.Command
{
    public class CompraCommand
    {
        public Guid Id { get; set; }
        public Money TotalCompra { get; set; }
        public List<Domain.ProdutoAggregate.Produto> Produtos { get; set; }
        public DateTime DataCompra { get; set; }
        
        
    }
}