using System;
using System.Collections.Generic;

namespace CadastroDePacientesBe3.Models
{
    public partial class Clientes
    {
        public int Prontuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public byte Sexo { get; set; }
        public string FoneRes { get; set; }
        public string Email { get; set; }
        public short? IdConvenio { get; set; }
        public string NCarteirinha { get; set; }
        public string Celular { get; set; }
        public string NomeMae { get; set; }
    }
}
