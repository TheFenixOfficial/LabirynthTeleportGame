using UnityEngine;

public class Portal : MonoBehaviour
{
    public Portal otherPortal;
    public Material material;

    public Transform portalCollider;
    private Camera myCamera;
    private Transform renderSurface;

    private GameObject player;
    private PortalTeleport portalTeleport;
    private PortalCamera portalCamera;


    private void Awake()
    {
        myCamera = gameObject.transform.Find("PortalCamera").GetComponent<Camera>();
        renderSurface = gameObject.transform.Find("RenderSurface");
        portalCollider = gameObject.transform.Find("Collider");

        player = GameObject.FindGameObjectWithTag("Player");

        portalTeleport = portalCollider.GetComponent<PortalTeleport>();
        portalTeleport.player = player.transform;
        portalTeleport.receiver = otherPortal.portalCollider;
        
        portalCamera = myCamera.GetComponent<PortalCamera>();
        portalCamera.playerCamera = player.GetComponentInChildren<Camera>().transform;
        portalCamera.portal = transform;
        portalCamera.otherPortal = otherPortal.transform;

        renderSurface.GetComponent<Renderer>().material = Instantiate(material);
        if (myCamera.targetTexture != null)
        {
            myCamera.targetTexture.Release();
        }
        myCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

    }

    private void Start()
    {
        renderSurface.GetComponent<Renderer>().material.mainTexture = otherPortal.GetComponent<Portal>().myCamera.targetTexture;
    }
}