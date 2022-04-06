using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Modals
{
    public class SavedAccount
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string Info { get; set; }
    }
}
