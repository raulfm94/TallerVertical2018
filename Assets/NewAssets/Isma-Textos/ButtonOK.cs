using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

	// AQUI OCURRE LA INTERACCIÓN CON EL MENU, LA DESTRUCCIÓN DEL MISMO Y EL CAMBIO DE ESCENA. 
	IEnumerator DestroyButton(){
		while(true){
			yield return new WaitForSeconds(5);
			Destroy(this.gameObject);
			SceneManager.LoadScene("Scene1");

			
		}
	}

	public void FalseActivate(){
		activate = false;
	}
}
