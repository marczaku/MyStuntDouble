public class House
{
    public string Name;
    public bool IsDoorOpen;

    public void OpenDoor()
    {
        this.IsDoorOpen = true;
    }

    public void CloseDoor()
    {
        this.IsDoorOpen = false;
    }
}