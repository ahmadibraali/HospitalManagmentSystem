using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Medicines;

namespace HospitalSystem.Domain.Entities.Supliers
{
    public class Suplier : BaseEntity
    {

        public string Company { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //Relation MedicineReport M-MedicineReports 
        public ICollection<MedicineReport> MedicineReports { get; set; }

    }
}
