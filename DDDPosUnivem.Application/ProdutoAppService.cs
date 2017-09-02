using DDDPosUnivem.Application.Interfaces;
using DDDPosUnivem.Domain.Entities;
using DDDPosUnivem.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDPosUnivem.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IProdutoService produtoservice) 
            : base(produtoservice)
        {
            _produtoService = produtoservice;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
