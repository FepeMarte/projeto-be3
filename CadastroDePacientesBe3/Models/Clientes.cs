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
        [DataType(DataType.Date)]
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

        // public Convenios Convenios { get; set; }

        [Display(Name = "IdConvenio")]
        [Required(ErrorMessage = "Selecione o Convenio!")]
        public short? IdConvenio { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NCarteirinha { get; set; }
        public string Celular { get; set; }

        [StringLength(100, ErrorMessage = "Digite menos caracteres!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NomeMae { get; set; }

        
        [Display(Name = "UF")]
        [Required(ErrorMessage = "Selecione a UF do RG")]
        public string UF { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatório!")]
        
        public DateTime? DtValidade { get; set; }
    }
}
