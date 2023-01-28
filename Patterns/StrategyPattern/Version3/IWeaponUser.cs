using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    internal interface IWeaponUser
    {
        IWeapon Weapon { get; }

        void SetWeapon(IWeapon weapon);
    }
}
