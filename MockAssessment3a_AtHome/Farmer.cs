using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a_AtHome
{
    class Farmer : Villager
    {
        //fields
        //properties
        //constructors
        public Farmer()
        {
            Hunger = 1;
        }
        //methods
        public override int Farm()
        {
            return 2;
        }
    }
}
