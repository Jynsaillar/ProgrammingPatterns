﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.StrategyPattern.Variant2
{
    public class StrategyContext
    {
        IStrategy? _activeStrategy;

        public StrategyContext(IStrategy? strategy)
        {
            _activeStrategy = strategy;
        }

        public void DoAction()
        {
            _activeStrategy?.DoAction();
        }

        public void SetAction(IStrategy? strategy)
        {
            _activeStrategy = strategy;
        }
    }
}
