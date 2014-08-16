using UnityEngine;
using System.Collections;

public class SwordBehavior : MonoBehaviour {
	public float damage = 0;
	public float hitcount = 1;
	public float expcollector = 0;
	public bool hashitcount = false;
	public Transform playertransform;
	public Transform mytransform;
	public Transform mover;
	// Use this for initialization
	void Start () {
		mytransform = gameObject.GetComponent<Transform>();

		playertransform = GameObject.Find("eranger").GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
	


		if (playertransform != null && mytransform != null) {

						if (Mathf.Abs (playertransform.position.x - mytransform.position.x) >= 1.25f) {
		
							
								mover = mytransform;
		


								mytransform.position = playertransform.position;

			
						}

	
						if (Mathf.Abs (playertransform.position.y - mytransform.position.y) >= 1.25f) {
							

								mover = mytransform;
	
								mytransform.position = playertransform.position;
			
						}

				}


	}


	void OnTriggerEnter2D(Collider2D othercollider){
		
		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties> ();
		
		//when it hits, do damage 



		if (otherproperties.isplayer && expcollector > 0) {
			otherproperties.gainexp(expcollector);
			print ("You gained " + expcollector + " exp!");
			expcollector = 0;


				}



		if (otherproperties != null && !otherproperties.isplayer) {
			
			
			//if its not the player, hit it



			otherproperties.dealdamage (damage);

			//check weapon durability
			if(hashitcount){
				hitcount -= 1;

				
				if(hitcount <= 0){
					Destroy (this.gameObject);
					
				}


			}


		


			//if killing blow sword gains exp
			if (damage > otherproperties.hp){

				expcollector += otherproperties.deathexp;


			}



	


		}
		
		
		
		
		
		
		
		
		
	}
	
	void OnTriggerExit2D(Collider2D othercollider){
		
		
		
		
		
		
		
		
	}

}
