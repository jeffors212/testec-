using System;
using System.Linq;
using SistemaCompra.Domain.Entidades;
using SistemaCompra.Domain.Model;
using SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Application.ViewModel
{
    public class ProdutoViewModel
    {
        public string Categoria{ get;  set; }
        public Money Preco{ get;  set; }
        public string Nome{ get;  set; }
        public string Descricao{ get;  set; }
        public string Situacao{ get;  set; }
    }
    
    public static ProdutoViewModel Mapear(Domain.ProdutoAggregate.Produto produto)
    {
        return new ProdutoViewModel()
        {
            Categoria =Formatar<Categoria>((int)produto.Categoria),
            Preco = produto.Preco,
            Nome = produto.Nome,
            Descricao = produto.Descricao,
            Situacao = Formatar<Situacao>((int)produto.Situacao)
            
             
            
        };
    }
    public static string Formatar<T>(int value) where T : Enum
    {
        var name = Enum.GetName(typeof(T), value);

        if (name == null) return string.Empty;

        var enums = name.Split('_');

        var caps = enums.Select(CapitalizeString);

        return string.Join(" ", caps);
    }

    private static string CapitalizeString(string name)
    {
        return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
    }
}