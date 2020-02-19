using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroDePacientesBe3.Models;
using CadastroDePacientesBe3.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDePacientesBe3.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClientesService _clientesService;
        
        public ClientesController(ClientesService clienteService)
        {
            _clientesService = clienteService;
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.States = GetStates();
            ViewBag.Convenios = _clientesService.GetConvenios();
            ViewBag.Error = "";

            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes client)
        {
            ViewBag.States = GetStates();
            ViewBag.Convenios = _clientesService.GetConvenios();

            if (ModelState.IsValid)
            {
                Clientes cli = _clientesService.GetClientByCpf(client.Cpf);

                if (cli == null)
                {
                    //salvar cliente
                    _clientesService.Insert(client);

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
            var list = _clientesService.GetAllClients();

            return View(list);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.States = GetStates();
            ViewBag.Convenios = _clientesService.GetConvenios();
            ViewBag.Error = "";

            var client = _clientesService.GetClient(id);

            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Clientes client)
        {
            if (ModelState.IsValid)
            {
                _clientesService.Update(client);
                return RedirectToAction("List");
            }

            return View(client);
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