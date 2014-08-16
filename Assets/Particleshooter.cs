using UnityEngine;
using System.Collections;

public class Particleshooter : MonoBehaviour {



	public Rigidbody2D myparticle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	
	



		if (Input.GetButtonDown ("Fire1")) {
			
			

			Rigidbody2D myprojectile = Instantiate(myparticle, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;

			if(myprojectile != null){

			}

	}






}
}