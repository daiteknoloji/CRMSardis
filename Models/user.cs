<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;

>>>>>>> 710e3ed (Proje dosyalarını ekledim)
namespace CRMSardis.Models
{
    public class User
    {
<<<<<<< HEAD
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Kullanıcı rolü
=======
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
>>>>>>> 710e3ed (Proje dosyalarını ekledim)
    }
}
