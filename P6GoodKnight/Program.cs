
{

    Knight Attacker = new Knight();
    Knight Defender = new Knight();

    Defender.Shield = new Shield();
    
    Attacker.Attack(Defender);

    Attacker.Sword = new Sword();
    Console.WriteLine("Equipping Sword...");
    
    Attacker.Attack(Defender);
    Attacker.Attack(Defender);
}
