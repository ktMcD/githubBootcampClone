namespace MockAssessment3
{
    public class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town()
        {
            Villagers = new List<Villager>();   
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            // Without LINQ
            int returnSum = 0;
            foreach (var villager in Villagers)
            {
                returnSum += villager.Farm();
            }

            // With LINQ
            returnSum = Villagers.Sum(x => x.Farm());

            return returnSum;
        }

        public int CalcFoodConsumption()
        {
            // Without LINQ
            int returnSum = 0;
            foreach (var villager in Villagers)
            {
                returnSum += villager.Hunger;
            }

            // With LINQ
            returnSum = Villagers.Sum(x => x.Hunger);

            return returnSum;
        }

        public bool SurviveTheWinter()
        {
            int harvest = Harvest();
            int consumption = CalcFoodConsumption();

            return harvest >= consumption;
        }
    }
}
