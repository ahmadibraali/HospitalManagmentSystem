using HospitalSystem.Domain.Entities.Doctors;
using HospitalSystem.Domain.Entities.Labs;
using HospitalSystem.Domain.Entities.Patients;
using HospitalSystem.Domain.Entities.Payrolls;
using HospitalSystem.Domain.Entities.TimeShifts;
using HospitalSystem.Domain.Entities.WorkDays;
using HospitalSystem.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.ApplicationUsers
{
    public class ApplicationRole : IdentityRole
    {
        public bool Rols { get; set; }

    }
    public class ApplicationUser : IdentityUser
    {
        public IsDeleted IsDeleted { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiringDate { get; set; }

        public string ContractUrl { get; set; }
        public int WorkingDaysinWeek { get; set; }

        public Gender Gender { get; set; }

        public string StreetAddress { get; set; }


        public string City { get; set; }


        public RegisteredRole RegisteredRole { get; set; }


        public string Nationality { get; set; }

        public string imphgurl { get; set; }
        public Specialist Specialist { get; set; }
        public CofirmationDoctor DoctorStatusInSystem { get; set; }
        public string PostalCode { get; set; }

        public DateTime DateofBirth { get; set; }

        public ICollection<DoctorVisit> DoctorVists { get; set; }
        public ICollection<DoctorShift> DoctorShifts { get; set; }
        public ICollection<WorkDay> WorkDays { get; set; }
        public ICollection<PatientHistory> Histories { get; set; }
      
        
        ///Not Mapped Relations with User
        [NotMapped]
        public ICollection<Lab> Labs { get; set; }
        [NotMapped]
        public ICollection<Payroll> Payrolls { get; set; }
        [NotMapped]
        public List<TimeShift> TimeShifts { get; set; }

    }
}