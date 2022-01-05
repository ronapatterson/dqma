using System;
using System.ComponentModel.DataAnnotations;

namespace DQMA.Controllers.Dto
{
    public class CreateStatementDto
    {
        [StringLength(50)]
        public string FullName { get; set; }

        public int MotiveId { get; set; }

        public int OffenseTypeId { get; set; }

        public int DivisionId { get; set; }

        public int CategoryTypeId { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        public DateTime IncidentDate { get; set; }

        public int ParishId { get; set; }

        public int CountryId { get; set; }

        [StringLength(150)]
        public string PropertyDescription { get; set; }

        public double TotalEstimate { get; set; }

        public double TotalAmountStolen { get; set; }

        [StringLength(50)]
        public string SuspectName { get; set; }

        [StringLength(50)]
        public string SuspectAddress { get; set; }

        public int SuspectParishId { get; set; }

        public int SuspectCountryId { get; set; }

        [StringLength(150)]
        public string SuspectDescription { get; set; }

        public bool IsVictim { get; set; }

        //Officer Taking Statement
        public string OfficerName { get; set; }

        public int OfficerRankId { get; set; }

        //GPS 
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string ScannedText { get; set; }

        public string Status { get; set; }
    }

    public class UpdateStatementDto : CreateStatementDto
    {
        public int Id { get; set; }
    }
}
