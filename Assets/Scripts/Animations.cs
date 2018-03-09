using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

	private Animator animator;
	public int layerNumber;
	public float weight;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void ActivateTalking(){
		animator.SetLayerWeight (1, 1);
	}

	void DeactivateTalking(){
		animator.SetLayerWeight(1, 0);
	}

	void ActivateTurnAround(){
		animator.SetLayerWeight (2, 1);
	}

	void DeactivateTurnAround(){
		animator.SetLayerWeight (2, 0);
	}

	void ActivateLookAround(){
		animator.SetLayerWeight (3, 1);
	}

	void DeactivateLookAround(){
		animator.SetLayerWeight (3, 0);
	}

	void ActivateStraighten(){
		animator.SetLayerWeight (4, 1);
	}

	void DeactivateStraighten(){
		animator.SetLayerWeight (4, 0);
	}


	void ActivateBreath(){
		animator.SetLayerWeight (5, 1);
	}

	void DeactivateBreath(){
		animator.SetLayerWeight (5, 0);
	}
}
