using System;
using System.Collections.Generic;
using SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Domain.Model
{
    public class CompraModel
    {
        public Guid Id { get; set; }

        public Money TotalCompra { get; set; }

        public List<Produto> Produtos { get; set; }

        public DateTime DataCompra { get; set; }
    }
}