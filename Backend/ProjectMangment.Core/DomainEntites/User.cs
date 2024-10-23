namespace ProjectMangment.Core.DomainEntites
{
    public class User
    {
        private User()
        {
            
        }
        public Guid UserId { get; private set; }
        public string Name { get; private set; }
    }
}
