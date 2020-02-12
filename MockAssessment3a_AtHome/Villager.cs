using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a_AtHome
{
    abstract class Villager
    {
        public int Hunger { get; set; }

        public abstract int Farm();

    }
}
