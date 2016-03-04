using UnityEngine;
using System.Collections;

public class Seleccion : MonoBehaviour {

	public GameObject personaje1;//imagen deljugador
	public GameObject personaje2;//imagen deljugador

	public GameObject pj1;//selector
	public GameObject pj2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		pj1 = GameObject.FindGameObjectWithTag ("steve");
		pj2 = GameObject.FindGameObjectWithTag ("pool");

		if (pj1 == true) {
			personaje1.SetActive (true);
		} else if (pj2 == true) {
			personaje2.SetActive (true);
		}
	}
}
