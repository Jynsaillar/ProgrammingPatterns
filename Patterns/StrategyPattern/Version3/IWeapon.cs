using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
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
