using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DQMA.Models
{
    public class Attachments
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        [StringLength(50)]
        public string AttachmentName { get; set; }

        [StringLength(150)]
        public string AttachmentUrl { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public int StatementId { get; set; }

        [ForeignKey("StatementId")]
        public Statement Statement { get; set; }
    }
}
