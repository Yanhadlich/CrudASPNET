using System.ComponentModel.DataAnnotations;

namespace Person.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário informar nome do escritório")]
        public string office { get; set; }

        public string address { get; set; }
    }
}