using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour 
{
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
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (Input.GetKeyDown ("w")) {
			anim.Play ("Corre", -1, 0f);
		} else if (Input.GetKeyUp ("w")) {
			anim.Play ("Idle", -1, 0f);
		}else if (Input.GetKeyDown ("s")) {
			anim.Play ("Corre", -1, 0f);
		} else if (Input.GetKeyUp ("s")) {
			anim.Play ("Idle", -1, 0f);
		}
			
		transform.Translate(0f, 0f , v * speed * Time.deltaTime);
		transform.Rotate (0f, h * rotation * Time.deltaTime, 0f);


		//sahgdsajdgsajdhgsdjhsagdasjhdfas
		if (Input.GetKeyDown (KeyCode.Y)) 
		{
			health.CurrentVal -= 10;

		}
		if (Input.GetKeyDown (KeyCode.U)) 
		{
			health.CurrentVal += 10;

		}
	}
		
}
