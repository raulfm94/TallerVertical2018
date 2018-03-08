using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomActions : MonoBehaviour {
    private Vector3 startingPosition;
    private Renderer renderer;

    public float valX;
    public float valY;
    public float valZ;

    public GameObject Player;
    public GameObject zoomTarget;
    public Vector3 positionToZoom;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    // Use this for initialization
    void Start () {
        startingPosition = transform.localPosition;
        renderer = GetComponent<Renderer>();
        SetGazedAt(false);
    }

    // Looking at the object actions
    public void SetGazedAt(bool gazedAt)
    {
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            renderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }

    // El acercamiento
    public void ZoomingOnObject()
    {
        // First click to get coordinates of object
        positionToZoom = zoomTarget.transform.position;

        // Move Player to that position
        Player.transform.position = new Vector3(positionToZoom.x - 10, positionToZoom.y, positionToZoom.z - 10);

        // Function needs to be adjusted for the size of map... this thing is horrible sized
        // Reticle acts until very close to object
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
    // Update is called once per frame
    void Update () {
		
	}
}
