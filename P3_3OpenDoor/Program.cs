House redHouse = new House(){Name = "Red"};
House blueHouse = new House(){Name = "Blue"};

Console.WriteLine($"Doors Open?");
Console.WriteLine($"Red House: {redHouse.IsDoorOpen}");
Console.WriteLine($"Blue House: {blueHouse.IsDoorOpen}");

redHouse.OpenDoor();
Console.WriteLine($"Doors Open?");
Console.WriteLine($"Red House: {redHouse.IsDoorOpen}");
Console.WriteLine($"Blue House: {blueHouse.IsDoorOpen}");

blueHouse.OpenDoor();
Console.WriteLine($"Doors Open?");
Console.WriteLine($"Red House: {redHouse.IsDoorOpen}");
Console.WriteLine($"Blue House: {blueHouse.IsDoorOpen}");