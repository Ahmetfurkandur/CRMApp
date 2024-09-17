using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public TaskType Type { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public Common.TaskStatus Status{ get; set; }
        public string Owner { get; set; }
        public Guid? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid? PotentialCustomerId { get; set; }
        public PotentialCustomer PotentialCustomer { get; set; }
    }
}
