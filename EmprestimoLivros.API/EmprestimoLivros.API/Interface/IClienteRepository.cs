using EmprestimoLivros.API.Entityes;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Interface
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);
        Task<Cliente> SelecionarByPk(int id);
        Task<Cliente> SelecionarByCpf(string cpf);
        Task<Cliente> SelecionarContendo(string nome);
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
