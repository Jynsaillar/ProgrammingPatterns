
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Actors
{
    internal class CastleWall : IActor, ITarget
    {
        private int _health = 10000;

        public int Health => _health;

        public int GetHealth()
        {
            return Health;
        }

        public void SetHealth(int health)
        {
            _health = health;
        }

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
