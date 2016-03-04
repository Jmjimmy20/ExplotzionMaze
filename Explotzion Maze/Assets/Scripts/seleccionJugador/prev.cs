using UnityEngine;
using System.Collections;

public class prev : MonoBehaviour {

	public GameObject personaje1;//imagen deljugador
	public GameObject personaje2;//imagen deljugador

	public GameObject pj1;//selector
	public GameObject pj2;//selector

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Input.GetMouseButtonDown(a)
	//si a =0 --> click izquierdo
	//si a =1 --> click centro
	//si a =2 --> click derecho
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			if (personaje1.activeSelf) {
				personaje1.SetActive (false);
				personaje2.SetActive (true);
				pj1.SetActive (false);
				pj2.SetActive (true);
			}else if(personaje2.activeSelf){
				personaje1.SetActive (true);
				personaje2.SetActive (false);
				pj1.SetActive (true);
				pj2.SetActive (false);
			}


		}
	}



}
