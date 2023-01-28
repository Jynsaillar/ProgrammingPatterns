using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Version3
{
    internal interface IActor
    {
        int Health { get; }

        public void SetHealth(int value);
        public int GetHealth();
    }
}
