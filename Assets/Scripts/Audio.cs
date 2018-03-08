using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
	//Array de Sonidos
	public AudioClip[] sounds;
	public float volume;
	AudioSource audio;

	int random;

	void Start () {
		random = Random.Range(0, 3);
		audio = GetComponent<AudioSource> ();
		volume = 50.0f;
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.name == "Sphere") {
			//Hace un sonido si es collision con una esfera o cualquier otro objeto de nombre especificado
			int random2 = Random.Range(0, 3);
			audio.PlayOneShot (sounds[random2], volume);
			//Inicia el audio X en tal volumen, 50% en este caso
		}
		else{
			//si hace collision con un objeto de nombre no especificado
			int random2 = Random.Range(0, 3);
			audio.PlayOneShot (sounds[random2], volume);
			//Inicia el audio X en tal volumen, 50% en este caso
		}
	}
}
