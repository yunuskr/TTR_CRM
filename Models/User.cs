using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TTR_CRM.Models
{
    [Table("User_Table")]
    public class User
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("User")]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("Password")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
