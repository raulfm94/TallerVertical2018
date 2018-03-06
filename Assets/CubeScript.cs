using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;// Required when using Event data.


public class CubeScript : MonoBehaviour {

	public void OnGazeEnter(){
		Debug.Log ("Gaze entered");
	}

	public void OnGazeLeave(){
		Debug.Log ("Gaze left");
	}

	public void Fire(){
		//transform.position += new Vector3 (2, 0, 0);
		print("Holi");
	}
}
