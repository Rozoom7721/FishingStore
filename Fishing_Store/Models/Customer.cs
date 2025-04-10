using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Fishing_Store.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Imie jest wymagane")]
        [StringLength (50,ErrorMessage ="Imie jest za długie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(50, ErrorMessage = "Nazwisko jest za długie")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage ="To nie jest poprawny adres email")]
        [Required(ErrorMessage ="Adres email jest wymagany")]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
