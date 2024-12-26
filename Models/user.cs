using System.ComponentModel.DataAnnotations;

namespace CRMSardis.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Null olmaması için varsayılan değer

        [Required]
        public string Surname { get; set; } = string.Empty; // Yeni eklenen Surname özelliği

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; // Null olmaması için varsayılan değer

        [Required]
        public string Password { get; set; } = string.Empty; // Null olmaması için varsayılan değer

        public string? Role { get; set; } // Nullable olarak bırakılabilir
    }
}
