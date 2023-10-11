//Status on different values in for an example RTS Game.

Player player = new Player();

player.gold = 200;
Console.WriteLine($"Gold: {player.gold}");

player.stone = 110;
Console.WriteLine($"Stone: {player.stone}");

player.wood = 53;
Console.WriteLine($"Wood: {player.wood}");

player.level = 12;
Console.WriteLine($"Level: {player.level}");

player.experience = 123;
Console.WriteLine($"Experience: {player.experience}");

player.ActiveVIPSubscription = true;
Console.WriteLine($"VIP enabled?: {player.ActiveVIPSubscription}");

player.ActivePVP = false;
Console.WriteLine($"PVP enabled?: {player.ActivePVP}");

player.Name = "Jakob";
Console.WriteLine($"Name: {player.Name}");

player.email = "Jakobkiryo@hotmail.com";
Console.WriteLine($"Email: {player.email}");