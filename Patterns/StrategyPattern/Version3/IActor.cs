
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// An interface for entities that have a health bar that can be affected, e.g. people, structures etc.
    /// </summary>
    internal interface IActor
    {
        /// <summary>
        /// The current health of the actor.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Sets the health of the actor to a new value, <br>can be higher or lower.</br>
        /// </summary>
        /// <param name="health">The new health value.</param>
        public void SetHealth(int health);

        /// <summary>
        /// Reads the current health of the actor.
        /// </summary>
        /// <returns>The current health.</returns>
        public int GetHealth();
    }
}
