
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Actors
{
    /// <summary>
    /// An entity representing a castle wall that has a health bar and can be attacked.
    /// </summary>
    public class CastleWall : IActor, ITarget
    {
        private int _health = 10000;

        public int Health => _health;

        /// <summary>
        /// Method to read the health of the castle wall.
        /// </summary>
        /// <returns>The health of the castle wall.</returns>
        public int GetHealth()
        {
            return Health;
        }

        /// <summary>
        /// Method to set the health of the castle wall.
        /// </summary>
        /// <param name="health">The new health value the castle wall shall have.</param>
        public void SetHealth(int health)
        {
            _health = health;
        }

        /// <summary>
        /// Method to receive damage.
        /// Checks if health is above 0,
        /// <br>sets health to 0 if <c>health - damage</c> is negative,</br>
        /// <br>otherwise it subtracts the damage from the health.</br>
        /// </summary>
        /// <param name="damage">The damage that shall be dealth to the castle wall.</param>
        public void TakeDamage(int damage)
        {
            if (_health == 0)
                return;

            if (_health - damage < 0)
            {
                _health = 0;
                return;
            }

            _health -= damage;
        }
    }
}
