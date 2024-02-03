using System;
using System.Linq;
using SistemaCompra.Domain.ProdutoAggregate;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.Compra
{
    public class CompraRepository : ICompraRepository
    {
        private readonly SistemaCompraContext context;

        public CompraRepository(SistemaCompraContext context)
        {
            this.context = context;
        }
        
        public void Atualizar(CompraRepository entity)
        {
            context.Set<CompraRepository>().Update(entity);
        }
        
        public void Excluir(CompraRepository entity)
        {
            context.Set<CompraRepository>().Remove(entity);
        }

        public Domain.Entidades.Compra Obter(Guid id)
        {
            return context.Set<Domain.Entidades.Compra>().FirstOrDefault(c => c.Id == id);
        }

        public void Registrar(Domain.Entidades.Compra entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Domain.Entidades.Compra entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Domain.Entidades.Compra entity)
        {
            throw new NotImplementedException();
        }

        public void Registrar(CompraRepository entity)
        {
            context.Set<CompraRepository>().Add(entity);
        }

        
    }
}