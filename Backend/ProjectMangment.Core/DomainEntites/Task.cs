using ProjectMangment.Core.DomainEntites.Enums;

namespace ProjectMangment.Core.DomainEntites
{
    public class Task
    {
        private Task()
        {
            
        }
        public Guid TaskId { get; private set; }
        public string TaskName { get; private set; }
        public string Description { get; private set; }
        public int AssignedToId { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public int Priority { get; private set; }
        public Status Status { get; private set; }
    }
}
