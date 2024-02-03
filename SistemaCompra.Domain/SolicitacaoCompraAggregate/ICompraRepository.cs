using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaCompra.Domain.Entidades;
using SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public interface ICompraRepository
    {
        Compra Obter(Guid id);
        void Registrar(Compra entity);
        void Atualizar(Compra entity);
        void Excluir(Compra entity);
        
    }
}