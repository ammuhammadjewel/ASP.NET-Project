using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class JobApplyDTO
    {
        public int JId { get; set; }
        [Required]

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int NID { get; set; }
    }
}
