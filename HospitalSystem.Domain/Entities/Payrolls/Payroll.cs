using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Payrolls
{
    public class Payroll : BaseEntity
    {
        
        public decimal Salary { get; set; }
        public decimal Netsalary { get; set; }
        public decimal HrsSalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compensalation { get; set; }

        
        // Relation ApplicationUser Employee 1-ApplicationUser on ApplicationUserId
        [ForeignKey("Accountant")]
        public string AccountantNumber { get; set; }
        public ApplicationUser Accountant { get; set; }
    }
}
