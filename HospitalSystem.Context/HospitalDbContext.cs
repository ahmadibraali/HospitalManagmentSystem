using HospitalSystem.Domain.Entities.ApplicationUsers;
using HospitalSystem.Domain.Entities.Appointments;
using HospitalSystem.Domain.Entities.Bills;
using HospitalSystem.Domain.Entities.Contacts;
using HospitalSystem.Domain.Entities.Departments;
using HospitalSystem.Domain.Entities.Doctors;
using HospitalSystem.Domain.Entities.Hospitals;
using HospitalSystem.Domain.Entities.Insurances;
using HospitalSystem.Domain.Entities.Labs;
using HospitalSystem.Domain.Entities.Medicines;
using HospitalSystem.Domain.Entities.Patients;
using HospitalSystem.Domain.Entities.Payrolls;
using HospitalSystem.Domain.Entities.Prescriptions;
using HospitalSystem.Domain.Entities.Rooms;
using HospitalSystem.Domain.Entities.Supliers;
using HospitalSystem.Domain.Entities.TimeShifts;
using HospitalSystem.Domain.Entities.WorkDays;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Context
{
    public class HospitalDbContext : IdentityDbContext<ApplicationUser>
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }

        public DbSet<TimeShift> TimeShifts { get; set; }
        public DbSet<PatientHistory> PatientHistories { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }
        public DbSet<DoctorShift> DoctorShifts { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Appointment> Apointments { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineReport> MedicineReports { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TestPrice> TestPrices { get; set; }
        public DbSet<PatientReport> PatientReports { get; set; }
        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<DoctorVisit> DoctorVisits { get; set; }
    
    }
}
