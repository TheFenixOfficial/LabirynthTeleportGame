using UnityEngine;

public enum KeyColor
{
    Red,
    Green,
    Gold
}

public class Key : Pickup
{
    public KeyColor keyColor;

    public Material red;
    public Material green;
    public Material gold;

    public override void Picked()
    {
        base.Picked();
        GameManager.instance.AddKey(keyColor);
    }

    private void Update()
    {
        Rotation();
    }

    private void Start()
    {
        SetMyColor();
    }

    private void SetMyColor()
    {
        switch (keyColor)
        {
            case KeyColor.Red:
                GetComponent<Renderer>().material = red;
                break;
            case KeyColor.Green:
                GetComponent<Renderer>().material = green;
                break;
            case KeyColor.Gold:
                GetComponent<Renderer>().material = gold;
                break;
        }
    }
}