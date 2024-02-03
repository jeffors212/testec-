using System;
using System.Linq;
using SistemaCompra.Domain.Entidades;
using SistemaCompra.Domain.Model;
using SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Application.ViewModel
{
    public class ProdutoViewModel
    {
        public int Categoria { get; set; }
        public Money Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Situacao { get; set; }

        public static ProdutoViewModel Mapear(Domain.ProdutoAggregate.Produto produto)
        {
            return new ProdutoViewModel()
            {
                Categoria = (int)produto.Categoria,
                Preco = produto.Preco,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Situacao = (int)produto.Situacao
            };
        }
    }
}