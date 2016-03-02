using UnityEngine;
using System.Collections;

public class PausaMenu : MonoBehaviour {

	public GameObject objPausa;

	// Use this for initialization
	void Start () {
		objPausa.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			cambio ();
		}
	}

	public void cambio(){
		if (Time.timeScale == 1) {
			Pause ();
		}else if(Time.timeScale == 0){
			Continuar ();
		}
	}

	public void Pause(){
		objPausa.SetActive (true);
		Time.timeScale = 0;
	}

	public void Continuar (){
		objPausa.SetActive (false);
		Time.timeScale = 1;
	}
	public void Menu(string i){
		Application.LoadLevel(i);

	}

	public void MenuPrincipal(){
		Application.LoadLevel ("_Scenes/MenuPrincipal");
	}

}
