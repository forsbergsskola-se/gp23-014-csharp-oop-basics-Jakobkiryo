
{ 
    //Spawns 2 objects/knights one attacker and one defender
    Knight Attacker = new Knight();
    Knight Defender = new Knight();
    
    //Spawns a shield for the knight
    Defender.Shield = new Shield();
    
    //Attacking Knight attacks Barehanded
    Attacker.Attack(Defender);
    
    //Attacking Knight Equips a sword
    Attacker.Sword = new Sword();
    Console.WriteLine("Equipping Sword...");
    
    //The attacking knight attacks the defender with different outcome
    Attacker.Attack(Defender);
    Attacker.Attack(Defender);
}
