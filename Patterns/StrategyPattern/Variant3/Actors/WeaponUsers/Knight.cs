using ProgrammingPatterns.Patterns.StrategyPattern.Variant3.Weapons;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant3.Actors.WeaponUsers
{
    /// <summary>
    /// A Knight Actor that can carry a weapon, has a health bar, and can be in combat.
    /// </summary>
    public class Knight : IWeaponUser, IActor, ITarget
    {
        private int _health;
        private IWeapon _weapon;

        public int Health => _health;
        public IWeapon Weapon => _weapon;

#pragma warning disable CS8618 // Disable warning [Non-nullable field '_weapon' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.]
        /// <summary>
        /// Constructor of the Knight entity.
        /// </summary>
        /// <param name="health">The health bar of the knight.</param>
        /// <param name="weapon">The weapon that the knight shall bear.</param>
        public Knight(int health, IWeapon weapon)
        {
            SetHealth(health);
            SetWeapon(weapon);
        }
#pragma warning restore CS8618 // Reenable warning

        /// <summary>
        /// Reads the current health of the knight.
        /// </summary>
        /// <returns>The health the knight currently has.</returns>
        public int GetHealth()
        {
            return _health;
        }

        /// <summary>
        /// Sets the health of the knight to a new value, e.g. when damaged or healed.
        /// </summary>
        /// <param name="health">The new health value.</param>
        public void SetHealth(int health)
        {
            if (health < 0)
                return;

            _health = health;
        }

        /// <summary>
        /// Assigns a new active weapon to the knight.
        /// </summary>
        /// <param name="weapon">The new weapon the knight shall bear.</param>
        public void SetWeapon(IWeapon weapon)
        {
            if (weapon == null)
            {
                _weapon = new WeaponNone();
                return;
            }

            _weapon = weapon;
        }

        /// <summary>
        /// Deals damage to the health of the knight.
        /// </summary>
        /// <param name="damage">The damage the knight receives to his health bar.</param>
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

        /// <summary>
        /// The knight deals damage to a target entity.
        /// </summary>
        /// <param name="target">The entity the knight damages.</param>
        public void Attack(ITarget target)
        {
            _weapon.DealDamage(target);
        }
    }
}
