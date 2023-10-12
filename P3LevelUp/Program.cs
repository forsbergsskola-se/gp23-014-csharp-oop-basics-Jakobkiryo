Player player = new Player();

while (true)
{
    Console.WriteLine($"How much XP do you want? LVL: {player.Level} XP: {player.Experience}");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int experience))
    {
        player.Levelstatus(experience);
        Console.WriteLine($"Current Level: {player.Level}, Remaining Experience: {player.Experience}\n");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a numeric value.");
    }
}
