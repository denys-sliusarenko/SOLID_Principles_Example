﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Classes
{
    internal abstract class MealBase
    {
        public void Make()
        {
            Prepare();
            Cook();
            FinalSteps();
        }
        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
    }
}
