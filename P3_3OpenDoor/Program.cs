// See https://aka.ms/new-console-template for more informatio
House redHouse = new House();

House blueHouse = new House();

Console.WriteLine($"Doors Open?");
Console.WriteLine($"Red House: {redHouse.IsDoorOpen}");
Console.WriteLine($"Blue House: {blueHouse.IsDoorOpen}");
redHouse.Opendoor();
//
Console.WriteLine($"Doors Open?");
Console.WriteLine($"Red House: {redHouse.IsDoorOpen}");
Console.WriteLine($"Blue House: {blueHouse.IsDoorOpen}");
blueHouse.Opendoor();