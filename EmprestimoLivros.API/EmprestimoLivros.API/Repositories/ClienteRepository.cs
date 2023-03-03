using EmprestimoLivros.API.Entityes;
using EmprestimoLivros.API.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly NAR_HMLContext _context;

        public ClienteRepository( NAR_HMLContext context)
        {
            _context = context;
        }
        public void Alterar(Cliente cliente)
        {
            _context.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Excluir(Cliente cliente)
        {
            _context.Remove(cliente);
        }

        public void Incluir(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<Cliente> SelecionarByCpf(string cpf)
        {
            return await _context.Cliente.Where(x => x.CliCpf == cpf).FirstOrDefaultAsync();
        }

        public async Task<Cliente> SelecionarByPk(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> SelecionarTodos()
        {
            return await _context.Cliente.ToListAsync();
        }
        
    }
}
