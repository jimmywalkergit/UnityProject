using UnityEngine;
using System.Collections;

public class Bumperscript : MonoBehaviour {
	public Vector2 bump = new Vector2(-50,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}


	void OnTriggerEnter2D(Collider2D othercollider){
		//executed when another triggercollider is touching
		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties>();
		
		if (otherproperties != null) {
			
			

			Rigidbody2D otherbody = othercollider.GetComponent<Rigidbody2D>();
			
			
			
			if (otherproperties.isplayer){
				otherbody.AddForce(bump);
				print ("bumping player");
				;
				
			}
			
			
			
			
			
			
			
			
		} 
		
		
	}



}
