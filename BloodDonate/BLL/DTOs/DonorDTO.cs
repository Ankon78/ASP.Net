﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DonorDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int GrpId { get; set; }
    }
}
