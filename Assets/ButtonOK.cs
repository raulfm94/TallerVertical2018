using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOK : MonoBehaviour {

	private Animator am;
	public bool activate;

	// Use this for initialization
	void Start () {
		am = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		am.SetBool ("Activate", activate);
	}

	public void StartCoroutine(){
		activate = true;
		StartCoroutine ("DestroyButton");
	}

	IEnumerator DestroyButton(){
		while(true){
			yield return new WaitForSeconds(5);
			Destroy(this.gameObject);
			
		}
	}

	public void FalseActivate(){
		activate = false;
	}
}
