

public class Player
{
    public int Health;

    public void Attack(Monster target)
    {
        target.Health--;
        Console.WriteLine($"You attack the monster. it has {target.Health} Health");
    }

    public void Heal()
    {
        this.Health = 3;
        Console.WriteLine($"You healed yourself. you now have {this.Health} Health");
    }
}