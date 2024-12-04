using Microsoft.AspNetCore.Mvc;
using RelatoriosAPI.Models;
using System.Collections.Generic;

namespace RelatoriosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatorioController : ControllerBase
    {
        // Simulação de banco de dados
        private static readonly List<Relatorio> Relatorios = new List<Relatorio>
        {
            new Relatorio { Id = 1, IdUsuario=1, Descricao = "Relatório de Vendas", Valor = 100 },
            new Relatorio { Id = 2, IdUsuario=1, Descricao = "Relatório de Estoque", Valor = 50 },
            new Relatorio { Id = 3, IdUsuario=2, Descricao = "Relatório Financeiro", Valor = 200 }
        };

        // Método para obter relatórios
        [HttpGet("{userId}")]
        public ActionResult<List<Relatorio>> GetRelatorios(int userId)
        {
            return RelatorioController.Relatorios.Where(item =>
            {

                return item.IdUsuario == userId;
            }).ToList(); 
        }
    }
}
