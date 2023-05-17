
namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant3.Weapons
{
    /// <summary>
    /// A simple implementation of a bog-standard sword.
    /// </summary>
    public class WeaponSword : WeaponBase
    {
        /// <summary>
        /// Constructor of the basic sword.
        /// </summary>
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
