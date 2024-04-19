using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField]
    protected Vector3 rotationSpeed;

    [SerializeField]
    protected AudioClip pickupClip;

    public virtual void Picked()
    {
        GameManager.instance.PlayClip(pickupClip);
        Debug.Log("Picked up!");
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(rotationSpeed);
    }
}