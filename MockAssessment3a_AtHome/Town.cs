using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a_AtHome
{
    class Town
    {
        //fields - none
        //properties 
        public List<Villager> Villagers;

        //constructors
        public Town()
        {
            Villagers = new List<Villager>
            {
                new Farmer(),
                new Slacker(),
                new Slacker(),
                new Slacker(),
            };
        }

        public int Harvest()
        {
            int total = 0;
            foreach (Villager person in Villagers)
            {
                total += person.Farm();
            }
            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach (Villager person in Villagers)
            {
                total += person.Hunger;
            }
            return total;
        }

        public bool SurviveTheWinter()
        {
            int harvest = Harvest();
            int consumption = CalcFoodConsumption();

            if (consumption <= harvest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
