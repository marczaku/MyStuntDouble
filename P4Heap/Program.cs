Player p1 = new Player(); // p1 = #1
ChangePlayer(p1); // #1
Console.WriteLine(p1.experience); // #1.experience


void ChangePlayer(Player player) // #1
{
    player = new Player(); // #2
    player.experience = 200; // #2.experience = 200
}