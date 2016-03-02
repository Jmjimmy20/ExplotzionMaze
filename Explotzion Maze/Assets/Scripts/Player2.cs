using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	public float speed = 50f;
	public float rotation = 150f;
	public Animator anim;

	[SerializeField]
	private Stat health;

	private void Awake()
	{
		health.Initialize ();

	}
	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis("Horizontal2");
		float v = Input.GetAxis("Vertical2");

		if (Input.GetKeyDown ("up")) {
			anim.Play ("Corre", -1, 0f);
		} else if (Input.GetKeyUp ("up")) {
			anim.Play ("Idle", -1, 0f);
		}else if (Input.GetKeyDown ("down")) {
			anim.Play ("Corre", -1, 0f);
		} else if (Input.GetKeyUp ("down")) {
			anim.Play ("Idle", -1, 0f);
		}

		transform.Translate(0f, 0f , v * speed * Time.deltaTime);
		transform.Rotate (0f, h * rotation * Time.deltaTime, 0f);


		//sahgdsajdgsajdhgsdjhsagdasjhdfas
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			health.CurrentVal -= 10;

		}
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			health.CurrentVal += 10;

		}

	}

}		

