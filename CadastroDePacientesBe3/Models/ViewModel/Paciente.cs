using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroDePacientesBe3.Models;

namespace CadastroDePacientesBe3.Models.ViewModel
{
    public class Paciente
    {
        public Clientes Cliente{ get; set; }
        public Convenios Convenio { get; set; }

    }
}
