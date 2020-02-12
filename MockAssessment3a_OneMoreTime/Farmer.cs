using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a_OneMoreTime
{
    class Farmer : Villager
    {
        //props

        //consts
        public Farmer()
        {
            Hunger = 1;
        }

        //mthods
        public override int Farm()
        {
            return 2;
        }

    }
}
