using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {

	public bool touching = false;
	public Vector3 bump = new Vector3();
	public Rigidbody2D touchingbody;


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

				touching = true;
				//executed when another triggercollider is touching


				myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties> ();
		
		
				if (otherproperties != null) {
			
			
			
			
			
			
			
						if (otherproperties.isplayer) {
				
								playermovement othermovement = othercollider.gameObject.GetComponent<playermovement> ();
				
								Rigidbody2D otherbody = othercollider.gameObject.GetComponent<Rigidbody2D> ();
				touchingbody = otherbody;
				
								othermovement.canmove = false;
				
								Vector3 stop = new Vector3 (0, 0, 0);


				
				otherbody.velocity = stop;
				othermovement.directionx = othermovement.directionx*(-1);
				othermovement.directiony = othermovement.directiony*(-1);


				
				
						}
			

				}
		}
	



	void OnTriggerExit2D(Collider2D othercollider){
		//executed when another triggercollider is no longertouching
		touching = false;
		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties>();

		if (otherproperties != null && otherproperties.isplayer) {

			playermovement othermovement = othercollider.gameObject.GetComponent<playermovement>();


			othermovement.canmove = true;



				}
	


		
	}

}
