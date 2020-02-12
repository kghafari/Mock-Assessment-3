using System;

namespace MockAssessment3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Town myTown = new Town();
            bool survived = myTown.SurviveTheWinter();

            Console.WriteLine(myTown.Harvest());
            Console.WriteLine(myTown.CalcFoodConsumption());
            Console.WriteLine(survived);
        }
    }
}
