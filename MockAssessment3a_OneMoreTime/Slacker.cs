using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a_OneMoreTime
{
    class Slacker : Villager
    {
        //prop
        //const
        public Slacker()
        {
            Hunger = 3;
        }

        //methods
        public override int Farm()
        {
            return 0;
        }
    }
}
