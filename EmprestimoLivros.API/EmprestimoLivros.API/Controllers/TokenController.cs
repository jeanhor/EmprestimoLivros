using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using EmprestimoLivros.API.Repositories;
using System.Linq;
using EmprestimoLivros.API.Services;

namespace EmprestimoLivros.API.Controllers
{
    public class TokenController : Controller
    {
        [HttpPost]
        [Route("api/login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Autenticar([FromBody] Entityes.User model)
        {
            var user = UserRepositories.Get(model.Username, model.Password);
            if (user == null)
                return NotFound(new { message = "Usuario ou senha Invalida" });

            var token = TokenService.GenerateToken(user);

            user.Password = "";

            return new
            {
                user = user,
                token = token
            };

        }
    }
}
