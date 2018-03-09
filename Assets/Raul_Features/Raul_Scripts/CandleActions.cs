using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActions : MonoBehaviour {

    private Vector3 startingPosition;
    private Renderer renderer;

    // The one that will zoom
    public GameObject Player;
    // The target of the zoom
    public GameObject Target;
    // Where to zoom (coordinates)
    public Vector3 positionToZoom;
    // Coordinates to return to after zoom
    public Vector3 positionToReturn;
    // Boolean to know status of zoom
    private bool zoomStatus;
    // Motion Controls
    private VRLookWalk movementControls;
    // Lights to activate/deactivate
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    // Sea is fckn light?
    public GameObject sea;
    // Fire sound
    private AudioSource fire;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start()
    {
        startingPosition = transform.localPosition;
        renderer = GetComponent<Renderer>();
        SetGazedAt(false);
        zoomStatus = false;
        fire = GetComponent<AudioSource>();
        movementControls = Player.GetComponent<VRLookWalk>();
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            renderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }

    public void ZoomIn()
    {
        // Change zoom Status
        zoomStatus = true;
        // Store original character coordinates
        positionToReturn = Player.transform.position;
        // Get coordinates of target
        positionToZoom = Target.transform.position;
        Debug.Log("Zoom Coordinates: " + positionToZoom);

        // Move Player to that position
        Player.transform.position = new Vector3(positionToZoom.x - 2, positionToZoom.y + 3, positionToZoom.z + 2);
        // Make Player unable to move, only look
        movementControls.enabled = false;
        // Function needs to be adjusted for the size of map... this thing is horrible sized
        // Reticle acts until very close to object

        // Activate Candle sound
        CandleFireSound();
        CandleLightning();
    }

    public void ZoomOut()
    {
        // Change zoom Status
        zoomStatus = false;
        // Needs original coordinates of character to return
        Debug.Log("Return Coordinates: " + positionToReturn);
        // Send Player to those coordinates
        Player.transform.position = new Vector3(positionToReturn.x, positionToReturn.y, positionToReturn.z);

        movementControls.enabled = true;

        CandleFireSound();
        CandleLightning();
    }

    public void ZoomHandler()
    {
        if (zoomStatus == false)
        {
            ZoomIn();
        } else if (zoomStatus == true)
        {
            ZoomOut();
        } else
        {
            Debug.Log("You somehow fckd up????");
        }
    }

    public void CandleFireSound()
    {
        if (zoomStatus == true)
        {
            fire.enabled = true;
        }
        else if (zoomStatus == false)
        {
            fire.enabled = false;
        }
        else
        {
            Debug.Log("You somehow fckd up????");
        }
    }

    public void CandleLightning()
    {
        if (zoomStatus == true)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            sea.SetActive(false);
            light4.SetActive(true);
            Debug.Log("Who turned of the lights?");
        }
        else if (zoomStatus == false)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            sea.SetActive(true);
            light4.SetActive(false);
            Debug.Log("My eyes!!!! It burns");
        }
        else
        {
            Debug.Log("You somehow fckd up????");
        }
    }

    public void Recenter()
    {
#if !UNITY_EDITOR
      GvrCardboardHelpers.Recenter();
#else
        if (GvrEditorEmulator.Instance != null)
        {
            GvrEditorEmulator.Instance.Recenter();
        }
#endif  // !UNITY_EDITOR
    }
}
