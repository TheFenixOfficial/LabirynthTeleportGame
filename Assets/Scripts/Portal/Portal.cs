using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform portalCollider;
    public Portal otherPortal;

    private GameObject player;
    private PortalTeleport portalTeleport;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        portalTeleport = portalCollider.GetComponent<PortalTeleport>();
        portalTeleport.player = player.transform;
        portalTeleport.receiver = otherPortal.portalCollider;   
    }
}