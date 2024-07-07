namespace POS.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int AuditCreateUser { get; set; } // If an explicit value isn't provided, C# will init it with a predefined value of "0"
        public DateTime AuditCreateDate { get; set; } // If an explicit value isn't provided, C# will init it with a predefined value of "1/1/0001 0:00:00"
        public int? AuditUpdateUser { get; set; }
        public DateTime? AuditUpdateDate { get; set; }
        public int? AuditDeleteUser { get; set; }
        public DateTime? AuditDeleteDate { get; set; }
        public int State { get; set; }
    }
}
