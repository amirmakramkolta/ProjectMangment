using ProjectMangment.Core.DomainEntites.Enums;

namespace ProjectMangment.Core.DomainEntites
{
    public class Project
    {
        private Project()
        {
            
        }
        public Guid ProjectId { get; private set; }
        public string ProjectName { get; private set; }
        public string Description { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public decimal Budget { get; private set; }
        public Guid OwnerId { get; private set; }
        public Status Status { get; private set; }
    }
}
