Player player1 = new Player();
Player player2 = new Player();

player1.Attack(player2);

Console.WriteLine("Player 1 attacks: Player 2");
Console.WriteLine("Player 1 DMG:" + player1.damage);
Console.WriteLine("Player 2 DMG:" + player2.damage);

player2.Attack(player1);

Console.WriteLine("Player 2 attacks: Player 1");
Console.WriteLine("Player 1 DMG:" + player1.damage);
Console.WriteLine("Player 2 DMG:" + player2.damage);


player1.Attack(player1);

Console.WriteLine("Player 1 Attacks: Player 1");
Console.WriteLine("Player 1 DMG:" + player1.damage);
Console.WriteLine("Player 2 DMG:" + player2.damage);

Player player3 = player1;

player2.Attack(player3);

Console.WriteLine("Player 2 Attacks: player 1");
Console.WriteLine("Player 1 DMG:" + player1.damage);
Console.WriteLine("Player 2 DMG:" + player2.damage);
Console.WriteLine("Player 3 DMG:" + player3.damage);

