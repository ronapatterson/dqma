using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DQMA.Models
{
    public class Statement
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string FullName { get; set; }
                
        [StringLength(2)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        public Division Division { get; set; }

        public int CategoryTypeId { get; set; }

        [ForeignKey("CategoryTypeId")]
        public CategoryType CategoryType { get; set; }

        public int OffenseTypeId { get; set; }

        [ForeignKey("OffenseTypeId")]
        public OffenseType OffenseType { get; set; }

        public int MotiveId { get; set; }

        [ForeignKey("MotiveId")]
        public Motive Motive { get; set; }

        public DateTime IncidentDate { get; set; }

        public int ParishId { get; set; }

        [ForeignKey("ParishId")]
        public Parish Parish { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        [StringLength(150)]
        public string PropertyDescription { get; set; }

        public double? TotalEstimate { get; set; }

        public double? TotalAmountStolen { get; set; }

        [StringLength(50)]
        public string SuspectName { get; set; }

        [StringLength(50)]
        public string SuspectAddress { get; set; }

        public int? SuspectParishId { get; set; }

        /*[ForeignKey("SuspectParishId")]
        [InverseProperty("Statement")] //used for multiple fk to same table
        public Parish SuspectParish { get; set; }*/

        public int? SuspectCountryId { get; set; }

        /*[ForeignKey("SuspectCountryId")]
        [InverseProperty("Statment")]
        public Country SuspectCountry { get; set; }*/

        [StringLength(150)]
        public string SuspectDescription { get; set; }

        //public bool IsVictim { get; set; }

        //Officer Taking Statement
        public string OfficerName { get; set; }

        public int? OfficerRankId { get; set; }

        [ForeignKey("OfficerRankId")]
        public OfficerRank OfficerRank { get; set; }

        //GPS 
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string ScannedText { get; set; }

        [StringLength(25)]
        public string Status { get; set; }

        public DateTime StatusDate { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(450)]
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        [StringLength(450)]
        public string ModifiedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
