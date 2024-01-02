﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDetailsDTO
    {
        public int NId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Fathers_Name { get; set; }
        [Required]

        public string Mothers_Name { get; set; }
        [Required]

        public string Nationality { get; set; }
        [Required]

        public string Religion { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string Status { get; set; }

        public string address { get; set; }

        public int Uid { get; set; }
    }
}
