
namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant3
{
    /// <summary>
    /// An interface for usable weapons.
    /// </summary>
    public interface IWeapon
    {
        /// <summary>
        /// The static name of this weapon.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The user-assigned custom nickname for  this weapon.
        /// </summary>
        string Alias { get; }

        /// <summary>
        /// This weapon's flavour text.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The damage this weapon deals.
        /// </summary>
        int Damage { get; }

        /// <summary>
        /// The type of this weapon, e.g. melee, magic, ranged, etc.
        /// </summary>
        WeaponType WeaponType { get; }

        /// <summary>
        /// Deals damage to a target.
        /// </summary>
        /// <param name="target">The target which takes damage.</param>
        public void DealDamage(ITarget target);

        /// <summary>
        /// Updates the damage this weapon deals to a new damage value.
        /// </summary>
        /// <param name="damage">The damage this weapon should deal from now on.</param>
        public void SetDamage(int damage);

        /// <summary>
        /// Assigns a custom nickname to this weapon, which will be displayed instead of the static base name.
        /// </summary>
        /// <param name="alias">The new nickname for this weapon.</param>
        public void SetAlias(string alias);
    }
}
