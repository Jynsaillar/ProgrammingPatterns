
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3.Weapons
{
    /// <summary>
    /// Implementation of simply having no weapon equipped.
    /// </summary>
    internal class WeaponNone : WeaponBase
    {
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
