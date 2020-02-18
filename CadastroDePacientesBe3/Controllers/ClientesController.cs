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
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes Cliente)
        {
            return View(Cliente);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
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