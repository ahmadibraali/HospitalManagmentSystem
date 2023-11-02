using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Hospitals;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Contacts
{
    public class Contact : BaseEntity
    {


        public string phone { get; set; }
        public string Email { get; set; }

        // Hospital Relation 1-Hospital with hosID
        [ForeignKey("Hospital")]
        public int HospitalId {  get; set; }
        public Hospital Hospital { get; set; }

    }
}
