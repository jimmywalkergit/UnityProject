using UnityEngine;
using System.Collections;


public class MonsterBehavior : MonoBehaviour {
	public float damage;
	void Awake() {
		//executed when object is created
		
		
		
		
	}
	
	
	
	void Start () {
		//executed after awake
		
		
		
		
	}
	
	void Update () {
		//executed every frame
		
		
		
	}
	
	
	void Fixedupdate() {
		//executed each fixed framerate, rigidbody
		
		
	}
	
	void OnCollisionEnter2D(Collision2D othercollider){
		//executed when another collider is touching


	



	}
	
	void OnCollisionExit2D(Collision2D othercollider){
		//executed when another collider is no longer touching
		
	}
	
	void OnTriggerEnter2D(Collider2D othercollider){
		//executed when another triggercollider is touching

		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties> ();

		//if you walk into a player, it hurts
		if (otherproperties.isplayer) {
			otherproperties.dealdamage(damage);

				}

		
	}
	
	void OnTriggerExit2D(Collider2D othercollider){
		//executed when another triggercollider is no longertouching
		
	}
	

}
