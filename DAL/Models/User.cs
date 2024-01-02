using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string username {  get; set; }

        [Required]
        public string password { get; set; }

        /*public string type { get; set; }*/

        public virtual ICollection<UserDetails> Users { get; set; }

        public User()
        {
            Users = new List<UserDetails>();
        }

    }
}
