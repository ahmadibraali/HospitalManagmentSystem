using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Bills;

namespace HospitalSystem.Domain.Entities.Labs
{
    public class TestPrice : BaseEntity
    {

        // Relation Lab 1-Lab 

        public Lab Lab { get; set; }
        // Relation Bill 1-Bill 
        public Bill Bill { get; set; }

        public string TestCode { get; set; }
        public decimal TestCost { get; set; }
    }
}
