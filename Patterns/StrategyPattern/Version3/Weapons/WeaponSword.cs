
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    /// <summary>
    /// A simple implementation of a bog-standard sword.
    /// </summary>
    internal class WeaponSword : WeaponBase
    {
        public WeaponSword() : base(
                name: "Sword",
                description: "The sword is a formidable melee weapon.\r\nShort range, quick to medium speed.",
                alias: "Sword",
                damage: 15,
                weaponType: WeaponType.Melee)
        {
        }
    }
}
