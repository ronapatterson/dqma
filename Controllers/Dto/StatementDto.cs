using System;

namespace DQMA.Controllers.Dto
{
    public class StatementDto
    {
        public DateTime IncidentDate { get; set; }
        public string DivisionName { get; set; }
        public string OffenseName { get; set; }
        public string VictimName { get; set; }
        public string VictimCountry { get; set; }        
        public string Motive { get; set; }
        public string Status { get; set; }
    }

    public class StatementOCRDto
    {
        public DateTime IncidentDate { get; set; }
        public int CategoryId { get; set; }
        public int OffenseId { get; set; }
        public int DivisionId { get; set; }
        public string VictimName { get; set; }
        public string VictimGender { get; set; }
        public string VictimAddress { get; set; }
        public int VictimParishId { get; set; }
        public int VictimCountryId { get; set; }
        public int MotiveId { get; set; }
        public string SuspectDescription { get; set; }
        public string Narrative { get; set; }

        public string ImageUrl { get; set; }
    }
}
