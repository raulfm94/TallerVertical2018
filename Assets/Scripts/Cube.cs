using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScipt : MonoBehaviour {
	//Array de Materiales
	public Material[] material;
	Renderer rend;

	//Para Generar un numero random para el array de material
	int random;

	// Use this for initialization
	void Start () {
		random = Random.Range(0, 3);
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		//Inicializa un material random para el objeto
		rend.sharedMaterial = material [random];
	}

	void OnCollisionEnter(Collision col){
		//Aqui detecta con que esta haciendo collision
		if (col.gameObject.name == "circulo") {
			int random2 = Random.Range(0, 3);
			rend.sharedMaterial = material [random2];
		}

		else{
			int random2 = Random.Range(0, 3);
			rend.sharedMaterial = material [random2];

		}
	}

}
