using LogManager.Infrastructure.Behavior;

namespace LogManager.Infrastructure
{
    public class DatabaseConfiguration : IDatabaseConfiguration
    {
        public string Name { get; set; }
    }
}
