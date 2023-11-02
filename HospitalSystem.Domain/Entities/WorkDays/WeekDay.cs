using HospitalSystem.Domain.Entities.BaseEntities;

namespace HospitalSystem.Domain.Entities.WorkDays
{
    public class WeekDay : BaseEntity
    {

        public string WeekDayName { get; set; }
        public string StartingAmShift { get; set; }
        public string StartingPmShift { get; set; }

        //Relation WorkDay M-WorkDays 
        public ICollection<WorkDay> WorkDays { get; set; }


    }
}
