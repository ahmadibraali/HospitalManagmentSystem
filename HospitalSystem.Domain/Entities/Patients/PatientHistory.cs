using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Patients
{
    public class PatientHistory :BaseEntity
    {
        


        

        public DateTime VisitDate { get; set; }


        public string ChiefComplaint { get; set; }


        public string HistoryOfPresentIllness { get; set; }


        public string PastMedicalHistory { get; set; }


        public string FamilyHistory { get; set; }


        public string PhysicalExamination { get; set; }


        public string Assessment { get; set; }


        public string Plan { get; set; }


        public string Medications { get; set; }


        public string Allergies { get; set; }


        public string LabResults { get; set; }
        

        public bool IsFollowUp { get; set; }
        // Relation ApplicationUser Patient 1 - Patient on PatientId
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public ApplicationUser Patient { get; set; }
    }
}
