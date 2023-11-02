

public class Monster
{
    public int Health;

    public void Attack(Player target)
    {
        target.Health--;
        Console.WriteLine($"Monster Attacks you. You have {target.Health} Health");
    }
    
}