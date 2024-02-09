public class PointCrystal : Pickup
{
    public int points = 5;

    public override void Picked()
    {
        base.Picked();
        GameManager.instance.AddPoints(points);
    }

    private void Update()
    {
        Rotation();
    }
}