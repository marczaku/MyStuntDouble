Player marc = null;
if (marc != null) // null checks
{
    marc.Health = 100; // access a field for writing
    Console.WriteLine(marc.Health); // access a field for reading
}
public class Player
{
    public int Health; // adding fields to classes
    public string Name;
}


// int: 0
// float: 0f
// char: 0 (\0)
// bool: 0 (false)
// string: null ""