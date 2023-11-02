using HospitalSystem.Domain.Enums;

namespace HospitalSystem.Domain.Entities.BaseEntities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public IsDeleted IsDeleted { get; set; }
    }
}
