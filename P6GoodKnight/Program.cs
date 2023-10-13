
{
    //start of the game
    Console.WriteLine("RPG Scenario:");
    
    //Spawns 2 similar Knights
    Knight Attacker = new Knight();
    Knight Enemy = new Knight();
    
    //Spawns a shield for the knight
    Enemy.Shield = new Shield();
    
    //Attacking Knight attacks Barehanded
    Attacker.Attack(Enemy);
    
    //Attacking Knight Equips a sword
    Attacker.Sword = new Sword();
    Console.WriteLine("Knight is Equipping Sword...");
    
    //The attacking knight attacks the defender with different outcome
    Attacker.Attack(Enemy);
    
    Attacker.Attack(Enemy);
}
