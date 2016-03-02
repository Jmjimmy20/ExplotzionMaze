using UnityEngine;
using System.Collections;

public class Disparo_Bomba : MonoBehaviour {

		public int Jugador = 1;              // Used to identify the different players.
		public Rigidbody Bomba;                   // Prefab of the shell.
		public Transform DisparoTransf;           // A child of the tank where the shells are spawned.
		//public Slider m_AimSlider;                  // A child of the tank that displays the current launch force.
		/*public AudioSource m_ShootingAudio;         // Reference to the audio source used to play the shooting audio. NB: different to the movement audio source.
		public AudioClip m_ChargingClip;            // Audio that plays when each shot is charging up.
		public AudioClip m_FireClip;                // Audio that plays when each shot is fired.
		public float m_MinLaunchForce = 15f;        // The force given to the shell if the fire button is not held.
		public float m_MaxLaunchForce = 30f;        // The force given to the shell if the fire button is held for the max charge time.
		public float m_MaxChargeTime = 0.75f;       // How long the shell can charge for before it is fired at max force.
		private float m_CurrentLaunchForce;         // The force that will be given to the shell when the fire button is released.
		private float m_ChargeSpeed;                // How fast the launch force increases, based on the max charge time.
		*/
		public float FuerzaDisparo=20f;
		private string Tecla_Disparo;                // The input axis that is used for launching shells.
		//private bool Disparo;                       // Whether or not the shell has been launched with this button press.

		private void Start ()
		{
			Tecla_Disparo = "Fire" + Jugador;
		}


		private void Update ()
		{
			if (Input.GetButtonUp (Tecla_Disparo))
			{
				Fire ();
				//Disparo = false;
			}
		}


		private void Fire ()
		{
			//Disparo = true;

			Rigidbody shellInstance =
				Instantiate (Bomba, DisparoTransf.position, DisparoTransf.rotation) as Rigidbody;

			// Velocidad de disparo
			shellInstance.velocity = FuerzaDisparo * DisparoTransf.forward;

		}
}

