using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Hospitals;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Departments
{
    public class Department : BaseEntity
    {



        public string? Name { get; set; }
        public string? Description { get; set; }


        // Relation Many ApplicationUser "Employees" -M ApplicationUser
        public ICollection<ApplicationUser> Employees {  get; set; }
        // Relation 1 Hospital  1-Hospital on hosID
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
