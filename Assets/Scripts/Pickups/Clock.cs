public class Clock : Pickup
{
    public int timeToAdd = 10;

    public override void Picked()
    {
        base.Picked();
        GameManager.instance.AddTime(timeToAdd);
    }

    private void Update()
    {
        Rotation();
    }
}