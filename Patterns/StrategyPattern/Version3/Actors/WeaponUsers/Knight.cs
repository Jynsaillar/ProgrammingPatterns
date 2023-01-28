using ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Actors.WeaponUsers
{
    internal class Knight : IWeaponUser, IActor, ITarget
    {
        private int _health = 100;
        private IWeapon _weapon = new WeaponSword();

        public int Health => _health;

        public IWeapon Weapon => _weapon;

        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth(int health)
        {
            if (health < 0)
                return;

            _health = health;
        }

        public void SetWeapon(IWeapon weapon)
        {
            if (weapon == null)
                return;

            _weapon = weapon;
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
