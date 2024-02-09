using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField]
    protected Vector3 rotationSpeed;

    public virtual void Picked()
    {
        Debug.Log("Picked up!");
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(rotationSpeed);
    }
}