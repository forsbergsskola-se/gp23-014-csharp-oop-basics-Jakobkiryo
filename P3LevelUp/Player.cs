
public class Player
{
    public int Level = 0;
    public int Experience = 0;

    public void Levelstatus(int XP)
    {
        Experience += XP;
        while (Experience >=100)
        {
            Experience -= 100;
            Level++;
            Console.WriteLine($"Level Up! LVL: {Level} XP: {Experience}");
            
        }
    }
}