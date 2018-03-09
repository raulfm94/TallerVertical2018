using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkActions : MonoBehaviour {

    Animator anim;
    //public int animCase;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void animationHandler(int input)
    {
        switch (input)
        {
            case 1:
                Debug.Log("Breath");
                anim.SetLayerWeight(1, 0.5f);
                anim.SetLayerWeight(4, 0.5f);
                break;
            case 2:
                Debug.Log("Endereza");
                anim.SetLayerWeight(2, 0.5f);
                anim.SetLayerWeight(4, 0.5f);
                break;
            case 3:
                Debug.Log("Hablando");
                anim.SetLayerWeight(3, 0.5f);
                anim.SetLayerWeight(4, 0.5f);
                break;
            case 4:
                Debug.Log("Idle");
                anim.SetLayerWeight(4, 1f);
                break;
            case 5:
                Debug.Log("LookAround");
                anim.SetLayerWeight(5, 0.5f);
                anim.SetLayerWeight(4, 0.5f);
                break;
            case 6:
                Debug.Log("Voltea");
                anim.SetLayerWeight(6, 0.5f);
                anim.SetLayerWeight(4, 0.5f);
                break;
            default:
                Debug.Log("Default Case");
                anim.SetLayerWeight(4, 1f);
                break;
        }
    }
}
