Person marc = new Person(); // #1
House redHouse = new House(); // #2
House blueHouse = new House(); // #3
marc.Name = "Marc;"; // #1
redHouse.Owner = marc; // #2's Owner -> #1
blueHouse.Owner = marc; // #3's Owner -> #1
marc.Name = "Alex"; // #1
Console.WriteLine();
public class House
{
    public Door FrontDoor;
    public Door BackDoor;
    public Person Owner;

    public void Enter()
    {
        this.FrontDoor.OpenDoor();
        // enter
        this.FrontDoor.CloseDoor();
    }

    public void EnterGarden()
    {
        this.BackDoor.OpenDoor();
        // enter
        this.BackDoor.CloseDoor();
    }
}

public class Door
{
    public bool isOpen;
    public void OpenDoor()
    {
        isOpen = true;
    }

    public void CloseDoor()
    {
        isOpen = false;
    }
}

public class Person
{
    public string Name;
}

public class Pizza
{
    
}