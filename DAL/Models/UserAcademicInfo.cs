using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserAcademicInfo
    {
        [Key]
        public int RId { get; set; }
        [Required]

        public string JSC { get; set; }
        [Required]

        public string JSC_reg { get; set; }
        [Required]

        public string SSC { get; set; }
        [Required]

        public string SSC_reg { get; set; }
        [Required]

        public string HSC { get; set; }
        [Required]

        public string HSC_reg { get; set; }

        [ForeignKey("UserDetails")]

        public int NID { get; set; }


        public virtual UserDetails UserDetails { get; set; }


    }
}
