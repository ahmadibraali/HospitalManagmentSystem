using HospitalSystem.Domain.Entities.BaseEntities;
using HospitalSystem.Domain.Entities.Hospitals;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalSystem.Domain.Entities.Rooms
{
    public class Room : BaseEntity
    {


        public string RoomName { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        // Relation Hospital 1-Hospital on HospitalId
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }

    }
}
