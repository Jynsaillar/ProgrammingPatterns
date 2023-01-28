using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    internal class WeaponSword : IWeapon
    {
        private readonly string _name = "Sword";
        private readonly string _description = "The sword is a formidable melee weapon.\r\nShort range, quick to medium speed.";
        private string _alias = "Sword";
        private int _damage = 15;
        private readonly WeaponType _weaponType = WeaponType.Melee;
        public string Name => _name;

        public string Description => _description;

        public int Damage => _damage;

        public WeaponType WeaponType => _weaponType;

        public string Alias => _alias;

        public void DealDamage(ITarget target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target), "Invalid target!");

            target.TakeDamage(Damage);
        }

        /// <summary>
        /// Changes the user-given nickname of the weapon, e.g.
        /// <br>"Thunderfury, Blessed Blade of the Windseeker" => "Spicy Kaboom Sword"</br>
        /// </summary>
        /// <param name="alias">The new nickname for the weapon.</param>
        public void SetAlias(string alias)
        {
            _alias = alias;
        }

        public void SetDamage(int damage)
        {
            _damage = damage;
        }
    }
}
