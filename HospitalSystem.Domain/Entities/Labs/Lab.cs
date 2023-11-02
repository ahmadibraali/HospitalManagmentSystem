using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Labs
{
    public class Lab : BaseEntity
    {

        public int Hight { get; set; }
        public int Weight { get; set; }
        public int BloodPressure { get; set; }
        public int Temprature { get; set; }
        public string LabNumber { get; set; }
        public string TestType { get; set; }
        public string TestCode { get; set; }
        public string TestResult { get; set; }

        // Relation ApplicationUser "Patient" 1-Patient on PatientId
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public ApplicationUser Patient { get; set; }

    }
}
