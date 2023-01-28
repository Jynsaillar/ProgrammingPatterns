
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    /// <summary>
    /// The base class for any kind of weapon, inherit from this type to create concrete weapons.
    /// </summary>
    internal abstract class WeaponBase : IWeapon
    {
        private readonly string _name = "";
        private readonly string _description = "";
        private string _alias = "";
        private int _damage = 0;
        private readonly WeaponType _weaponType = WeaponType.None;
        public virtual string Name => _name;

        public virtual string Description => _description;

        public virtual int Damage => _damage;

        public WeaponType WeaponType => _weaponType;

        public string Alias => _alias;

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

        /// <summary>
        /// Changes the user-given nickname of the weapon, e.g.
        /// <br>"Thunderfury, Blessed Blade of the Windseeker" => "Spicy Kaboom Sword"</br>
        /// </summary>
        /// <param name="alias">The new nickname for the weapon.</param>
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
