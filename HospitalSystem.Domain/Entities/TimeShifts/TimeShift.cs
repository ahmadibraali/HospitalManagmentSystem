using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Doctors;
using HospitalSystem.Domain.Enums;

namespace HospitalSystem.Domain.Entities.TimeShifts
{
    public class TimeShift : BaseEntity
    {

        public DateTime? StartShift { get; set; }
        public DateTime? EndShift { get; set; }

        public double? Duration { get; set; }
        public ShiftStatus Status { get; set; }

        //Relation DoctorShift M-DoctorShifts 
        public ICollection<DoctorShift> DoctorShifts { get; set; }

    }
}
