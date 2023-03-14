using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Google.Apis.Admin.Directory.directory_v1.Data;
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace EmprestimoLivros.API.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        [Route("api/anonimo")]
        [AllowAnonymous]

        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("api/funcionario")]
        [Authorize(Roles = "funcionario, gerente")]

        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("api/gerente")]
        [Authorize(Roles = "gerente")]
        public string Manager() => "Gerente";
    }
}
