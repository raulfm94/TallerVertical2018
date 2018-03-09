using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkActions : MonoBehaviour {

    // Door to be closed
    public GameObject doors;
    // Also needs a player
    public GameObject Player;
    // Counter for audio track
    public int counterTrack;
    // Audios to be enabled...
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8;
    public AudioSource audio9;
    public AudioSource audio10;
    // Scripts to enable/disable
    private VRLookWalk movementControls;
    // Interactive objects enable/disable
    public GameObject magicCandle;
    private MeshCollider candleMesh;
    // Use this for initialization
    void Start ()
    {
        counterTrack = 0;
        movementControls = Player.GetComponent<VRLookWalk>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void timelineHandler()
    {
        //doorClose();
        //audio1.enabled = true;
        counterTrack = counterTrack + 1;
        //candleOption();
        Debug.Log("Wait for it");
        
        //yield new WaitForSeconds(5);
        Debug.Log("This is going to be");
        Debug.Log("Legend....");
        Debug.Log("....ary");

        animationHandler(counterTrack);
    }

    public void doorClose()
    {
        doors.SetActive(true);
        Debug.Log("Puertas cerradas");
    }

    public void candleOption()
    {
        candleMesh = magicCandle.GetComponent<MeshCollider>();
        candleMesh.enabled = true;
        Debug.Log("Candle Activated");
    }

    public void walkingNotAllowed()
    {
        movementControls.enabled = false;
        Debug.Log("No legs");
    }

    public void walkingAllowed()
    {
        movementControls.enabled = true;
        Debug.Log("Got your legs back");
    }

    public void animationHandler(int input)
    {
		Debug.Log ("La funcion fue llamada");
        switch (input)
        {
            case 1:
                Debug.Log("Track1");
                audio1.enabled = true;
                doorClose();
                break;
            case 2:
                Debug.Log("Track2");
                audio1.enabled = false;
                audio2.enabled = true;
                break;
            case 3:
                Debug.Log("Track3");
                audio2.enabled = false;
                audio3.enabled = true;
                break;
            case 4:
                Debug.Log("Track4");
                audio3.enabled = false;
                audio4.enabled = true;
                walkingNotAllowed();
                break;
            case 5:
                Debug.Log("Track5");
                audio4.enabled = false;
                audio5.enabled = true;
                break;
            case 6:
                Debug.Log("Track6");
                audio5.enabled = false;
                audio6.enabled = true;
                break;
            case 7:
                Debug.Log("Track7");
                audio6.enabled = false;
                audio7.enabled = true;
                walkingAllowed();
                break;
            case 8:
                Debug.Log("Track8");
                audio7.enabled = false;
                audio8.enabled = true;
                candleOption();
                break;
            case 9:
                Debug.Log("Track9");
                audio8.enabled = false;
                audio9.enabled = true;
                break;
            case 10:
                Debug.Log("Track10");
                audio9.enabled = false;
                audio10.enabled = true;
                break;
            default:
                Debug.Log("Default Case");
                break;
        }
    }
}
