using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.Appointments;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Doctors
{
    public class DoctorVisit : BaseEntity
    {



        // Relation ApplicationUser Doctor 1 - Appointment on DoctorId
        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        public ApplicationUser Doctor { get; set; }

        // Relation ApplicationUser Patient 1 - Appointment on PatientId
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public ApplicationUser Patient { get; set; }

        // Relation Appointment 1 - Appointment on AppointmentId
        [ForeignKey("Appointment")]
        public string AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public string? VisitNoteByDoctor { get; set; }
        public DateTime? VisiteDate { get; set; }
        public VisitType VisitType { get; set; }
        public VisitStatus visitStatus { get; set; }

    }
}
