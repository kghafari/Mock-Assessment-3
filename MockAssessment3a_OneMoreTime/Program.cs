using System;

namespace MockAssessment3a_OneMoreTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Town myTown = new Town();
            
            Console.WriteLine(myTown.Harvest());
            Console.WriteLine(myTown.CalcFoodConsumption());
            Console.WriteLine(myTown.SurviveTheWinter());

        }
    }
}
