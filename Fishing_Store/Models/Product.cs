using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Fishing_Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa produktu jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa nie może byc dłuższa nić 50 znaków")]
        public string Name { get; set; }
        [StringLength(500, ErrorMessage ="Opis produktu jest zbyt długo")]
        public string? Description { get; set; }
        [Range(0.01, 99999.99, ErrorMessage ="Cena musi być pomiędzy 0.001 a 99999.99")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
