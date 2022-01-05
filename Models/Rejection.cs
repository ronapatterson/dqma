using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DQMA.Models
{
    public class Rejection
    {
        [Key]
        public int Id { get; set; }

        public int StatementId { get; set; }
                
        [StringLength(255)]
        public string Comments { get; set; }
        
        public DateTime Created { get; set; }

        [StringLength(450)]
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }

        [StringLength(450)]
        public string ModifiedBy { get; set; }
    }
}
