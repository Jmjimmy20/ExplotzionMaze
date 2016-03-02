using UnityEngine;
using System.Collections;

public class botonesMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void Jugar (){
		Application.LoadLevel ("_Scenes/1");
	}
}

