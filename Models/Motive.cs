using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DQMA.Models
{
    public class Motive
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string MotiveName { get; set; }
    }
}
