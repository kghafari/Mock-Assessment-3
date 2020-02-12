using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a
{
    class Slacker : Villager
    {
        public Slacker()
        {
            Hunger = 3;
        }

        public override int Farm()
        {
            return 0;
        }

    }
}
