using CadastroDePacientesBe3.Models;
using Microsoft.EntityFrameworkCore;
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

            var clients =  _context.Clientes.ToList();

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
        public List<Convenios> GetAllConvenios()
        {
            return _context.Convenios.OrderBy(x => x.Empresa).ToList();
        }

        public Convenios GetConvenioById(int? id)
        {
            return _context.Convenios.FirstOrDefault(c => c.IdConvenio == id);
        }

        public List<Clientes> GetAllClientsBySearch(string search)
        {
            int id;
            bool sucess = Int32.TryParse(search, out id);
            if (!sucess) id = 0;

            var clients =  _context.Clientes
                                .Where(c => c.Nome.Contains(search) || c.Prontuario == id || c.Cpf.Contains(search) || c.Email.Contains(search))
                                .ToList();
            return clients;    

        }
    }
}
