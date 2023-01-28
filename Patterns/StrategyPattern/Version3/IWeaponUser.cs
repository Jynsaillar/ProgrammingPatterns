
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// An interface for entities that can bear weapons, like soldiers, player characters etc.
    /// </summary>
    internal interface IWeaponUser
    {
        IWeapon Weapon { get; }

        void SetWeapon(IWeapon weapon);
        void Attack(ITarget target);
    }
}
