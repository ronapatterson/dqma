using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DQMA.Models
{
    public class Parish
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ParishName { get; set; }

        public int CountryId { get; set; }
    }
}
