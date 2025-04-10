using System.ComponentModel.DataAnnotations;

namespace Fishing_Store.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nazwa kategori jest wymagana")]
        [StringLength(50, ErrorMessage ="Nazwa kategori jest zbyt długa")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
