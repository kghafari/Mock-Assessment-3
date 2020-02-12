using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3a
{
    class Town
    {
        public List<Villager> Villagers { get; set; }
        //
        //const
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

        //methods
        public int Harvest()
        {
            int result = 0;
            foreach (Villager person in Villagers)
            {
                result += person.Farm();
            }
            return result;
        }

        public int CalcFoodConsumption()
        {
            int hunger = 0;
            foreach (Villager person in Villagers)
            {
                hunger += person.Hunger;
            }
            return hunger;
        }

        public bool SurviveTheWinter()
        {
            int harvestResult = Harvest();
            int amtEaten = CalcFoodConsumption();
            if (amtEaten <= harvestResult )
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
