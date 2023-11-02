using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.WorkDays
{
    public class WorkDay : BaseEntity
    {
        public Shifts FormalStartingShift { get; set; } = Shifts.HasNoShifts;

        // Relation ApplicationUser "Doctor" 1-Doctor on DocId
        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        public ApplicationUser Doctor { get; set; }
        // Relation WeekDay  1-WeekDay on WeekDayId
        [ForeignKey("WeekDay")]
        public string WeekDayId { get; set; }
        public WeekDay WeekDay { get; set; }

    }
}
