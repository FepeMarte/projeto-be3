using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroDePacientesBe3.Models
{
    public partial class Clientes
    {       
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Prontuario { get; set; }

        [StringLength(60, ErrorMessage = "Digite menos caracteres!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [StringLength(80, ErrorMessage = "Digite menos caracteres!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DtNasc { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cpf { get; set; }
        public byte Sexo { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string FoneRes { get; set; }

        [EmailAddress(ErrorMessage = "Digite um email valido!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public short? IdConvenio { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NCarteirinha { get; set; }
        public string Celular { get; set; }

        [StringLength(100, ErrorMessage = "Digite menos caracteres!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NomeMae { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public short? IdUF { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DtValidade { get; set; }
    }
}
