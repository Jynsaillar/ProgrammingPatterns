
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// An interface for usable weapons.
    /// </summary>
    internal interface IWeapon
    {
        string Name { get; }
        string Alias { get; }
        string Description { get; }

        int Damage { get; }
        WeaponType WeaponType { get; }

        public void DealDamage(ITarget target);
        public void SetDamage(int damage);
        public void SetAlias(string alias);
    }
}
