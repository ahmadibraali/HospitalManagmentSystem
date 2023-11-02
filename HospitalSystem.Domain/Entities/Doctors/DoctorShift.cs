using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Hospitals;
using HospitalSystem.Domain.Entities.TimeShifts;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Doctors
{
    public class DoctorShift :BaseEntity
    {

        // Relation ApplicationUser "Doctor" 1-Doctor on DocId
        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        public virtual ApplicationUser Doctor { get; set; }

        // Relation TimeShift  1-TimeShift on TimeShiftId
        [ForeignKey("TimeShift")]
        public string TimeShiftId { get; set; }
        public virtual TimeShift TimeShift { get; set; }

    }
}
