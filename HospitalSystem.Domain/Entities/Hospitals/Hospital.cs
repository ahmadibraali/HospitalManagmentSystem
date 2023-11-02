using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Contacts;
using HospitalSystem.Domain.Entities.Departments;
using HospitalSystem.Domain.Entities.Rooms;

namespace HospitalSystem.Domain.Entities.Hospitals
{
    public class Hospital : BaseEntity
    {


        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Type { get; set; }
        public string? PinCode { get; set; }
        // Relation Room  M - Rooms
        public ICollection<Room> Rooms { get; set; }

        // Relation Department  M - Departments
        public ICollection<Department> Departments { get; set; }

        // Relation Contact  M - Contacts 
        public ICollection<Contact> Contacts { get; set; }


    }
}
