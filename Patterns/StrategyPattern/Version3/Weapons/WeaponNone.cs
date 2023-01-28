
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    /// <summary>
    /// Implementation of simply having no weapon equipped.
    /// </summary>
    public class WeaponNone : WeaponBase
    {
        /// <summary>
        /// A weapon which represents having no weapon equipped (not fists!).
        /// </summary>
        public WeaponNone() : base(
                name: "None",
                description: "Unarmed.",
                alias: "",
                damage: 0,
                weaponType: WeaponType.None)
        {
        }
    }
}
