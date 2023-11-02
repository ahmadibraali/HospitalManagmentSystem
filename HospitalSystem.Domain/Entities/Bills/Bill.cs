using HospitalSystem.Domain.Enums;
using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Insurances;

namespace HospitalSystem.Domain.Entities.Bills
{
    public class Bill:BaseEntity
    {
        
        public int ChargeDoctor { get; set; }
        public decimal ChargeMedicine { get; set; }
        public decimal RoomCharge { get; set; }
        public decimal NeringCharge { get; set; }
        public decimal OptionCharge { get; set; }
        public decimal LabCharge { get; set; }
        public decimal Advance { get; set; }
        public decimal TotalCost { get; set; }
        public int NoOfDays { get; set; }
        public string BillNumber { get; set; }
        
        /// Relation With ApplicationUser (Patient) 1 ->Patient
        public ApplicationUser Patient { get; set; }
        /// Relation With Insurance 1 ->Insurance
        public Insurance Insurance { get; set; }

    }
}
