using System;
using System.Collections.Generic;
using SistemaCompra.Domain.Model;
using SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Domain.Entidades
{
    public class Compra
    {
        public Guid Id { get; set; }

        public Money TotalCompra { get; set; }

        public List<Produto> Produtos { get; set; }

        public DateTime DataCompra { get; set; }

        public Compra(Guid id, Money totalCompra, List<Produto> produtos, DateTime dataCompra)
        {
            Id = id;
            TotalCompra = totalCompra;
            Produtos = produtos;
            DataCompra = dataCompra;
        }
    }
}