using Microsoft.AspNetCore.Mvc;
using RelatoriosAPI.Models;

namespace RelatoriosAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller")]
    public class RelatorioController : ControllerBase
    {

        //teste simulação Banco de dados 
        private static readonly List<Relatorio> Relatorios = new List<Relatorio>
        {
            new Relatorio { Id = 1, Descricao = "Relatório de Vendas", Valor = 100.0m },
            new Relatorio { Id = 2, Descricao = "Relatório de Estoque", Valor = 50.0m },
            new Relatorio { Id = 3, Descricao = "Relatório Financeiro", Valor = 200.0m }
        };

        private static readonly List<int> UsuariosComAcesso = new List<int> { 123, 456 };

        // Endpoint para validar e retornar relatórios
        [HttpGet("{userId}")]
        public IActionResult GetRelatorios(int userId)
        {
            if (UsuariosComAcesso.Contains(userId))
            {
                return Ok(new { success = true, data = Relatorios });
            }
            else
            {
                return Forbid("Você não possui acesso aos relatórios.");
            }
        }
    }
}
