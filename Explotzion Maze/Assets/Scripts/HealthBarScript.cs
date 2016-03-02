using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Para poder utilizar el UI
public class HealthBarScript : MonoBehaviour
{
	[SerializeField] //muestra las variables privadas en el inspector tambien O:
	private float fillAmount;

	[SerializeField]
	private Image contenido; 

	public float MaxValue{ get; set;}

	public float Value
	{

		set
		{
			fillAmount = Map (value, 0f, MaxValue, 0f, 1f);
		}

	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		HandleBar ();
	}

	private void HandleBar()
	{
		if (fillAmount != contenido.fillAmount) 
		{
			contenido.fillAmount = fillAmount;
		}
	}

	private float Map(float value, float healthMin, float healthMax, float minBar, float maxBar)
	{

		return (value - healthMin) * (maxBar - minBar) / (healthMax - healthMin) + minBar;
		/*
		 * value valor de la barra de vida actual
		 * healthMin valor minimo de la barra(ex: 0)
		 * healtMax valor maximo de la barra(ex: 250)
		 * minBar valor del fill minimo, en este caso 0
		 * maxBar valor del fill maximo, en este caso 1
		 * 
		*/

	}

}
