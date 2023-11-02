using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Supliers;

namespace HospitalSystem.Domain.Entities.Medicines
{
    public class MedicineReport : BaseEntity
    {
        public string Company { get; set; }
        public string Country { get; set; }
        public string Quantity { get; set; }
        public DateTime ProuductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Relation Medicine 1-Medicine
        public Medicine Medicine { get; set; }

        // Relation Suplier 1-Suplier
        public Suplier Suplier { get; set; }


    }
}
