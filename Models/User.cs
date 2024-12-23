using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TTR_CRM.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("Username")]
        [StringLength(100)]
        public string Username { get; set; }

        [Column("Password")]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
