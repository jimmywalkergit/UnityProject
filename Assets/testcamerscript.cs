using UnityEngine;
using System.Collections;

public class testcamerscript : MonoBehaviour {

	public Transform playertransform;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		if (playertransform != null) {

			Vector3 playerposition;
			playerposition = playertransform.position;


		


			float playerx, playery, playerz;
			
			playerx = playertransform.position.x;
			playery = playertransform.position.y;
			
			
			
			
			
			
			
			transform.position = new Vector3(playerx, playery, -10);
				}






	}








}
