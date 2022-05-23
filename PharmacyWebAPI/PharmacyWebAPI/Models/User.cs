using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebAPI.Models
{
    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; } 

        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public string Role { get; set; }
    }
}
