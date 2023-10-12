class program
{
    static void Main()
    {
        Plant plant = new Plant();
        Grain grain = new Grain();
        Wheat wheat = new Wheat();
        
        
        plant.CanGrow();
        
        grain.CanGrow();
        grain.CanBeHarvested();
        
        wheat.CanGrow();
        wheat.CanBeHarvested();
        wheat.ToBread();
    }
}