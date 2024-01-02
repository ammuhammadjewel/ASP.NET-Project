using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class JobApply
    {
        [Key]
        public int JId { get; set; }
        [Required]

        public string Name { get; set; }


        public DateTime Date { get; set; }

        [ForeignKey("UserDetails")]
        
        public int NID { get; set; }

        public virtual UserDetails UserDetails { get; set; }

    }
}
