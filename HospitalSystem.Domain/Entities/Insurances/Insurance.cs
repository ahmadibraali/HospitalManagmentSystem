using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Bills;

namespace HospitalSystem.Domain.Entities.Insurances
{
    public class Insurance : BaseEntity
    {

        public string Policynumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        // Relation Bill  M - Bills 
        public ICollection<Bill> Bills { get; set; }


    }
}
