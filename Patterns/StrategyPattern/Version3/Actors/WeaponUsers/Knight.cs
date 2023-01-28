using ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Actors.WeaponUsers
{
    /// <summary>
    /// A Knight Actor that can carry a weapon, by default a <cref>WeaponSword</cref>.
    /// </summary>
    internal class Knight : IWeaponUser, IActor, ITarget
    {
        private int _health;
        private IWeapon _weapon;

        public int Health => _health;

        public IWeapon Weapon => _weapon;

#pragma warning disable CS8618 // Disable warning [Non-nullable field '_weapon' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.]
        public Knight(int health, IWeapon weapon)
        {
            SetHealth(health);
            SetWeapon(weapon);
        }
#pragma warning restore CS8618 // Reenable warning

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
            {
                _weapon = new WeaponNone();
                return;
            }

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

        public void Attack(ITarget target)
        {
            _weapon.DealDamage(target);
        }
    }
}
