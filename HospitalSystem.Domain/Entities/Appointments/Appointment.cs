using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Doctors;
using HospitalSystem.Domain.Enums;

namespace HospitalSystem.Domain.Entities.Appointments
{
    public class Appointment:BaseEntity
    {
        

        public DateTime CreationDate { get; set; }

        public string? Description { get; set; }
        public AppointmentConfirmation AppointmentConfirmation { get; set; } = AppointmentConfirmation.PendingConfirmation;
        
        
        //Relation with Many DoctorVisit
        public ICollection<DoctorVisit> DoctorVisits {  get; set; }
    }
}
