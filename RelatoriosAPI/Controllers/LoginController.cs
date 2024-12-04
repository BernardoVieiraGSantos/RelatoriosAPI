using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelatoriosAPI.Models;

namespace RelatoriosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                Id= 1, Nome="Bernardo", Login = "admin" , Senha = "admin"
            }
        };
    

        [HttpPost]
        public LoginResponse Login(LoginRequest loginRequest)
        {
            var usuario = LoginController.usuarios.Find(item =>
            {
                return item.Senha.Equals(loginRequest.Senha) && item.Login.
                Equals(loginRequest.Usuario);
            }); //função reduzida (Lambida)

            if (usuario == null) {
                return new LoginResponse()
                {
                    Success = false
                };
            }
            else {
                return new LoginResponse()
                {
                    Success = true,
                    IdUsuario = usuario.Id,
                    NomeUsuario = usuario.Nome
                };
            }   
        }
    }
}
