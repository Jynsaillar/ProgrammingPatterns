
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    /// <summary>
    /// The base class for any kind of weapon, inherit from this type to create concrete weapons.
    /// </summary>
    public abstract class WeaponBase : IWeapon
    {
        private readonly string _name = "";
        private readonly string _description = "";
        private string _alias = "";
        private int _damage = 0;
        private readonly WeaponType _weaponType = WeaponType.None;

        public string Name => _name;
        public string Description => _description;
        public string Alias => _alias;
        public int Damage => _damage;
        public WeaponType WeaponType => _weaponType;

        /// <summary>
        /// The weapon that represents the abstract base all weapons derive from.
        /// </summary>
        /// <param name="name">The static name of the weapon.</param>
        /// <param name="description">Flavour text of the weapon.</param>
        /// <param name="alias">Custom name given to the weapon by the player.</param>
        /// <param name="damage">The damage this weapon deals in combat.</param>
        /// <param name="weaponType">The type of the weapon, e.g. melee, ranged, magic, etc.</param>
        protected WeaponBase(string name, string description, string alias, int damage, WeaponType weaponType)
        {
            _name = name;
            _description = description;
            _alias = alias;
            _damage = damage;
            _weaponType = weaponType;
        }

        public virtual void DealDamage(ITarget target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target), "Invalid target!");

            target.TakeDamage(Damage);
        }

        public virtual void SetAlias(string alias)
        {
            _alias = alias;
        }

        public virtual void SetDamage(int damage)
        {
            _damage = damage;
        }
    }
}
