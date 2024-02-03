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

        public CompraRepository Obter(Guid id)
        {
            return context.Set<Domain.Entidades.Compra>().Where(c=> c.Id == id).FirstOrDefault();
        }

        public void Registrar(CompraRepository entity)
        {
            context.Set<CompraRepository>().Add(entity);
        }

        
    }
}