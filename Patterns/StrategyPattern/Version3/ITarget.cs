
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// An interface for entities that can take damage.
    /// </summary>
    public interface ITarget
    {
        public void TakeDamage(int damage);
    }
}