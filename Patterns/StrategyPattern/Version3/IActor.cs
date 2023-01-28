
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// An interface for entities that have a health bar that can be affected, e.g. people, structures etc.
    /// </summary>
    internal interface IActor
    {
        int Health { get; }

        public void SetHealth(int health);
        public int GetHealth();
    }
}
