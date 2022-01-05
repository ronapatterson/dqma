﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DQMA.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }               
    }
}
