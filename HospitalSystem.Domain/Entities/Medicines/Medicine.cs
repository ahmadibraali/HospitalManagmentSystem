using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Prescriptions;

namespace HospitalSystem.Domain.Entities.Medicines
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime ProuductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Relation MedicineReport M-MedicineReports 
        public ICollection<MedicineReport> MedicineReports { get; set; }

        // Relation Prescription M-Prescriptions 
        public ICollection<Prescription> Prescriptions { get; set; }

    }
}
