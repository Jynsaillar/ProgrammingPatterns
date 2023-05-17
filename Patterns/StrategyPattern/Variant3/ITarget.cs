
namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant3
{
    /// <summary>
    /// An interface for entities that can take damage.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Makes this target take damage.
        /// </summary>
        /// <param name="damage">The damage this target receives.</param>
        public void TakeDamage(int damage);
    }
}