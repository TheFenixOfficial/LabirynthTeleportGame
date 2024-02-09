using System.Drawing;

public enum KeyColor
{
    Red,
    Green,
    Gold
}

public class Key : Pickup
{
    public KeyColor keyColor;

    public override void Picked()
    {
        base.Picked();
        GameManager.instance.AddKey(keyColor);
    }

    private void Update()
    {
        Rotation();
    }
}