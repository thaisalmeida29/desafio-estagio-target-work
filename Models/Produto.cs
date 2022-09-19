using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace desafio.Models
{
    public class Produto
    {
        [Key()]
        [Display(Name = "Id do Produto")]
        public int IdProduto { get; set; }

        [ForeignKey("Cliente")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }


        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Disponivel")]
        public bool Active { get; set; }


    }
}
