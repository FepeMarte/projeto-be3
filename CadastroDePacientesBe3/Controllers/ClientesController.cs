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
        public IActionResult Create()
        {
            return View();
        }
    }
}