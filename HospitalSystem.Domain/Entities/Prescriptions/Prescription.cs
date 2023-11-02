using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Medicines;
using HospitalSystem.Domain.Entities.Patients;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Prescriptions
{
    public class Prescription : BaseEntity
    {
        // Relation Medicine 1-Medicine on MedicineId
        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        // Relation PatientReport 1-PatientReport on PatientReportId
        [ForeignKey("PatientReport")]
        public int PatientReportId { get; set; }
        public PatientReport PatientReport { get; set; }


    }
}
