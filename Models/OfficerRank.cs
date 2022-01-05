using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DQMA.Models
{
    public class OfficerRank
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25)]
        public string RankName { get; set; }
    }
}
