using System.ComponentModel.DataAnnotations;

namespace Person.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 caracteres")]
        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}