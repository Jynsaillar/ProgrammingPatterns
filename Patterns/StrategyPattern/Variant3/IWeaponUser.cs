
namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant3
{
    /// <summary>
    /// An interface for entities that can bear weapons, like soldiers, player characters etc.
    /// </summary>
    public interface IWeaponUser
    {
        /// <summary>
        /// The weapon that the IWeaponUser carries.
        /// </summary>
        IWeapon Weapon { get; }

        /// <summary>
        /// Changes the active weapon to a new one.
        /// </summary>
        /// <param name="weapon">THe new weapon.</param>
        void SetWeapon(IWeapon weapon);
        /// <summary>
        /// Attacks a target (and probably deals damage to it).
        /// </summary>
        /// <param name="target">The target being attacked by this entity, <br>damage is dealth through <see cref="this.Weapon"/>.</br></param>
        void Attack(ITarget target);
    }
}
