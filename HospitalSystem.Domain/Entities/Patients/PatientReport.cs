using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Doctors;
using HospitalSystem.Domain.Entities.Prescriptions;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Patients
{
    public class PatientReport : BaseEntity
    {
        public string Diagnoses { get; set; }
        // Relation ApplicationUser Doctor 1 - Appointment on DoctorId
        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        public ApplicationUser Doctor { get; set; }

        // Relation ApplicationUser Patient 1 - Appointment on PatientId
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public ApplicationUser Patient { get; set; }
        // Relation DoctorVisit 1-DoctorVisit on DoctorVisitId
        [ForeignKey("DoctorVisit")]
        public int DoctorVisittId { get; set; }
        public DoctorVisit DoctorVisit { get; set; }
        // Relation Prescription M-Prescriptions 
        public ICollection<Prescription> Prescriptions { get; set; }




    }
}
