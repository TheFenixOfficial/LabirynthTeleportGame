using UnityEngine;

public class Pickup : MonoBehaviour
{
    public void Picked()
    {
        Debug.Log("Picked Up!");
        Destroy(gameObject);
    }
}