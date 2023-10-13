
{ 
    //Spawns 2 obejcts/knights one attacker and one defender
    Knight Attacker = new Knight();
    Knight Defender = new Knight();
    
    //Spawns a shield for the knight
    Defender.Shield = new Shield();
    
    Attacker.Attack(Defender);
    
    //Spawns a new sword
    Attacker.Sword = new Sword();
    Console.WriteLine("Equipping Sword...");
    
    //The attacking knight attacks the defender with different outcome
    Attacker.Attack(Defender);
    Attacker.Attack(Defender);
}
