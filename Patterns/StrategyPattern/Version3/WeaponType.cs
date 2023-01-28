
namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    /// <summary>
    /// Categories of weapons.
    /// </summary>
    internal enum WeaponType
    {
        /// <summary>
        /// No weapon equipped, not equivalent to fists.
        /// </summary>
        None = 0,
        /// <summary>
        /// Short ranged weapons like knives, swords, fists, daggers, etc.
        /// </summary>
        Melee = 1,
        /// <summary>
        /// Ranged weapons like projectile weapons, such as bows, crossbows, matchlocks, etc.
        /// </summary>
        Ranged = 2,
        /// <summary>
        /// Any sort of magic weapon, like fireballs, lightning, summoned water, etc.
        /// </summary>
        Magic = 3
    }
}
