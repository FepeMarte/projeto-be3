using CadastroDePacientesBe3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDePacientesBe3.Services
{
    public class ClientesService
    {
        private readonly DB5566Context _context;
        public ClientesService(DB5566Context context)
        {
            _context = context;
        }


        public List<Clientes> GetAllClients()
        {

            var clients = _context.Clientes.ToList();

            return clients;
        }

        public Clientes GetClient(int? Id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Prontuario == Id);
        }

        public Clientes GetClientByCpf(string cpf)
        {
            return _context.Clientes.FirstOrDefault(c => c.Cpf == cpf);
        }


        public void Insert(Clientes client)
        {
            _context.Add(client);
            _context.SaveChanges();

        }

        public void Update(Clientes client)
        {
            _context.Update(client);
            _context.SaveChanges();

        }
        public List<Convenios> GetConvenios()
        {
            return _context.Convenios.OrderBy(x => x.Empresa).ToList();
        }

    }
}
