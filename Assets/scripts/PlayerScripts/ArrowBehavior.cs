using UnityEngine;
using System.Collections;
using System;

public class ArrowBehavior : MonoBehaviour {
	public float speed = 5f;
	public float damage = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D othercollider){

		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties> ();

		//when it hits, do damage 

		if (otherproperties != null && !otherproperties.isplayer) {
		


						otherproperties.dealdamage (damage);
						Destroy (this.gameObject);
				}

		
		

						




	}

	void OnTriggerExit2D(Collider2D othercollider){

	






	}




}
