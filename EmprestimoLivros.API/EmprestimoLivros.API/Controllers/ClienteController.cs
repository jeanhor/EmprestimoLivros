using EmprestimoLivros.API.Entityes;
using EmprestimoLivros.API.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpGet("selecionartodos")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteRepository.SelecionarTodos());
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarCliente(Cliente cliente)
        {
            _clienteRepository.Incluir(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente Cadastrado com Sucesso!");
            }
            return BadRequest("Ocorreu um erro ao salvar o Cliente.");
        }
        [HttpPut]
        public async Task<ActionResult> AlterarCliente(Cliente cliente)
        {
            _clienteRepository.Alterar(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com Sucesso!");
            }
            return BadRequest("Ocorreu um erro ao alterar o Cliente.");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluirCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if (cliente == null)
            {
                return NotFound("Cliente não Encontrado.");
            }
            _clienteRepository.Excluir(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente Excluido");
            }
            return BadRequest("Ocorreu um erro ao excluir .");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> SelecionarClientes(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }

            return Ok(cliente);
        }

    }
    
}
