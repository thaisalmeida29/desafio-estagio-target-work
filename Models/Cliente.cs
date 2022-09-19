using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace desafio.Models
{
    public class Cliente
    {
        [Key()]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int IdCliente { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "O email é requerido.")]
        public string Email { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}
