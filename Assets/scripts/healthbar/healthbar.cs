using UnityEngine;
using System.Collections;

public class healthbar : MonoBehaviour {
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private myProperties thisproperties;
	private float myhealth;

	// Use this for initialization
	void Start () {
		healthBar = GameObject.Find("healthbar_0").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;


		thisproperties = gameObject.GetComponent<myProperties>();

		myhealth = thisproperties.hp;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void UpdateHealthBar ()
	{
		// Set the health bar's colour to proportion of the way between green and red based on the player's health.
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - myhealth * 0.01f);
		
		// Set the scale of the health bar to be proportional to the player's health.
		healthBar.transform.localScale = new Vector3(healthScale.x * myhealth * 0.01f, 1, 1);
	}

}
