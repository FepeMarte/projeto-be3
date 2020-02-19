using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroDePacientesBe3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDePacientesBe3.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DB5566Context _context;
        public ClientesController(DB5566Context context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.States = GetStates();
            ViewBag.Convenios = GetAll();
            ViewBag.Error = "";

            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes client)
        {
            ViewBag.States = GetStates();
            ViewBag.Convenios = GetAll();

            if (ModelState.IsValid)
            {
                Clientes cli = _context.Clientes.FirstOrDefault(c => c.Cpf == client.Cpf);

                if (cli == null)
                {
                    //salvar cliente
                    _context.Add(client);
                    _context.SaveChanges();

                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Error = "Cliente já cadastrado!";
                    return View(client);
                }

            }

            return View(client);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Clientes client)
        {
            return View(client);
        }



        public List<Convenios> GetAll()
        {
            return _context.Convenios.OrderBy(x => x.Empresa).ToList();
        }

        public List<string> GetStates()
        {
            List<string> states = new List<string>();

            states.Add("AC");
            states.Add("AL");
            states.Add("AP");
            states.Add("AM");
            states.Add("BA");
            states.Add("CE");
            states.Add("DF");
            states.Add("ES");
            states.Add("GO");
            states.Add("MA");
            states.Add("MT");
            states.Add("MS");
            states.Add("MG");
            states.Add("PA");
            states.Add("PB");
            states.Add("PR");
            states.Add("PE");
            states.Add("PI");
            states.Add("RJ");
            states.Add("RN");
            states.Add("RS");
            states.Add("RO");
            states.Add("RR");
            states.Add("SC");
            states.Add("SP");
            states.Add("SE");
            states.Add("TO");

            return states;
        }


    }
}