
public class Player

{
    public int Level;
    public int Experience;

    public void IncreaseExperience()
    {
        Experience++;
        
        //level up
        if (Experience > 4)
        {
            Level++;
            Experience = 0;
        }

        Console.WriteLine($"Lvl:{Level}, Exp: {Experience}");
    }
}