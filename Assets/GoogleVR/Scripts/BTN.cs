using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTN : MonoBehaviour {

	private Camera cam; 
	private Transform cameraTransform;

	// Use this for initialization
	void Start () {
		cameraTransform = GameObject.Find("Main Camera").transform;
		cam = cameraTransform.GetComponent<Camera> ();

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit, 10000)){
				Debug.DrawLine(ray.origin, ray.direction);
				Debug.Log("Clicked on" + hit.transform.gameObject.name);
				Destroy(hit.transform.gameObject);
			}
				
		}
	}
}
